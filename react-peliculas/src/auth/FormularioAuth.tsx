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
          .email("Debe indicar un email válido"),
        password: Yup.string().required("Este campo es requerido"),
      })}
    >
      {(formikProps) => (
        <div className="container d-flex justify-content-center align-items-center min-vh-100">
          <div
            className="card p-4 shadow bg-dark text-light"
            style={{ maxWidth: "400px", width: "100%" }}
          >
            <h3 className="text-center mb-4">{props.titulo}</h3>
            <Form>
              <div className="mb-3">
                <GrupoTextoFormulario label="Email" campo="email" type="text" />
              </div>
              <div className="mb-4">
                <GrupoTextoFormulario
                  label="Password"
                  campo="password"
                  type="password"
                />
              </div>
              <div className="d-flex justify-content-between">
                <Boton
                  disable={formikProps.isSubmitting}
                  type="submit"
                  className="btn btn-primary"
                  style={{ width: "100%" }}
                >
                  {props.esLogin ? "Iniciar sesión" : "Crear"}
                </Boton>
                {props.esLogin ? null : (
                  <Link
                    className="btn btn-secondary ms-2"
                    to="/"
                    style={{ width: "100%" }}
                  >
                    Cancelar
                  </Link>
                )}
              </div>
              <p></p>
              <div className="text-center">
                <Link to="/usuarios/solicitudRestablecimiento" className="text-decoration-none">
                  ¿Has olvidado la contraseña?
                </Link>
              </div>
            </Form>
          </div>
        </div>
      )}
    </Formik>
  );
}

interface FormularioAuthProps {
  modelo: credencialesUsuario;
  esLogin?: boolean;
  titulo: string;
  onSubmit(
    valores: credencialesUsuario,
    acciones: FormikHelpers<credencialesUsuario>
  ): void;
}
