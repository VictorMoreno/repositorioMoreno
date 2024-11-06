import FormularioGeneros from "./FormularioGeneros";
import { urlGeneros } from "../utilidades/endpoints";
import { generoCreacionDto, generoDto } from "./generos.model";
import EditarEntidad from "../utilidades/EditarEntidad";
import { ReactElement } from "react";

export default function EditarGeneros() {
  return (
    <>
      <EditarEntidad<generoCreacionDto, generoDto>
        url={urlGeneros}
        urlIndice="/generos"
        nombreEntidad="Géneros"        
        transformar={(entidad: generoDto) => entidad}
      >
        {(entidad, editar) => (
          <FormularioGeneros
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
