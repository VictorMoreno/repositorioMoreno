import { ErrorMessage, Field } from "formik";
import MostrarErrorCampo from "./MostrarErrorCampo";

export default function GrupoTextoFormulario(props: GrupoTextoFormularioProps) {
  return (
    <div className="mb-3">
      {props.label ? <label className="form-label" htmlFor={props.campo}>{props.label}</label> : null}
      <Field
        type={props.type}
        name={props.campo}
        className="form-control"
        placeholder={props.placeholder}
      />
      <ErrorMessage name={props.campo}>
        {(mensaje) => <MostrarErrorCampo mensaje={mensaje}></MostrarErrorCampo>}
      </ErrorMessage>
    </div>
  );
}

interface GrupoTextoFormularioProps {
  campo: string;
  label?: string;
  placeholder?: string;
  type: "text" | "password";
}
