import EditarEntidad from "../utilidades/EditarEntidad";
import { convertirActorAFormData } from "../utilidades/FormDataUtils";
import { urlActores } from "../utilidades/endpoints";
import FormularioActores from "./FormularioActores";
import { actorCreacionDTO, actorDTO } from "./actores.model";

export default function EditarActores() {

  const transformar = (actor: actorDTO)=>{
    return {
      nombre: actor.nombre,
      fotoURL: actor.foto,
      biografia: actor.biografia,
      fechaNacimiento : actor.fechaNacimiento
    }
  }

  return (
    <>
      <EditarEntidad<actorCreacionDTO, actorDTO>
        url={urlActores}
        urlIndice="/actores"
        nombreEntidad="Actores"
        transformar={transformar}
        transformarFormData={convertirActorAFormData}
      >
        {(entidad, editar) => (
          <FormularioActores
            modelo={entidad}
            onSubmit={async (valores) => await editar(valores)}
          />
        )}
      </EditarEntidad>
    </>
  );
}
