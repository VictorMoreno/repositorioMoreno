import { Form, Formik } from "formik";
import * as Yup from "yup";
import GrupoTextoFormulario from "../utilidades/GrupoTextoFormulario";
import Boton from "../utilidades/Boton";
import axios from "axios";
import { urlCuentas } from "../utilidades/endpoints";
import Swal from "sweetalert2";
import { restablecerCredencial } from "./auth.model";
import { useState } from "react";
import MostrarErrores from "../utilidades/MostrarErrores";
import { useLocation, useNavigate } from "react-router-dom";

export default function FormularioRestablecerCredencial() {
  const [errores, setErrores] = useState<string[]>([]);
  const location = useLocation();
  const navigate = useNavigate();

  async function restablecer(valores: restablecerCredencial) {
    try {
      if (valores.password !== valores.passwordRepetida) {
        Swal.fire({
          title: "Error",
          text: "Las contraseñas introducidas no coinciden",
          icon: "error",
        });
      } else {
        const params = new URLSearchParams(location.search);
        const email = decodeURIComponent(params.get("email") || "");
        const token = decodeURIComponent(params.get("token") || "");

        const datos = {
          email: email,
          token: token,
          password: valores.password,
        };
        await axios.post(`${urlCuentas}/usuarios/restablecer`, datos);

        Swal.fire({
          title: "Éxito",
          text: "Contraseña restablecida correctamente.",
          icon: "success",
        }).then((result) => {
          navigate("/login");
        });
      }
    } catch (error) {
      setErrores(error.response.data);
    }
  }

  return (
    <>
      <MostrarErrores errores={errores} />
      <Formik
        initialValues={{ password: "", passwordRepetida: "" }}
        onSubmit={async (valores) => await restablecer(valores)}
        validationSchema={Yup.object({
          password: Yup.string().required("Este campo es requerido"),
          passwordRepetida: Yup.string().required("Este campo es requerido"),
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
                    campo="password"
                    type="password"
                  />
                  <GrupoTextoFormulario
                    label="Repite contraseña"
                    campo="passwordRepetida"
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
    </>
  );
}
