import axios, { AxiosResponse } from "axios";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { urlPeliculas, urlRatings } from "../utilidades/endpoints";
import { peliculaDto } from "./Peliculas.model";
import Cargando from "../utilidades/Cargando";
import { Link } from "react-router-dom";
import ReactMarkdown from "react-markdown";
import Mapa from "../utilidades/Mapa";
import { coordenadaDto } from "../utilidades/coordenada.module";
import Rating from "../utilidades/Rating";
import Swal from "sweetalert2";

export default function DetallePelicula() {
  const { id }: any = useParams();
  const [pelicula, setPelicula] = useState<peliculaDto>();

  useEffect(() => {
    axios
      .get(`${urlPeliculas}/${id}`)
      .then((respuesta: AxiosResponse<peliculaDto>) => {
        respuesta.data.fechaLanzamiento = new Date(
          respuesta.data.fechaLanzamiento
        );
        setPelicula(respuesta.data);
      });
  }, [id]);

  function generarUrlYoutubeEmbebido(url: any) {
    if (!url) {
      return "";
    }

    var videoId = url.split("v=")[1];
    var posicionAmpersand = videoId.indexOf("&");

    if (posicionAmpersand !== -1) {
      videoId = videoId.substring(0, posicionAmpersand);
    }

    return `https://www.youtube.com/embed/${videoId}`;
  }

  function transformarCoordenadas(): coordenadaDto[] {
    if (pelicula?.cines) {
      const coordenadas = pelicula.cines.map((cine) => {
        return {
          lat: cine.latitud,
          lng: cine.longitud,
          nombre: cine.nombre,
        } as coordenadaDto;
      });

      return coordenadas;
    }

    return [];
  }

  async function onVote(voto: number) {
    await axios.post(urlRatings, { puntuacion: voto, idPelicula: id });
    Swal.fire({ icon: "success", title: "Voto recibido" });
  }

  return pelicula ? (
    <div style={{ display: "flex" }}>
      <div>
        <h2>
          {pelicula.titulo} ({pelicula.fechaLanzamiento.getFullYear()})
        </h2>
        {pelicula.generos.map((genero) => (
          <Link
            key={genero.id}
            style={{ marginRight: "5px" }}
            className="btn btn-primary btn-sm rounded-pill"
            to={`/peliculas/filtrar?generoId=${genero.id}`}
          >
            {genero.nombre}
          </Link>
        ))}
        | {pelicula.fechaLanzamiento.toDateString()}| Voto promedio:
        {pelicula.promedioVoto}
        | Tu voto:
        <Rating
          maximoValor={5}
          valorSeleccionado={pelicula.votoUsuario!}
          onChange={onVote}
        />
        <div style={{ display: "flex", margin: "1rem" }}>
          <span style={{ display: "inline-block", marginRight: "1rem" }}>
            <img
              src={pelicula.poster}
              style={{ width: "225px", height: "315px" }}
              alt="poster"
            />
          </span>
          {pelicula.trailer ? (
            <div>
              <iframe
                title="youtube-trailer"
                width="560"
                height="315"
                src={generarUrlYoutubeEmbebido(pelicula.trailer)}
                frameBorder={0}
                allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"
                allowFullScreen
              ></iframe>
            </div>
          ) : null}
        </div>
        {pelicula.resumen ? (
          <div style={{ marginTop: "1rem" }}>
            <h3>Resumen</h3>
            <div>
              <ReactMarkdown>{pelicula.resumen}</ReactMarkdown>
            </div>
          </div>
        ) : null}
        {pelicula.actores && pelicula.actores.length > 0 ? (
          <div style={{ marginTop: "1rem" }}>
            <h3>Actores</h3>
            <div style={{ display: "flex", flexDirection: "column" }}>
              {pelicula.actores?.map((actor) => (
                <div key={actor.id} style={{ marginBottom: "2px" }}>
                  <img
                    alt="foto"
                    src={actor.foto}
                    style={{ width: "50px", verticalAlign: "middle" }}
                  />
                  <span
                    style={{
                      display: "inline-block",
                      width: "200px",
                      marginLeft: "1rem",
                    }}
                  >
                    {actor.nombre}
                  </span>
                  <span
                    style={{
                      display: "inline-block",
                      width: "45px",
                    }}
                  >
                    ...
                  </span>
                  <span>{actor.personaje}</span>
                </div>
              ))}
            </div>
          </div>
        ) : null}
        {pelicula.cines && pelicula.cines.length > 0 ? (
          <div>
            <h2>Mostrandose en los siguientes cines</h2>
            <Mapa
              coordenadas={transformarCoordenadas()}
              soloLectura={true}
              height={"500px"}
              manejarClickMapa={(coordenadas: coordenadaDto) => {}}
            />
          </div>
        ) : null}
      </div>
    </div>
  ) : (
    <Cargando />
  );
}
