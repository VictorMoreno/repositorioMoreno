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

  const [volorFiltro, setValorFiltro] = useState<filtroPeliculasForm>({
    titulo: "",
    generoId: 0,
    proximosEstrenos: false,
    enCines: false,
    pagina: 1,
    registrosPorPagina: 10,
  });

  const [inicializado, setInicializado] = useState(false); // Nuevo estado
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
    if (!inicializado) {
      const nuevosValores: filtroPeliculasForm = {
        titulo: query.get("titulo") || "",
        generoId: query.get("generoId") ? parseInt(query.get("generoId")!, 10) : 0,
        proximosEstrenos: query.get("proximosEstrenos") === "true",
        enCines: query.get("enCines") === "true",
        pagina: query.get("pagina") ? parseInt(query.get("pagina")!, 10) : 1,
        registrosPorPagina: 10,
      };

      setValorFiltro(nuevosValores);
      buscarPeliculas(nuevosValores);
      setInicializado(true);
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [query]);

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
          Math.ceil(totalRegistros / volorFiltro.registrosPorPagina)
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
      <h3>Buscador de películas</h3>

      <Formik
        initialValues={volorFiltro}
        enableReinitialize
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
                    className="form-check-label ms-2"
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
                  <label className="form-check-label ms-2" htmlFor="enCines">
                    En Cines
                  </label>
                </div>
                <Boton
                  type={"button"}
                  disable={false}
                  style={null}
                  className="btn btn-primary mb-2 mx-sm-3"
                  onClick={() => formikProps.submitForm()}
                >
                  Filtrar
                </Boton>
                <Boton
                  type={"button"}
                  disable={false}
                  style={null}
                  className="btn btn-secondary mb-2"
                  onClick={() => {
                    formikProps.setValues(valorInicial);
                    buscarPeliculas(valorInicial);
                  }}
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
                formikProps.setFieldValue("pagina", nuevaPagina);
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
