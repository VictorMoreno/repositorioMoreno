import { NavLink } from "react-router-dom";
import Autorizado from "../auth/Autorizado";
import { Link } from "react-router-dom";
import Boton from "./Boton";
import { logout } from "../auth/manejadorJwt";
import { useContext } from "react";
import AutenticacionContext from "../auth/AutenticacionContext";

export default function Menu() {
  const { actualizar, claims } = useContext(AutenticacionContext);

  function obtenerNombreUsuario(): string {
    return claims.filter((x) => x.nombre === "email")[0]?.valor;
  }

  return (
    <nav className="navbar navbar-expand-lg navbar-light bg-light">
      <div className="container-fluid">
        <NavLink
          // className={({ isActive }) => (isActive ? "active" : "navbar-brand")}
          className="navbar-brand"
          to="/"
        >
          React Películas
        </NavLink>
        <div
          className="collapse navbar-collapse"
          style={{ display: "flex", justifyContent: "space-between" }}
        >
          <ul className="navbar-nav me-auto mb-2 mb-lg-0">
            <li className="nav-item">
              <NavLink
                className={({ isActive }) =>
                  isActive ? "nav-link active" : "nav-link"
                }
                to="/peliculas/filtrar"
              >
                {" "}
                Filtrar Películas{" "}
              </NavLink>
            </li>

            <Autorizado
              rol="admin"
              autorizado={
                <>
                  <li className="nav-item">
                    <NavLink
                      className={({ isActive }) =>
                        isActive ? "nav-link active" : "nav-link"
                      }
                      to="/generos"
                    >
                      {" "}
                      Géneros{" "}
                    </NavLink>
                  </li>

                  <li className="nav-item">
                    <NavLink
                      className={({ isActive }) =>
                        isActive ? "nav-link active" : "nav-link"
                      }
                      to="/actores"
                    >
                      {" "}
                      Actores{" "}
                    </NavLink>
                  </li>

                  <li className="nav-item">
                    <NavLink
                      className={({ isActive }) =>
                        isActive ? "nav-link active" : "nav-link"
                      }
                      to="/cines"
                    >
                      {" "}
                      Cines{" "}
                    </NavLink>
                  </li>

                  <li className="nav-item">
                    <NavLink
                      className={({ isActive }) =>
                        isActive ? "nav-link active" : "nav-link"
                      }
                      to="/peliculas/crear"
                    >
                      {" "}
                      Crear Películas{" "}
                    </NavLink>
                  </li>
                </>
              }
            />
          </ul>

          <div className="d-flex">
            <Autorizado
              autorizado={
                <>
                  <span className="nav-link">Hola, {obtenerNombreUsuario()}</span>
                  <Boton
                    onClick={() => {
                      logout();
                      actualizar([]);
                    }}
                    className="btn btn-link"
                  >
                    Log out
                  </Boton>
                </>
              }
              noAutorizado={
                <>
                  <Link to="/registro" className="btn btn-link">
                    Registro
                  </Link>
                  <Link to="/login" className="btn btn-link">
                    Login
                  </Link>
                </>
              }
            />
          </div>
        </div>
      </div>
    </nav>
  );
}
