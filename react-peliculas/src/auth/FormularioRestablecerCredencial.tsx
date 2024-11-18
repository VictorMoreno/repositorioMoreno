import { Form, Formik } from "formik";
import * as Yup from "yup";
import GrupoTextoFormulario from "../utilidades/GrupoTextoFormulario";
import Boton from "../utilidades/Boton";
import axios from "axios";
import { urlCuentas } from "../utilidades/endpoints";
import Swal from "sweetalert2";
import { restablecerCredencial } from "./auth.model";

export default function FormularioRestablecerCredencial() {
  async function restablecer(valores: restablecerCredencial) {
    try {
      await axios.post(`${urlCuentas}/restablecer`, valores);

      Swal.fire({
        title: "Éxito",
        text: "Contraseña restablecida correctamente.",
        icon: "success",
      });
    } catch (error) {
      setErrores(error.response.data);
    }
  }

  return (
    <Formik
      initialValues={{ password: "", passwordRepetida: "" }}
      onSubmit={async (valores) => await restablecer(valores)}
      validationSchema={Yup.object({
        contraseña: Yup.string()
          .required("Este campo es requerido"),
        contraseñaRepetida: Yup.string()
          .required("Este campo es requerido"),
      })}
    >
      {(formikProps) => (
        <div className="container d-flex justify-content-center align-items-center min-vh-100">
          <div
            className="card p-4 shadow"
            style={{ maxWidth: "400px", width: "100%" }}
          >
            <h3 className="text-center mb-4">Crear contraseña</h3>
            <Form>
              <div className="mb-3">
                <GrupoTextoFormulario
                  label="Nueva contraseña"
                  campo="contraseña"
                  type="password"
                />
                <GrupoTextoFormulario
                  label="Repite contraseña"
                  campo="contraseñaRepetida"
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

function setErrores(data: any) {
  throw new Error("Function not implemented.");
}
