import axios, { AxiosResponse } from "axios";
import { credencialesUsuario, respuestaAutenticacion } from "./auth.model";
import FormularioAuth from "./FormularioAuth";
import { urlCuentas } from "../utilidades/endpoints";
import { useContext } from "react";
import { guardarTokenLocalStorage, obtenerClaims } from "./manejadorJwt";
import AutenticacionContext from "./AutenticacionContext";
import { useNavigate } from "react-router-dom";

export default function Registro() {
  const { actualizar } = useContext(AutenticacionContext);
  const navigate = useNavigate();

  async function registrar(credenciales: credencialesUsuario) {
    try {
      const respuesta: AxiosResponse<respuestaAutenticacion> = await axios.post(
        `${urlCuentas}/crear`,
        credenciales
      );
      guardarTokenLocalStorage(respuesta.data);
      actualizar(obtenerClaims());
      navigate("/");
    } catch (error) {    
    }
  }

  return (
    <>
      <FormularioAuth
        titulo="Crear cuenta"
        modelo={{ email: "", password: "" }}
        onSubmit={async (valores) => await registrar(valores)}
      />
    </>
  );
}
