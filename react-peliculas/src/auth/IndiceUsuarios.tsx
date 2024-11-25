import axios from "axios";
import Boton from "../utilidades/Boton";
import { urlCuentas } from "../utilidades/endpoints";
import IndiceEntidad from "../utilidades/IndiceEntidad";
import { usuarioDto } from "./auth.model";
import Swal from "sweetalert2";
import confirmar from "../utilidades/Confirmar";

export default function IndiceUsuarios() {

  async function hacerAdmin(id: string) {
    await editarAdmin(`${urlCuentas}/hacerAdmin`, id);
  }

  async function quitarAdmin(id: string) {
    await editarAdmin(`${urlCuentas}/quitarAdmin`, id);
  }

  async function eliminarCuenta(id: string) {
    await axios.delete(`${urlCuentas}/${id}`);

    Swal.fire({
      title: "Éxito",
      text: "Operación realizada con éxito.",
      icon: "success",
    });
  }

  async function editarAdmin(url: string, id: string) {
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
                    className={"btn btn-success"}
                    style={null}
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
                  <Boton
                    className="btn btn-danger"
                    style={{ marginLeft: "1rem" }}
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
                    Eliminar
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
