import EditarEntidad from "../utilidades/EditarEntidad";
import { urlCines } from "../utilidades/endpoints";
import { cineCreacionDto, cineDTO } from "./cines.model";
import FormularioCine from "./FomularioCine";

export default function EditarCines() {
  return (
    <EditarEntidad<cineCreacionDto, cineDTO>
      url={urlCines}
      urlIndice="/cines"
      nombreEntidad="Cines"
      transformar={(entidad: cineDTO) => entidad}
    >
      {(entidad, editar) => (
        <FormularioCine
          modelo={entidad}
          onSubmit={async (valores) => {
            await editar(valores);
          }}
        />
      )}
    </EditarEntidad>
  );
}
