import { NavLink, useNavigate } from "react-router-dom";
import Autorizado from "../auth/Autorizado";
import { Link } from "react-router-dom";
import Boton from "./Boton";
import { logout } from "../auth/manejadorJwt";
import { useContext } from "react";
import AutenticacionContext from "../auth/AutenticacionContext";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
  faRightFromBracket,
  faSignInAlt,
  faUserPlus,
} from "@fortawesome/free-solid-svg-icons";

export default function Menu() {
  const { actualizar, claims } = useContext(AutenticacionContext);
  const navigate = useNavigate();

  function obtenerNombreUsuario(): string {
    return claims.filter((x) => x.nombre === "email")[0]?.valor;
  }

  return (
    <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
      <div className="container-fluid">
        <Link to="/">
          <img src="../logo192.png" width="50" alt="Inicio" />
        </Link>
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
                Buscar Películas
              </NavLink>
            </li>

            <Autorizado
              role="admin"
              autorizado={
                <>
                  <li className="nav-item">
                    <NavLink
                      className={({ isActive }) =>
                        isActive ? "nav-link active" : "nav-link"
                      }
                      to="/actores"
                    >
                      Actores
                    </NavLink>
                  </li>

                  <li className="nav-item">
                    <NavLink
                      className={({ isActive }) =>
                        isActive ? "nav-link active" : "nav-link"
                      }
                      to="/cines"
                    >
                      Cines
                    </NavLink>
                  </li>

                  <li className="nav-item">
                    <NavLink
                      className={({ isActive }) =>
                        isActive ? "nav-link active" : "nav-link"
                      }
                      to="/peliculas/crear"
                    >
                      Crear Películas
                    </NavLink>
                  </li>

                  <li className="nav-item">
                    <NavLink
                      className={({ isActive }) =>
                        isActive ? "nav-link active" : "nav-link"
                      }
                      to="/generos"
                    >
                      Géneros
                    </NavLink>
                  </li>

                  <li className="nav-item">
                    <NavLink
                      className={({ isActive }) =>
                        isActive ? "nav-link active" : "nav-link"
                      }
                      to="/usuarios"
                    >
                      Usuarios
                    </NavLink>
                  </li>
                </>
              }
            />
          </ul>

          <div className="d-flex">
            <Autorizado
              autorizado={
                <div className="d-flex align-items-center">
                  <span className="nav-link text-light">
                    Hola, {obtenerNombreUsuario()}
                  </span>
                  <Boton
                    type="button"
                    onClick={() => {
                      logout();
                      actualizar([]);
                      navigate('/');
                    }}
                    className="btn btn-link"
                    disable={false}
                    style={null}
                  >
                    <FontAwesomeIcon
                      icon={faRightFromBracket}
                      title="Log out"
                      className="fa-lg"
                    />
                  </Boton>
                </div>
              }
              noAutorizado={
                <>
                  <Link to="/registro" className="btn btn-link">
                    <FontAwesomeIcon icon={faUserPlus} title="Registro" className="fa-lg"/>
                  </Link>
                  <Link to="/login" className="btn btn-link">
                    <FontAwesomeIcon icon={faSignInAlt} title="Login" className="fa-lg"/>
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
