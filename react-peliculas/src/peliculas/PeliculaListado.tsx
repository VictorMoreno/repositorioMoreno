import { peliculaDto } from "./Peliculas.model";
import ListadoGenerico from "../utilidades/ListadoGenerico";
import PeliculaIndividual from './PeliculaIndividual';

export default function PeliculaListado(props: peliculaListadoProps) {
  return (
    <ListadoGenerico listado={props.peliculas}>
      <div className="container mt-3">
        <div className="row">
        {props.peliculas?.map((pelicula) => (
          <PeliculaIndividual pelicula={pelicula} key={pelicula.id} />
        ))}
        </div>        
      </div>
    </ListadoGenerico>
  );
}

interface peliculaListadoProps {
  peliculas?: peliculaDto[];
}
