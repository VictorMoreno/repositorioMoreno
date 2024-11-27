import axios from "axios";
import { obtenerToken } from "../auth/manejadorJwt";
import Swal from "sweetalert2";

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
        } else if (status === 422) {
          Swal.fire({
            title: "Error",
            text: error.response.data.message,
            icon: "error",
          });
        }
      } else {
        window.location.href = "/error";
      }

      return Promise.reject(error);
    }
  );
}
