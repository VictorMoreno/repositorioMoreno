export default function MostrarErrorCampo(props: mostrarErrorCamposProps) {
  return <div className="text-danger">{props.mensaje}</div>;
}

interface mostrarErrorCamposProps {
  mensaje: string;
}
