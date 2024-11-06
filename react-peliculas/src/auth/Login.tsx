import { credencialesUsuario, respuestaAutenticacion } from "./auth.model";
import FormularioAuth from "./FormularioAuth";
import { urlCuentas } from "../utilidades/endpoints";
import axios from "axios";
import { useContext, useState } from "react";
import MostrarErrores from "../utilidades/MostrarErrores";
import { guardarTokenLocalStorage, obtenerClaims } from "./manejadorJwt";
import AutenticacionContext from "./AutenticacionContext";
import { useNavigate } from "react-router-dom";

export default function Login() {
  const { actualizar } = useContext(AutenticacionContext);
  const [errores, setErrores] = useState<string[]>([]);
  const navigate = useNavigate();

  async function login(credenciales: credencialesUsuario) {
    try {
      const respuesta = await axios.post<respuestaAutenticacion>(
        `${urlCuentas}/login`,
        credenciales
      );
      guardarTokenLocalStorage(respuesta.data);
      actualizar(obtenerClaims());
      navigate("/");
    } catch (error) {
      setErrores(error.response.data);
    }
  }

  return (
    <>
      <h3>Login</h3>
      <MostrarErrores errores={errores} />
      <FormularioAuth
        modelo={{ email: "", password: "" }}
        onSubmit={async (valores) => {
          await login(valores);
        }}
      />
    </>
  );
}
