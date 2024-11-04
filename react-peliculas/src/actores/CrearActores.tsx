import axios from 'axios'
import { useState } from 'react';
import { actorCreacionDTO } from './actores.model'
import FormularioActores from './FormularioActores'
import { urlActores } from '../utilidades/endpoints';
import { useNavigate } from 'react-router-dom';
import MostrarErrores from '../utilidades/MostrarErrores';
import { convertirActorAFormData } from '../utilidades/FormDataUtils';
export default function CrearActores() {

    const [errores, setErrores] = useState<string[]>([]);
    const navigate = useNavigate();

    async function crear(actor: actorCreacionDTO){
        try{
            const formData = convertirActorAFormData(actor);
            await axios({
                method: 'post',
                url: urlActores,
                data: formData,
                headers: {'Content-Type': 'multipart/form-data'}
            });
            navigate("/actores");
        }
        catch(error){
            setErrores(error.response.data);
        }
    }

    return (
        <>
            <h3>Crear Actores</h3>
            <MostrarErrores errores={errores} />
            <FormularioActores
                modelo={{nombre: '', fechaNacimiento: undefined}}
                onSubmit={async valores => await crear(valores)}
            />
        </>

    )
}
