import { peliculaDto } from "./Peliculas.model";
import css from "./PeliculaListado.module.css";
import ListadoGenerico from "../utilidades/ListadoGenerico";
import PeliculaIndividual from './PeliculaIndividual';

export default function PeliculaListado(props: peliculaListadoProps) {
  return (
    <ListadoGenerico listado={props.peliculas}>
      <div className={css.div}>
        {props.peliculas?.map((pelicula) => (
          <PeliculaIndividual pelicula={pelicula} key={pelicula.id} />
        ))}
      </div>
    </ListadoGenerico>
  );
}

interface peliculaListadoProps {
  peliculas?: peliculaDto[];
}
