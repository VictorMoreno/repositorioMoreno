import { Link } from "react-router-dom";

export default function FormularioSinPermiso() {
  return (
    <div className="d-flex align-items-center justify-content-center vh-100 bg-light">
      <div className="text-center">
        <div className="alert alert-warning" role="alert">
          <h4 className="alert-heading">Acceso restringido</h4>
          <p>
            No tiene permiso para acceder a este componente o su sesión ha
            caducado.
          </p>
          <hr />
          <p className="mb-0">
            Por favor, inicie sesión nuevamente o contacte al administrador si
            cree que esto es un error.
          </p>
        </div>
        <Link to="/login" className="btn btn-primary me-2">
          Iniciar sesión
        </Link>
        <Link to="/" className="btn btn-secondary">
          Volver al inicio
        </Link>
      </div>
    </div>
  );
}
