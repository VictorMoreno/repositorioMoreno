import axios, { AxiosResponse } from "axios";
import { cineDTO } from "../cines/cines.model";
import { generoDto } from "../generos/generos.model";
import { urlPeliculas } from "../utilidades/endpoints";
import FormularioPeliculas from "./FormularioPeliculas";
import { useEffect, useState } from "react";
import { peliculasPostGetDto, peliculaCreacionDto } from "./Peliculas.model";
import Cargando from "../utilidades/Cargando";
import { convertirPeliculaAFormData } from "../utilidades/FormDataUtils";
import { useNavigate } from "react-router-dom";
import MostrarErrores from "../utilidades/MostrarErrores";

export default function CrearPeliculas() {
  const navigate = useNavigate();
  const [generosNoSeleccionados, setGenerosNoSeleccionados] = useState<
    generoDto[]
  >([]);
  const [cinesNoSeleccionados, setCinesNoSeleccionados] = useState<cineDTO[]>(
    []
  );
  const [cargado, setCargado] = useState(false);
  const [errores, setErrores] = useState<string[]>([]);

  useEffect(() => {
    axios
      .get(`${urlPeliculas}/PostGet`)
      .then((respuesta: AxiosResponse<peliculasPostGetDto>) => {
        setGenerosNoSeleccionados(respuesta.data.generos);
        setCinesNoSeleccionados(respuesta.data.cines);
        setCargado(true);
      });
  }, []);

  async function crear(pelicula: peliculaCreacionDto) {
    try {
      const formData = convertirPeliculaAFormData(pelicula);

      await axios({
        method: "POST",
        url: urlPeliculas,
        data: formData,
        headers: { "Content-Type": "multipart/form-data" },
      }).then((respuesta: AxiosResponse<number>) => {
        navigate(`/pelicula/${respuesta.data}`);
      });
    } catch (error) {
      setErrores(error.response.data);
    }
  }

  return (
    <>
      <h3>Crear Película</h3>

      <MostrarErrores errores={errores} />
      {cargado ? (
        <FormularioPeliculas
          actoresSeleccionados={[]}
          cinesSeleccionados={[]}
          cinesNoSeleccionados={cinesNoSeleccionados}
          generosNoSeleccionados={generosNoSeleccionados}
          generosSeleccionados={[]}
          modelo={{ titulo: "", enCines: false, trailer: "" }}
          onSubmit={async (valores) => crear(valores)}
        />
      ) : (
        <Cargando />
      )}
    </>
  );
}
