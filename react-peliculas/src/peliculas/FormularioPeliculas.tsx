import { Form, Formik, FormikHelpers } from "formik";
import { peliculaCreacionDto } from "./Peliculas.model";
import * as Yup from "yup";
import GrupoTextoFormulario from "../utilidades/GrupoTextoFormulario";
import FormularioGrupoCheckbox from "../utilidades/FormularioGrupoCheckbox";
import FormularioGrupoFecha from "../utilidades/FormularioGrupoFecha";
import FormularioGrupoImagen from "../utilidades/FormularioGrupoImagen";
import Boton from "../utilidades/Boton";
import { Link } from "react-router-dom";
import SelectorMultiple, {
  selectorMultipleModel,
} from "../utilidades/SelectorMultiple";
import { generoDto } from "../generos/generos.model";
import { useState } from "react";
import { cineDTO } from "../cines/cines.model";
import TypeAheadActores from "../actores/TypeAheadActores";
import { actorPeliculaDto } from "../actores/actores.model";
import FormularioGrupoMarkdown from "../utilidades/FormularioGrupoMarkdown";

export default function FormularioPeliculas(props: FormularioPeliculasProps) {
  const [generosSeleccionados, setGenerosSeleccionados] = useState(
    mapear(props.generosSeleccionados)
  );
  const [generosNoSeleccionados, setGenerosNoSeleccionados] = useState(
    mapear(props.generosNoSeleccionados)
  );
  const [cinesSeleccionados, setCinesSeleccionados] = useState(
    mapear(props.cinesSeleccionados)
  );
  const [cinesNoSeleccionados, setCinesNoSeleccionados] = useState(
    mapear(props.cinesNoSeleccionados)
  );
  const [actoresSeleccionados, setActoresSeleccionados] = useState<
    actorPeliculaDto[]
  >(props.actoresSeleccionados);

  function mapear(
    arreglo: { id: number; nombre: string }[]
  ): selectorMultipleModel[] {
    return arreglo.map((valor) => {
      return { llave: valor.id, valor: valor.nombre };
    });
  }

  return (
    <Formik
      initialValues={props.modelo}
      onSubmit={(valores, acciones) => {
        valores.generosIds = generosSeleccionados.map((valor) => valor.llave);
        valores.cinesIds = cinesSeleccionados.map((valor) => valor.llave);
        valores.actores = actoresSeleccionados;

        props.onSubmit(valores, acciones);
      }}
      validationSchema={Yup.object({
        titulo: Yup.string()
          .required("Este campo es requerido")
          .primeraLetraMayuscula(),
      })}
    >
      {(formikProps) => (
        <Form>
          <GrupoTextoFormulario label="Título" campo="titulo" type={"text"} />
          <FormularioGrupoCheckbox label="En cines" campo="enCines" />
          <GrupoTextoFormulario label="Trailer" campo="trailer" type={"text"} />
          <FormularioGrupoFecha
            campo="fechaLanzamiento"
            label="Fecha Lanzamiento"
          />
          <FormularioGrupoImagen
            campo="poster"
            label="Poster"
            imagenURL={props.modelo.posterURL ? props.modelo.posterURL : ""}
          />
          <FormularioGrupoMarkdown campo="resumen" label="Resumen" />

          <div className="mb-3">
            <label className="form-label">Géneros:</label>
            <SelectorMultiple
              seleccionados={generosSeleccionados}
              noSeleccionados={generosNoSeleccionados}
              onChange={(seleccionados, noSeleccionados) => {
                setGenerosNoSeleccionados(noSeleccionados);
                setGenerosSeleccionados(seleccionados);
              }}
            />
          </div>

          <div className="mb-3">
            <label className="form-label">Cines:</label>
            <SelectorMultiple
              seleccionados={cinesSeleccionados}
              noSeleccionados={cinesNoSeleccionados}
              onChange={(seleccionados, noSeleccionados) => {
                setCinesNoSeleccionados(noSeleccionados);
                setCinesSeleccionados(seleccionados);
              }}
            />
          </div>

          <div className="form-group" style={{ marginBottom: "1rem" }}>
            <TypeAheadActores
              onAdd={(actores) => {
                setActoresSeleccionados(actores);
              }}
              onRemove={(actor) => {
                const actores = actoresSeleccionados.filter((x) => x !== actor);
                setActoresSeleccionados(actores);
              }}
              actores={actoresSeleccionados}
              listadoUI={(actor: actorPeliculaDto) => (
                <>
                  {actor.nombre} /{" "}
                  <input
                    placeholder="Personaje"
                    type="text"
                    value={actor.personaje}
                    onChange={(e) => {
                      const indice = actoresSeleccionados.findIndex(
                        (x) => x.id === actor.id
                      );

                      const actores = [...actoresSeleccionados];
                      actores[indice].personaje = e.currentTarget.value;
                      setActoresSeleccionados(actores);
                    }}
                  />
                </>
              )}
            />
          </div>

          <Boton
            disable={formikProps.isSubmitting}
            type="submit"
            className={"btn btn-primary"}
            style={null}
          >
            Enviar
          </Boton>
          <Link className="btn btn-danger" to="/">
            Cancelar
          </Link>
        </Form>
      )}
    </Formik>
  );
}

interface FormularioPeliculasProps {
  modelo: peliculaCreacionDto;
  onSubmit(
    valores: peliculaCreacionDto,
    acciones: FormikHelpers<peliculaCreacionDto>
  ): void;
  generosSeleccionados: generoDto[];
  generosNoSeleccionados: generoDto[];
  cinesSeleccionados: cineDTO[];
  cinesNoSeleccionados: cineDTO[];
  actoresSeleccionados: actorPeliculaDto[];
}
