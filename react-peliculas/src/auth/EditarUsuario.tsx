import EditarEntidad from "../utilidades/EditarEntidad";
import { urlCuentas } from "../utilidades/endpoints";
import { usuarioDto } from "./auth.model";
import FormularioUsuario from "./FormularioUsuario";

export default function EditarUsuario() {
  return (
    <>
      <EditarEntidad<usuarioDto, usuarioDto>
        url={urlCuentas}
        urlIndice="/usuarios"
        nombreEntidad="Usuario"
        transformar={(entidad: usuarioDto) => entidad}
      >
        {(entidad, editar) => (
          <FormularioUsuario
            modelo={entidad}
            onSubmit={async (valores) => {
              await editar(valores);
            }}
          />
        )}
      </EditarEntidad>
    </>
  );
}
