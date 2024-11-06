import axios from "axios";
import { credencialesUsuario, respuestaAutenticacion } from "./auth.model";
import FormularioAuth from "./FormularioAuth";
import { urlCuentas } from "../utilidades/endpoints";
import { useContext, useState } from "react";
import MostrarErrores from "../utilidades/MostrarErrores";
import { guardarTokenLocalStorage, obtenerClaims } from "./manejadorJwt";
import AutenticacionContext from "./AutenticacionContext";
import { useNavigate } from "react-router-dom";

export default function Registro() {
  const [errores, setErrores] = useState<string[]>([]);
  const { actualizar } = useContext(AutenticacionContext);
  const navigate = useNavigate();

  async function registrar(credenciales: credencialesUsuario) {
    try {
      const respuesta = await axios.post<respuestaAutenticacion>(
        `${urlCuentas}/crear`,
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
      <h3>Registro</h3>
      <MostrarErrores errores={errores} />
      <FormularioAuth
        modelo={{ email: "", password: "" }}
        onSubmit={async (valores) => await registrar(valores)}
      />
    </>
  );
}
