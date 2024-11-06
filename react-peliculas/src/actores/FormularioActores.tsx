import { Form, Formik, FormikHelpers } from "formik";
import { actorCreacionDTO } from "./actores.model.d";
import GrupoTextoFormulario from "../utilidades/GrupoTextoFormulario";
import Boton from "../utilidades/Boton";
import { Link } from "react-router-dom";
import * as Yup from "yup";
import FormularioGrupoFecha from "../utilidades/FormularioGrupoFecha";
import FormularioGrupoImagen from "../utilidades/FormularioGrupoImagen";
import FormularioGrupoMarkdown from "../utilidades/FormularioGrupoMarkdown";

export default function FormularioActores(props: FormularioActoresProps) {
  return (
    <Formik
      initialValues={props.modelo}
      onSubmit={props.onSubmit}
      validationSchema={Yup.object({
        nombre: Yup.string()
          .required("Este campo es requerido")
          .primeraLetraMayuscula(),
        fechaNacimiento: Yup.date()
          .nullable()
          .required("Este campo es requerido"),
      })}
    >
      {(formikProps) => (
        <Form>
          <GrupoTextoFormulario campo="nombre" label="Nombre" type={"text"} />

          <FormularioGrupoFecha
            campo="fechaNacimiento"
            label="Fecha Nacimiento"
          />

          <FormularioGrupoImagen
            campo="foto"
            label="Foto"
            imagenURL={props.modelo.fotoURL ? props.modelo.fotoURL : ""}
          />

          <FormularioGrupoMarkdown campo="biografia" label="Biografia" />

          <Boton
            disable={formikProps.isSubmitting}
            type="submit"
            className={"btn btn-primary"}
            style={null}
          >
            Salvar
          </Boton>
          <Link className="btn btn-secondary" to="/actores">
            Cancelar
          </Link>
        </Form>
      )}
    </Formik>
  );
}

interface FormularioActoresProps {
  modelo: actorCreacionDTO;
  onSubmit(
    valores: actorCreacionDTO,
    acciones: FormikHelpers<actorCreacionDTO>
  ): void;
}
