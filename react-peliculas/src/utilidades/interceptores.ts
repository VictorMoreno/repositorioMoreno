import axios from "axios";
import { obtenerToken } from "../auth/manejadorJwt";

export function configurarInterceptor() {
  
  axios.interceptors.request.use(
    function (config) {
      const token = obtenerToken();
      if (token) {
        config.headers.Authorization = `Bearer ${token}`;
      }

      return config;
    },
    function (error) {
      return Promise.reject(error);
    }
  );

  axios.interceptors.response.use(
    (response) => response,
    (error) => {
      if (error.response) {
        const { status } = error.response;

        if (status === 401) {
          window.location.href = "/sesion";
        } else {
          window.location.href = "/error";
        }
      } else {
        console.error("Error de red o tiempo de espera excedido.");
      }

      return Promise.reject(error);
    }
  );
}
