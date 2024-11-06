import IndiceEntidad from "../utilidades/IndiceEntidad";
import { urlCines } from "../utilidades/endpoints";
import { cineDTO } from './cines.model';

export default function IndiceCines() {
  return (
    <>
      <IndiceEntidad<cineDTO>
        url={urlCines}
        urlCrear="crear"
        titulo="Cines"
        nombreEntidad="Cines"
      >
        {(cines, botones) => (
          <>
            <thead>
              <tr>
                <th></th>
                <th>Nombre</th>
              </tr>
            </thead>
            <tbody>
              {cines?.map((cine) => (
                <tr key={cine.id}>
                  <td>{botones(`editar/${cine.id}`, cine.id)}</td>
                  <td>{cine.nombre}</td>
                </tr>
              ))}
            </tbody>
          </>
        )}
      </IndiceEntidad>
    </>
  );
}
