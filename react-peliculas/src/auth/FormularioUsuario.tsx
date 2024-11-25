import { Form, Formik, FormikHelpers } from "formik";
import * as Yup from "yup";
import GrupoTextoFormulario from "../utilidades/GrupoTextoFormulario";
import Boton from "../utilidades/Boton";
import { Link } from "react-router-dom";
import { usuarioDto } from "./auth.model";

export default function FormularioUsuario(props: FormularioUsuarioProps) {
  return (
    <Formik
      initialValues={props.modelo}
      onSubmit={props.onSubmit}
      validationSchema={Yup.object({
        email: Yup.string()
          .required("Este campo es requerido")
          .email("Debe indicar un email válido"),
      })}
    >
      {(formikProps) => (
        <Form>
          <GrupoTextoFormulario campo="email" label="Email" type={"text"} />

          <Boton
            disable={formikProps.isSubmitting}
            type="submit"            
            className={"btn btn-primary"}
            style={null}
          >
            Guardar
          </Boton>
          <Link className="btn btn-danger" to="/usuarios">
            Cancelar
          </Link>
        </Form>
      )}
    </Formik>
  );
}

interface FormularioUsuarioProps {
  modelo: usuarioDto;
  onSubmit(
    valores: usuarioDto,
    acciones: FormikHelpers<usuarioDto>
  ): void;
}
