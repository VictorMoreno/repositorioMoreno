import { Field, Form, Formik } from "formik";
import { generoDto } from "../generos/generos.model";
import Boton from "../utilidades/Boton";
import { useEffect, useState } from "react";
import axios, { AxiosResponse } from "axios";
import { urlGeneros, urlPeliculas } from "../utilidades/endpoints";
import { peliculaDto } from "./Peliculas.model";
import PeliculaListado from "./PeliculaListado";
import { useLocation, useNavigate } from "react-router-dom";
import Paginacion from "../utilidades/Paginacion";

export default function FiltroPeliculas() {
  const valorInicial: filtroPeliculasForm = {
    titulo: "",
    generoId: 0,
    proximosEstrenos: false,
    enCines: false,
    pagina: 1,
    registrosPorPagina: 10,
  };

  const navigate = useNavigate();
  const [generos, setGeneros] = useState<generoDto[]>([]);
  const [peliculas, setPeliculas] = useState<peliculaDto[]>([]);
  const [totalPaginas, setTotalPaginas] = useState(0);
  const query = new URLSearchParams(useLocation().search);

  useEffect(() => {
    axios
      .get(`${urlGeneros}/todos`)
      .then((respuesta: AxiosResponse<generoDto[]>) => {
        setGeneros(respuesta.data);
      });
  }, []);

  useEffect(() => {
    if (query.get("titulo")) {
      valorInicial.titulo = query.get("titulo")!;
    }

    if (query.get("generoId")) {
      valorInicial.generoId = parseInt(query.get("generoId")!, 10);
    }

    if (query.get("proximosEstrenos")) {
      valorInicial.proximosEstrenos = true;
    }

    if (query.get("enCines")) {
      valorInicial.enCines = true;
    }

    if (query.get("pagina")) {
      valorInicial.pagina = parseInt(query.get("pagina")!, 10);
    }

    buscarPeliculas(valorInicial);
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  function buscarPeliculas(valores: filtroPeliculasForm) {
    modificarUrl(valores);
    axios
      .get(`${urlPeliculas}/filtrar`, { params: valores })
      .then((respuesta: AxiosResponse<peliculaDto[]>) => {
        const totalRegistros = parseInt(
          respuesta.headers["cantidadtotalregistros"],
          10
        );
        setTotalPaginas(
          Math.ceil(totalRegistros / valorInicial.registrosPorPagina)
        );
        setPeliculas(respuesta.data);
      });
  }

  function modificarUrl(valores: filtroPeliculasForm) {
    const queryStrings: string[] = [];

    if (valores.titulo) {
      queryStrings.push(`titulo=${valores.titulo}`);
    }

    if (valores.generoId) {
      queryStrings.push(`generoId=${valores.generoId}`);
    }

    if (valores.proximosEstrenos) {
      queryStrings.push(`proximosEstrenos=${valores.proximosEstrenos}`);
    }

    if (valores.enCines) {
      queryStrings.push(`enCines=${valores.enCines}`);
    }

    queryStrings.push(`pagina=${valores.pagina}`);
    navigate(`/peliculas/filtrar?${queryStrings.join("&")}`);
  }

  return (
    <>
      <h3>Filtrar Películas</h3>

      <Formik
        initialValues={valorInicial}
        onSubmit={(valores) => {
          valores.pagina = 1;
          buscarPeliculas(valores);
        }}
      >
        {(formikProps) => (
          <>
            <Form>
              <div className="form-inline">
                <div className="form-group mb-2">
                  <label htmlFor="titulo" className="sr-only">
                    Título
                  </label>
                  <input
                    type="text"
                    className="form-control"
                    id="titulo"
                    placeholder="Título de la película"
                    {...formikProps.getFieldProps("titulo")}
                  />
                </div>
                <div className="form-group mx-sm-3 mb-2">
                  <select
                    className="form-control"
                    {...formikProps.getFieldProps("generoId")}
                  >
                    <option value="0">--Seleccione un género--</option>
                    {generos.map((genero) => (
                      <option key={genero.id} value={genero.id}>
                        {genero.nombre}
                      </option>
                    ))}
                  </select>
                </div>
                <div className="form-group mx-sm-3 mb-2">
                  <Field
                    className="form-check-input"
                    id="proximosEstrenos"
                    name="proximosEstrenos"
                    type="checkbox"
                  />
                  <label
                    className="form-check-label"
                    htmlFor="proximosEstrenos"
                  >
                    Próximos Estrenos
                  </label>
                </div>
                <div className="form-group mx-sm-3 mb-2">
                  <Field
                    className="form-check-input"
                    id="enCines"
                    name="enCines"
                    type="checkbox"
                  />
                  <label className="form-check-label" htmlFor="enCines">
                    En Cines
                  </label>
                </div>
                <Boton
                  className="btn btn-primary mb-2 mx-sm-3"
                  onClick={() => formikProps.submitForm()}
                  type={"button"}
                  disable={false}
                  style={null}
                >
                  Filtrar
                </Boton>
                <Boton
                  className="btn btn-danger mb-2"
                  onClick={() => {
                    formikProps.setValues(valorInicial);
                    buscarPeliculas(valorInicial);
                  }}
                  type={"button"}
                  disable={false}
                  style={null}
                >
                  Limpiar
                </Boton>
              </div>
            </Form>

            <PeliculaListado peliculas={peliculas} />
            <Paginacion
              radio={3}
              cantidadTotalPaginas={totalPaginas}
              paginaActual={formikProps.values.pagina}
              onChange={(nuevaPagina) => {
                formikProps.values.pagina = nuevaPagina;
                buscarPeliculas(formikProps.values);
              }}
            />
          </>
        )}
      </Formik>
    </>
  );
}

interface filtroPeliculasForm {
  titulo: string;
  generoId: number;
  proximosEstrenos: boolean;
  enCines: boolean;
  pagina: number;
  registrosPorPagina: number;
}
