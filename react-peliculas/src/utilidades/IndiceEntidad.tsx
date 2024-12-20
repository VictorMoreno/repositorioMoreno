import axios, { AxiosResponse } from "axios";
import { ReactElement, useEffect, useState } from "react";
import { Link } from "react-router-dom";
import Paginacion from "./Paginacion";
import ListadoGenerico from "./ListadoGenerico";
import Boton from "./Boton";
import Confirmar from "./Confirmar";

export default function IndiceEntidad<T>(props: IndiceEntidadProps<T>) {
  const [entidades, setEntidades] = useState<T[]>();
  const [totalPaginas, setTotalPaginas] = useState(0);
  const [cantidadRegistrosPagina, setCantidadRegistrosPagina] = useState(10);
  const [pagina, setPagina] = useState(1);

  useEffect(() => {
    cargarDatos();
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [pagina, cantidadRegistrosPagina]);

  async function cargarDatos() {
    try {
      const respuesta = await axios.get<T[]>(props.url, {
        params: {
          Pagina: pagina,
          RegistrosPorPagina: cantidadRegistrosPagina,
        },
      });

      const totalRegistros = parseInt(
        respuesta.headers["cantidadtotalregistros"],
        10
      );

      setTotalPaginas(Math.ceil(totalRegistros / cantidadRegistrosPagina));
      setEntidades(respuesta.data);
    } catch (error) {
      console.error("Error al cargar datos:", error);
      // Puedes agregar más manejo de errores aquí
    }
  }

  async function borrar(id: number) {
    try {
      await axios.delete(`${props.url}/${id}`);
      setPagina(1);
      cargarDatos();
    } catch (error) {
      console.log(error.respuse.data);
    }
  }

  const botones = (urlEditar: string, id: number) => (
    <>
      <Link className="btn btn-success" to={urlEditar}>
        Editar
      </Link>
      <Boton
        className="btn btn-danger"
        onClick={() => Confirmar(() => borrar(id))}
        type={"submit"}
        disable={false}
        style={null}
      >
        Borrar
      </Boton>
    </>
  );

  return (
    <>
      <h3>{props.titulo}</h3>
      {props.urlCrear ? (
        <Link className="btn btn-primary mb-3" to={props.urlCrear}>
          Crear {props.nombreEntidad}
        </Link>
      ) : null}

      <ListadoGenerico listado={entidades}>
        <table className="table table-striped">
          {props.children(entidades!, botones)}
        </table>
      </ListadoGenerico>

      <Paginacion
        radio={3}
        cantidadTotalPaginas={totalPaginas}
        paginaActual={pagina}
        onChange={(nuevaPagina) => {
          setPagina(nuevaPagina);
        }}
      />

      <div className="form-group" style={{ width: "150px" }}>
        <label>Registros por página</label>
        <select
          className="form-control"
          defaultValue={10}
          onChange={(e) => {
            setPagina(1);
            setCantidadRegistrosPagina(parseInt(e.currentTarget.value, 10));
          }}
        >
          <option value={5}>5</option>
          <option value={10}>10</option>
          <option value={25}>25</option>
          <option value={50}>50</option>
        </select>
      </div>
    </>
  );
}

interface IndiceEntidadProps<T> {
  url: string;
  urlCrear?: string;
  children(
    entidades: T[],
    botones: (urlEditar: string, id: number) => ReactElement
  ): ReactElement;
  titulo: string;
  nombreEntidad?: string;
}
