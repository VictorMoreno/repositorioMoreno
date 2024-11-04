import { useState } from "react";
import { urlCines } from "../utilidades/endpoints";
import { cineCreacionDto } from "./cines.model";
import FormularioCine from "./FomularioCine";
import { useNavigate } from "react-router-dom";
import axios from "axios";
import MostrarErrores from "../utilidades/MostrarErrores";

export default function CrearCines() {
  const navigate = useNavigate();
  const [errores, setErrores] = useState<string[]>([]);

  async function crear(cine: cineCreacionDto) {
    try {
      await axios.post(urlCines, cine);
      navigate("/cines");
    } catch (error) {
      console.error(error);
      setErrores(error.response.data);
    }
  }

  return (
    <>
      <h3>Crear Cines</h3>
      <MostrarErrores errores={errores} />
      <FormularioCine
        modelo={{ nombre: "" }}
        onSubmit={async (valores) => await crear(valores)}
      />
    </>
  );
}
