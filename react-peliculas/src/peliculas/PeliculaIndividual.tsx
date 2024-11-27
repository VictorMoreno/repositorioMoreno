import { peliculaDto } from "./Peliculas.model";
import css from "./PeliculaIndividual.module.css";
import { Link } from "react-router-dom";
import Boton from "../utilidades/Boton";
import axios from "axios";
import confirmar from "../utilidades/Confirmar";
import { urlPeliculas } from "../utilidades/endpoints";
import { useContext } from "react";
import AlertaContext from "../utilidades/AlertaContext";
import Autorizado from "../auth/Autorizado";
import noDisponible from "../NoDisponible.jpg";

export default function PeliculaIndividual(props: peliculaIndividualProps) {
  const construirUrl = () => `/pelicula/${props.pelicula.id}`;
  const alerta = useContext(AlertaContext);

  function borrarPelicula() {
    axios.delete(`${urlPeliculas}/${props.pelicula.id}`).then(() => {
      alerta();
    });
  }

  return (
    <div key={props.pelicula.id} className="col-md-4 mb-3">
      <Link to={construirUrl()}>
        <img
          src={props.pelicula.poster ? props.pelicula.poster : noDisponible}
          alt="Poster"
          height={500}
          width="100%"
          onClick={construirUrl}
          style={{ cursor: "pointer" }}
        />
      </Link>

      <h5 className="text-center">
        {/* <Link className={css.linkSinEstilo} to={construirUrl()}> */}
          {props.pelicula.titulo}
        {/* </Link> */}
      </h5>

      <Autorizado
        role="admin"
        autorizado={
          <div className={css.div}>
            <Link
              style={{ marginRight: "1rem" }}
              className="btn btn-info"
              to={`/peliculas/editar/${props.pelicula.id}`}
            >
              Editar
            </Link>
            <Boton
              className="btn btn-danger"
              onClick={() => confirmar(() => borrarPelicula())}
              type={"button"}
              disable={false}
              style={null}
            >
              Borrar
            </Boton>
          </div>
        }
      />
    </div>
  );
}

interface peliculaIndividualProps {
  pelicula: peliculaDto;
}
