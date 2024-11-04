import { Form, Formik, FormikHelpers } from "formik";
import * as Yup from "yup";
import GrupoTextoFormulario from "../utilidades/GrupoTextoFormulario";
import Boton from "../utilidades/Boton";
import { Link } from "react-router-dom";
import { generoCreacionDto } from "./generos.model";

export default function FormularioGeneros(props: FormularioGenerosProps) {
  return (
    <Formik
      initialValues={props.modelo}
      onSubmit={props.onSubmit}
      validationSchema={Yup.object({
        nombre: Yup.string()
          .required("Este campo es requerido")
          .max(50, 'La longitud máxima es de 50 caracteres')
          .primeraLetraMayuscula(),
      })}
    >
      {(formikProps) => (
        <Form>
          <GrupoTextoFormulario campo="nombre" label="Nombre" />

          <Boton disable={formikProps.isSubmitting} type="submit">
            Guardar
          </Boton>
          <Link className="btn btn-danger mb-2" to="/generos">
            Cancelar
          </Link>
        </Form>
      )}
    </Formik>
  );
}

interface FormularioGenerosProps {
  modelo: generoCreacionDto;
  onSubmit(
    valores: generoCreacionDto,
    acciones: FormikHelpers<generoCreacionDto>
  ): void;
}
