import { Field } from "formik";

export default function FormularioGrupoCheckbox(
  props: FormularioGrupoCheckboxProps
) {
  return (
    <div className="mb-3 form-check">
      <Field
        className="form-check-input"
        id={props.campo}
        name={props.campo}
        type="checkbox"
      />
      <label className="form-check-label" htmlFor={props.campo}>{props.label}</label>
    </div>
  );
}

interface FormularioGrupoCheckboxProps {
  label: string;
  campo: string;
}
