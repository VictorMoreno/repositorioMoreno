import axios, { AxiosResponse } from "axios";
import PeliculaListado from "./peliculas/PeliculaListado";
import { landingPageDto } from "./peliculas/Peliculas.model";
import { useEffect, useState } from "react";
import { urlPeliculas } from "./utilidades/endpoints";
import AlertaContext from "./utilidades/AlertaContext";

export default function PaginaPrincipal() {
  const [peliculas, setPeliculas] = useState<landingPageDto>({});

  useEffect(() => {
    cargarDatos();
  }, []);

  function cargarDatos() {
    axios
      .get(`${urlPeliculas}/landingFilms`)
      .then((respuesta: AxiosResponse<landingPageDto>) => {
        setPeliculas(respuesta.data);
      });
  }

  return (
    <>
      <AlertaContext.Provider
        value={() => {
          cargarDatos();
        }}
      >
        <h3> En cartelera</h3>
        <PeliculaListado peliculas={peliculas.enCines} />
        <h3> Próximos Estrenos</h3>
        <PeliculaListado peliculas={peliculas.proximosEstrenos} />
      </AlertaContext.Provider>
    </>
  );
}
