import { generoDto } from "./generos.model";
import { urlGeneros } from "../utilidades/endpoints";
import IndiceEntidad from "../utilidades/IndiceEntidad";

export default function IndiceGeneros() {
  return (
    <>
      <IndiceEntidad<generoDto>
        url={urlGeneros}
        urlCrear="generos/crear"
        titulo="Géneros"
        nombreEntidad="Género"
      >
        {(generos, botones) => (
          <>
            <thead>
              <tr>
                <th></th>
                <th>Nombre</th>
              </tr>
            </thead>
            <tbody>
              {generos?.map((genero) => (
                <tr key={genero.id}>
                  <td>{botones(`editar/${genero.id}`, genero.id)}</td>
                  <td>{genero.nombre}</td>
                </tr>
              ))}
            </tbody>
          </>
        )}
      </IndiceEntidad>
    </>
  );
}
