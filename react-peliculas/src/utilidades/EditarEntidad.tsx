import axios, { AxiosResponse } from "axios";
import React, { useState, useEffect, ReactElement } from "react";
import { useNavigate, useParams } from "react-router-dom";
import Cargando from "./Cargando";
import MostrarErrores from "./MostrarErrores";

export default function EditarEntidad<TCreacion, TLectura>
    (props: editarEntidadProps<TCreacion, TLectura>) {

    const { id }: any = useParams();
    const [entidad, setEntidad] = useState<TCreacion>();
    const [errores, setErrores] = useState<string[]>([]);
    const navigate = useNavigate();

    useEffect(() => {
        axios.get(`${props.url}/${id}`)
            .then((respuesta: AxiosResponse<TLectura>) => {
                setEntidad(props.transformar(respuesta.data));
            })
        // eslint-disable-next-line react-hooks/exhaustive-deps
    }, [])

    async function editar(entidadEditar: TCreacion) {
        try {
            if (props.transformarFormData) {
                const formData = props.transformarFormData(entidadEditar);
                await axios({
                    method: 'put',
                    url: `${props.url}/${id}`,
                    data: formData,
                    headers: { 'Content-Type': 'multipart/form-data' }
                });
            } else {
                await axios.put(`${props.url}/${id}`, entidadEditar);
            }
            navigate(props.urlIndice);
        }
        catch (error) {
            setErrores(error.response.data)
        }
    }

    return (
        <>
            <h3>Editar {props.nombreEntidad}</h3>
            <MostrarErrores errores={errores} />
            {entidad ? props.children(entidad, editar) : <Cargando />}
        </>

    )
}

interface editarEntidadProps<TCreacion, TLectura> {
    url: string;
    urlIndice: string;
    nombreEntidad: string;
    children(entidad: TCreacion, editar: (entidad: TCreacion) => void): ReactElement;
    transformar(entidad: TLectura): TCreacion;
    transformarFormData?(modelo: TCreacion): FormData
}