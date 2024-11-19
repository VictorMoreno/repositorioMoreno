import { ReactElement, useState } from "react";
import { AsyncTypeahead } from "react-bootstrap-typeahead";
import { actorPeliculaDto } from "./actores.model";
import axios, { AxiosResponse } from "axios";
import { urlActores } from "../utilidades/endpoints";

export default function TypeAheadActores(props: typeAheadActoresProps) {
  const [estaCargando, setEstaCargado] = useState(false);
  const seleccion: actorPeliculaDto[] = [];
  const [opciones, setOpciones] = useState<actorPeliculaDto[]>([]);

  const [elementoArrastrado, setElementoArrastrado] = useState<
    actorPeliculaDto | undefined
  >(undefined);

  function manejarBusqueda(query: string) {
    setEstaCargado(true);

    axios
      .get(`${urlActores}/buscarPorNombre/${query}`)
      .then((respuesta: AxiosResponse<actorPeliculaDto[]>) => {
        setOpciones(respuesta.data);
        setEstaCargado(false);
      });
  }

  function manejarDragStart(actor: actorPeliculaDto) {
    setElementoArrastrado(actor);
  }

  function manejarDragOver(actor: actorPeliculaDto) {
    if (!elementoArrastrado) {
      return;
    }

    if (actor.id !== elementoArrastrado.id) {
      const elementoArrastradoIndice = props.actores.findIndex(
        (x) => x.id === elementoArrastrado.id
      );
      const actorIndice = props.actores.findIndex((x) => x.id === actor.id);

      const actores = [...props.actores];
      actores[actorIndice] = elementoArrastrado;
      actores[elementoArrastradoIndice] = actor;
      props.onAdd(actores);
    }
  }

  return (
    <>
      <label className="form-label">Actores:</label>
      <AsyncTypeahead
        id="typeahead"
        options={opciones}
        onChange={(actores) => {
          const actor = actores[0] as actorPeliculaDto;
          if (props.actores.findIndex((x) => x.id === actor.id) === -1) {
            props.onAdd([...props.actores, actor]);
          }
        }}
        labelKey={(actor) => (actor as actorPeliculaDto).nombre}
        filterBy={() => true}
        isLoading={estaCargando}
        onSearch={manejarBusqueda}
        placeholder="Escriba el nombre del actor..."
        minLength={2}
        flip={true}
        selected={seleccion}
        renderMenuItemChildren={(actor) => (
          <>
            <img
              alt="actor"
              src={(actor as actorPeliculaDto).foto}
              style={{
                height: "40px",
                width: "40px",
                marginRight: "10px",
                borderRadius: "50%",
              }}
            />
            <span>{(actor as actorPeliculaDto).nombre}</span>
          </>
        )}
      />

      <ul className="list-group">
        {props.actores.map((actor) => (
          <li
            draggable={true}
            onDragStart={() => manejarDragStart(actor)}
            onDragOver={() => manejarDragOver(actor)}
            className="list-group-item list-group-item-action"
            key={actor.id}
          >
            {props.listadoUI(actor)}
            <span
              className="badge badge-primary badge-pill pointer"
              style={{ marginLeft: "0.5rem" }}
              onClick={() => props.onRemove(actor)}
            >
              X
            </span>
          </li>
        ))}
      </ul>
    </>
  );
}

interface typeAheadActoresProps {
  actores: actorPeliculaDto[];
  onAdd(actores: actorPeliculaDto[]): void;
  listadoUI(actor: actorPeliculaDto): ReactElement;
  onRemove(actor: actorPeliculaDto): void;
}
