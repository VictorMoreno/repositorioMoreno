import CrearActores from "./actores/CrearActores";
import EditarActores from "./actores/EditarActores";
import IndiceActores from "./actores/IndiceActores";
import EditarUsuario from "./auth/EditarUsuario";
import FormularioRestablecerCredencial from "./auth/FormularioRestablecerCredencial";
import FormularioSolicitudRestablecerCredencial from "./auth/FormularioSolicitudRestablecerCredencial";
import IndiceUsuarios from "./auth/IndiceUsuarios";
import Login from "./auth/Login";
import Registro from "./auth/Registro";
import CrearCines from "./cines/CrearCines";
import EditarCines from "./cines/EditarCines";
import IndiceCines from "./cines/IndiceCines";
import CrearGeneros from "./generos/CrearGeneros";
import EditarGeneros from "./generos/EditarGeneros";
import IndiceGeneros from "./generos/IndiceGeneros";
import PaginaPrincipal from "./PaginaPrincipal";
import CrearPeliculas from "./peliculas/CrearPeliculas";
import DetallePelicula from "./peliculas/DetallePelicula";
import EditarPeliculas from "./peliculas/EditarPeliculas";
import FiltroPeliculas from "./peliculas/FiltroPeliculas";
import FormularioError from "./utilidades/FormularioError";
import FormularioSinPermiso from "./utilidades/FormularioSinPermiso";
import RedireccionarPaginaPrincipal from "./utilidades/RedireccionPaginaPrincipal";

const rutas = [
  { path: "/generos/crear", componente: CrearGeneros, esAdmin: true },
  { path: "/generos/editar/:id", componente: EditarGeneros, esAdmin: true },
  { path: "/generos", componente: IndiceGeneros, esAdmin: true },

  { path: "/actores/crear", componente: CrearActores, esAdmin: true },
  { path: "/actores/editar/:id", componente: EditarActores, esAdmin: true },
  { path: "/actores", componente: IndiceActores, esAdmin: true },

  { path: "/cines/crear", componente: CrearCines, esAdmin: true },
  { path: "/cines/editar/:id", componente: EditarCines, esAdmin: true },
  { path: "/cines", componente: IndiceCines, esAdmin: true },

  { path: "/pelicula/:id", componente: DetallePelicula },
  { path: "/peliculas/crear", componente: CrearPeliculas, esAdmin: true },
  { path: "/peliculas/editar/:id", componente: EditarPeliculas, esAdmin: true },
  { path: "/peliculas/filtrar", componente: FiltroPeliculas },

  { path: "/registro", componente: Registro },
  { path: "/login", componente: Login },
  { path: "/usuarios", componente: IndiceUsuarios, esAdmin: true },
  { path: "/usuarios/solicitudRestablecimiento", componente: FormularioSolicitudRestablecerCredencial },
  { path: "/usuarios/restablecer", componente: FormularioRestablecerCredencial },
  { path: "/usuarios/editar/:id", componente: EditarUsuario , esAdmin: true},

  { path: "/sesion", componente: FormularioSinPermiso},
  { path: "/error", componente: FormularioError},

  { path: "/", componente: PaginaPrincipal },

  { path: "*", componente: RedireccionarPaginaPrincipal },
];

export default rutas;
