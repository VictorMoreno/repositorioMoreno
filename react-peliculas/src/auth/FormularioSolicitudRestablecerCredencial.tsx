import { Form, Formik, FormikHelpers } from "formik";
import { credencialesUsuario } from "./auth.model";
import * as Yup from "yup";
import GrupoTextoFormulario from "../utilidades/GrupoTextoFormulario";
import Boton from "../utilidades/Boton";
import axios from "axios";
import { urlCuentas } from "../utilidades/endpoints";

export default function FormularioSolicitudRestablecerCredencial() {
  async function solicitarRestablecimiento(email: string) {
    try {
      // await axios({
      //   method: "post",
      //   url: `${urlCuentas}/solicitarRestablecimiento`,
      //   data: { Email: email },
      //   headers: { "Content-Type": "multipart/form-data" },
      // });

      // await axios.post(
      //   `${urlCuentas}/solicitarRestablecimiento`,
      //   { Email: email }
      // );

      await axios.post(
        `${urlCuentas}/solicitarRestablecimiento`,
        { email }, // El objeto debe coincidir con el modelo del backend
        {
            headers: { "Content-Type": "application/json" }, // Formato JSON
        }
    );

    } catch (error) {
      setErrores(error.response.data);
    }
  }

  return (
    <Formik
      initialValues={{ email: "" }}
      onSubmit={async (valores) =>
        await solicitarRestablecimiento(valores.email)
      }
      validationSchema={Yup.object({
        email: Yup.string()
          .required("Este campo es requerido")
          .email("Debe indicar un email válido"),
      })}
    >
      {(formikProps) => (
        <div className="container d-flex justify-content-center align-items-center min-vh-100">
          <div
            className="card p-4 shadow"
            style={{ maxWidth: "400px", width: "100%" }}
          >
            <h3 className="text-center mb-4">Restablecer contraseña</h3>
            <Form>
              <div className="mb-3">
                <GrupoTextoFormulario label="Email" campo="email" type="text" />
              </div>
              <div className="d-flex justify-content-between">
                <Boton
                  disable={formikProps.isSubmitting}
                  type="submit"
                  className="btn btn-primary"
                  style={{ width: "100%" }}
                >
                  Restablecer
                </Boton>
              </div>
            </Form>
          </div>
        </div>
      )}
    </Formik>
  );
}

interface FormularioSolicitudRestablecerCredencialProps {
  modelo: credencialesUsuario;
  onSubmit(
    valores: credencialesUsuario,
    acciones: FormikHelpers<credencialesUsuario>
  ): void;
}
function setErrores(data: any) {
  throw new Error("Function not implemented.");
}
