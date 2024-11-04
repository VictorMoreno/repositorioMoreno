import { useEffect, useState } from "react";
import FormularioPeliculas from "./FormularioPeliculas";
import { peliculaCreacionDto, peliculasPutGetDto } from "./Peliculas.model";
import axios, { AxiosResponse } from "axios";
import { urlPeliculas } from "../utilidades/endpoints";
import { useParams } from "react-router-dom";
import Cargando from "../utilidades/Cargando";
import { convertirPeliculaAFormData } from "../utilidades/FormDataUtils";
import { useNavigate } from "react-router-dom";
import MostrarErrores from "../utilidades/MostrarErrores";

export default function EditarPeliculas() {
  const [pelicula, setPelicula] = useState<peliculaCreacionDto>();
  const [peliculaPutGet, setPeliculaPutGet] = useState<peliculasPutGetDto>();
  const [errores, setErrores] = useState<string[]>([]);
  const { id }: any = useParams();
  const navigate = useNavigate();

  useEffect(() => {
    axios
      .get(`${urlPeliculas}/PutGet/${id}`)
      .then((respuesta: AxiosResponse<peliculasPutGetDto>) => {
        const modelo: peliculaCreacionDto = {
          titulo: respuesta.data.pelicula.titulo,
          enCines: respuesta.data.pelicula.enCines,
          trailer: respuesta.data.pelicula.trailer,
          posterURL: respuesta.data.pelicula.poster,
          resumen: respuesta.data.pelicula.resumen,
          fechaLanzamiento: new Date(respuesta.data.pelicula.fechaLanzamiento),
        };

        setPelicula(modelo);
        setPeliculaPutGet(respuesta.data);
      });
  }, [id]);

  async function editar(peliculaEditar: peliculaCreacionDto) {
    try {
      const formData = convertirPeliculaAFormData(peliculaEditar);

      await axios({
        method: "put",
        url: `${urlPeliculas}/${id}`,
        data: formData,
        headers: { "Content-Type": "multipart/form-data" },
      });

      navigate(`/pelicula/${id}`);
    } catch (error) {
      setErrores(error.response.data);
    }
  }

  return (
    <>
      <h3>Editar Película</h3>
      <MostrarErrores errores={errores} />
      {pelicula && peliculaPutGet ? (
        <FormularioPeliculas
          actoresSeleccionados={peliculaPutGet.actores}
          cinesSeleccionados={peliculaPutGet.cinesSeleccionados}
          cinesNoSeleccionados={peliculaPutGet.cinesNoSeleccionados}
          generosNoSeleccionados={peliculaPutGet.generosNoSeleccionados}
          generosSeleccionados={peliculaPutGet.generosSeleccionados}
          modelo={pelicula}
          onSubmit={async valores => await editar(valores)}
        />
      ) : (
        <Cargando />
      )}
    </>
  );
}
