import { claim, respuestaAutenticacion } from "./auth.model";

const tokenKey = "token";
const tokenExpiracion = "token-expiracion";

export function guardarTokenLocalStorage(
  autenticacion: respuestaAutenticacion
) {
  localStorage.setItem(tokenKey, autenticacion.token);
  localStorage.setItem(tokenExpiracion, autenticacion.expiracion.toString());
}

export function obtenerClaims(): claim[] {
  const token = localStorage.getItem(tokenKey);

  if (!token) {
    return [];
  }

  const expiracion = localStorage.getItem(tokenExpiracion)!;
  const expiracionFecha = new Date(expiracion);

  if (expiracionFecha <= new Date()) {
    logout();
    return [];
  }

  const dataToken = JSON.parse(atob(token.split(".")[1]));
  const respuesta: claim[] = [];

  for (const propiedad in dataToken) {
    respuesta.push({ nombre: propiedad, valor: dataToken[propiedad] });
  }

  return respuesta;
}

export function logout(){
    localStorage.removeItem(tokenKey);
    localStorage.removeItem(tokenExpiracion);
}

export function obtenerToken(){
  return localStorage.getItem(tokenKey);
}