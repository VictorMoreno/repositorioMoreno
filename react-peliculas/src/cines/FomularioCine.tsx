import { Form, Formik, FormikHelpers } from "formik";
import { cineCreacionDto } from "./cines.model";
import * as Yup from "yup";
import GrupoTextoFormulario from "../utilidades/GrupoTextoFormulario";
import Boton from "../utilidades/Boton";
import { Link } from "react-router-dom";
import FormularioMapa from "../utilidades/FormularioMapa";
import { coordenadaDto } from "../utilidades/coordenada.module";

export default function FormularioCine(props: formularioCineProps) {
  function transformarCoordenadas(): coordenadaDto[] | undefined {
    if (props.modelo.latitud && props.modelo.longitud) {
      const respuesta: coordenadaDto = {
        lat: props.modelo.latitud,
        lng: props.modelo.longitud,
      };

      return[respuesta];
    }

    return undefined;
  }

  return (
    <Formik
      initialValues={props.modelo}
      onSubmit={props.onSubmit}
      validationSchema={Yup.object({
        nombre: Yup.string()
          .required("Este campo es requerido")
          .primeraLetraMayuscula(),
      })}
    >
      {(formikProps) => (
        <Form>
          <GrupoTextoFormulario label="Nombre" campo="nombre" />

          <div style={{ marginBottom: "1 rem" }}>
            <FormularioMapa
              campoLat="latitud"
              campoLng="longitud"
              coordenadas={transformarCoordenadas()}
            />
          </div>

          <Boton disable={formikProps.isSubmitting} type="submit">
            Salvar
          </Boton>
          <Link className="btn btn-secondary" to="/cines">
            Cancelar
          </Link>
        </Form>
      )}
    </Formik>
  );
}

interface formularioCineProps {
  modelo: cineCreacionDto;
  onSubmit(
    valores: cineCreacionDto,
    acciones: FormikHelpers<cineCreacionDto>
  ): void;
}
