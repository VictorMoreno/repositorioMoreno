import { ReactElement, useContext, useEffect, useState } from "react";
import AutenticacionContext from "./AutenticacionContext";

export default function Autorizado(props: AutorizadoProps) {
  const [estaAutorizado, setEstaAutorizado] = useState(false);
  const { claims } = useContext(AutenticacionContext);

  useEffect(() => {
    if (props.rol) {
      const indice = claims.findIndex(
        (claim) => claim.nombre === "rol" && claim.valor === props.rol
      );
      setEstaAutorizado(indice > -1);
    } else {
      setEstaAutorizado(claims.length > 0);
    }
  }, [claims, props.rol]);

  return <>{estaAutorizado ? props.autorizado : props.noAutorizado}</>;
}

interface AutorizadoProps {
  autorizado: ReactElement;
  noAutorizado?: ReactElement;
  rol?: string;
}
