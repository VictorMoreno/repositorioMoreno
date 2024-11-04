import FormularioGeneros from "../generos/FormularioGeneros";
import EditarEntidad from "../utilidades/EditarEntidad";
import { urlCines } from "../utilidades/endpoints";
import { cineCreacionDto, cineDTO } from './cines.model';

export default function EditarCines() {
  return (
    <EditarEntidad<cineCreacionDto, cineDTO>
        url={urlCines}
        urlIndice="/cines"
        nombreEntidad="Cines"
      >
        {(entidad, editar) => (
          <FormularioGeneros
            modelo={entidad}
            onSubmit={async (valores) => {
              console.log(valores);
              await editar(valores);
            }}
          />
        )}
      </EditarEntidad>
  );
}
