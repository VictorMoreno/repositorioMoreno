import axios from "axios";
import Boton from "../utilidades/Boton";
import { urlCuentas } from "../utilidades/endpoints";
import IndiceEntidad from "../utilidades/IndiceEntidad";
import { usuarioDto } from "./auth.model";
import Swal from "sweetalert2";
import confirmar from "../utilidades/Confirmar";
import { Link, useNavigate } from "react-router-dom";

export default function IndiceUsuarios() {
  const navigate = useNavigate();

  async function hacerAdmin(id: string) {
    await realizarPeticion(`${urlCuentas}/hacerAdmin`, id);
  }

  async function quitarAdmin(id: string) {
    await realizarPeticion(`${urlCuentas}/quitarAdmin`, id);
  }

  async function eliminarCuenta(id: string) {
    await axios.delete(`${urlCuentas}/${id}`);

    Swal.fire({
      title: "Éxito",
      text: "Operación realizada con éxito.",
      icon: "success",
    });

    navigate("/usuarios");
  }

  async function realizarPeticion(url: string, id: string) {
    await axios.post(url, JSON.stringify(id), {
      headers: { "Content-Type": "application/json" },
    });

    Swal.fire({
      title: "Éxito",
      text: "Operación realizada con éxito.",
      icon: "success",
    });
  }

  return (
    <IndiceEntidad<usuarioDto>
      url={`${urlCuentas}/listadoUsuarios`}
      titulo="Usuarios"
    >
      {(usuarios) => (
        <>
          <thead>
            <tr>
              <th></th>
              <th>Nombre</th>
            </tr>
          </thead>
          <tbody>
            {usuarios?.map((usuario) => (
              <tr key={usuario.id}>
                <td>
                  <Link
                    className="btn btn-success"
                    to={`editar/${usuario.id}`}
                  >
                    Editar
                  </Link>                  
                  <Boton
                    className="btn btn-danger"
                    style={null}
                    onClick={() =>
                      confirmar(
                        () => eliminarCuenta(usuario.id),
                        `¿Desea eliminar al usuario ${usuario.email}?`,
                        "Realizar"
                      )
                    }
                    type={"submit"}
                    disable={false}
                  >
                    Borrar
                  </Boton>
                  <Boton
                    onClick={() =>
                      confirmar(
                        () => hacerAdmin(usuario.id),
                        `¿Desea hacer a ${usuario.email} admin?`,
                        "Realizar"
                      )
                    }
                    type={"submit"}
                    disable={false}
                    className={"btn btn-primary"}
                    style={{ marginLeft: "1rem" }}
                  >
                    Hacer Admin
                  </Boton>
                  <Boton
                    className="btn btn-warning"
                    style={{ marginLeft: "1rem" }}
                    onClick={() =>
                      confirmar(
                        () => quitarAdmin(usuario.id),
                        `¿Desea quitar a ${usuario.email} como admin?`,
                        "Realizar"
                      )
                    }
                    type={"submit"}
                    disable={false}
                  >
                    Quitar Admin
                  </Boton>
                </td>
                <td>{usuario.email}</td>
              </tr>
            ))}
          </tbody>
        </>
      )}
    </IndiceEntidad>
  );
}
