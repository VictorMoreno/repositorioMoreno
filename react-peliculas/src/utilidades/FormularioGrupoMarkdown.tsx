import { Field, useFormikContext } from "formik";
import ReactMarkdown from "react-markdown";
import "./FormularioGrupoMarkdown.css";

export default function FormularioGrupoMarkdown(
  props: FormularioGrupoMarkdownProps
) {
  const { values } = useFormikContext<any>();

  return (
    <div className="form-group form-markdown">
      <div>
        <label className="form-label">{props.label}</label>
        <div>
          <Field name={props.campo} as="textarea" className="form-textarea" />
        </div>
      </div>
      <div>
        <label className="form-label">{props.label} (preview)</label>
        <div className="markdown-container">
          <ReactMarkdown>{values[props.campo]}</ReactMarkdown>
        </div>
      </div>
    </div>
  );
}

interface FormularioGrupoMarkdownProps {
  campo: string;
  label: string;
}
