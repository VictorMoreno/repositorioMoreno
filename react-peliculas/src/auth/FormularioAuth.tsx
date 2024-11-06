import { Form, Formik, FormikHelpers } from "formik";
import { credencialesUsuario } from "./auth.model";
import * as Yup from "yup";
import { Link } from "react-router-dom";
import GrupoTextoFormulario from "../utilidades/GrupoTextoFormulario";
import Boton from "../utilidades/Boton";

export default function FormularioAuth(props: FormularioAuthProps) {
  return (
    <Formik
      initialValues={props.modelo}
      onSubmit={props.onSubmit}
      validationSchema={Yup.object({
        email: Yup.string()
          .required("Este campo es requerido")
          .email("Debe indicar un email valido"),
        password: Yup.string().required("Este campo es requerido"),
      })}
    >
      {(formikProps) => (
        <Form>
          <GrupoTextoFormulario label="Email" campo="email" />
          <GrupoTextoFormulario
            label="Password"
            campo="password"
            type="password"
          />
          <Boton
            disable={formikProps.isSubmitting}
            type="submit"            
            className={"btn btn-primary"}
            style={null}
          >
            Enviar
          </Boton>
          <Link className="btn btn-secondary" to="/">
            Cancelar
          </Link>
        </Form>
      )}
    </Formik>
  );
}

interface FormularioAuthProps {
  modelo: credencialesUsuario;
  onSubmit(
    valores: credencialesUsuario,
    acciones: FormikHelpers<credencialesUsuario>
  ): void;
}
