import FormularioGeneros from "./FormularioGeneros";
import { urlGeneros } from "../utilidades/endpoints";
import { generoCreacionDto, generoDto } from "./generos.model";
import EditarEntidad from "../utilidades/EditarEntidad";

export default function EditarGeneros() {
  return (
    <>
      <EditarEntidad<generoCreacionDto, generoDto>
        url={urlGeneros}
        urlIndice="/generos"
        nombreEntidad="Géneros"
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
    </>
  );
}
