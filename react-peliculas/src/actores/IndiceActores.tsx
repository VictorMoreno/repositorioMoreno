import IndiceEntidad from "../utilidades/IndiceEntidad";
import { actorDTO } from "./actores.model";
import { urlActores } from "../utilidades/endpoints";

export default function IndiceActores() {
  return (
    <>
      <IndiceEntidad<actorDTO>
        url={urlActores}
        urlCrear="crear"
        titulo="Actores"
        nombreEntidad="Actor"
      >
        {(actores, botones) => (
          <>
            <thead>
              <tr>
                <th></th>
                <th>Nombre</th>
              </tr>
            </thead>
            <tbody>
              {actores?.map((actor) => (
                <tr key={actor.id}>
                  <td>{botones(`editar/${actor.id}`, actor.id)}</td>
                  <td>{actor.nombre}</td>
                </tr>
              ))}
            </tbody>
          </>
        )}
      </IndiceEntidad>
    </>
  );
}
