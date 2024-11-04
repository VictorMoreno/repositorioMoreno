import axios from "axios";
import FormularioGeneros from "./FormularioGeneros";
import { generoCreacionDto } from "./generos.model";
import { urlGeneros } from "../utilidades/endpoints";
import { useNavigate } from "react-router-dom";
import MostrarErrores from "../utilidades/MostrarErrores";
import { useState } from "react";

export default function CrearGeneros() {
  const navigate = useNavigate();
  const [errores, setErrores] = useState<string[]>([]);

  async function crear(genero: generoCreacionDto) {
    try {
      await axios.post(urlGeneros, genero);
      navigate("/generos");
    } catch (error) {
      console.error(error);
      setErrores(error.response.data);
    }
  }

  return (
    <>
      <h3>Crear Género</h3>
      <MostrarErrores errores={errores} />
      <FormularioGeneros
        modelo={{ nombre: "" }}
        onSubmit={async (valores) => {
          await crear(valores);
        }}
      />
    </>
  );
}
