import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { useContext, useEffect, useState } from "react";
import "./Rating.css";
import AutenticacionContext from "../auth/AutenticacionContext";
import Swal from "sweetalert2";

export default function Rating(props: RatingProps) {
  const { claims } = useContext(AutenticacionContext);
  const [maximoValorArr, setMaximoValorArr] = useState<number[]>([]);
  const [valorSeleccionado, setValorSeleccionado] = useState(
    props.valorSeleccionado
  );
  useEffect(() => {
    setMaximoValorArr(Array(props.maximoValor).fill(0));
  }, [props.maximoValor]);

  function manejarMouseOver(voto: number) {
    setValorSeleccionado(voto);
  }

  function manejarClick(voto: number): void {
    if (claims.length === 0) {
      Swal.fire({
        title: "Error",
        text: "Debes loguearte para votar",
        icon: "error",
      });
      return;
    }

    setValorSeleccionado(voto);
    props.onChange(voto);
  }

  return (
    <>
      {maximoValorArr.map((valor, indice) => (
        <FontAwesomeIcon
          icon="star"
          key={indice}
          className={`fa-lg pointer ${
            valorSeleccionado >= indice + 1 ? "checked" : null
          }`}
          onMouseOver={() => {
            manejarMouseOver(indice + 1);
          }}
          style={{ backgroundColor: "transparent" }}
          onClick={() => manejarClick(indice + 1)}
        />
      ))}
    </>
  );
}

interface RatingProps {
  maximoValor: number;
  valorSeleccionado: number;
  onChange(voto: number): void;
}
