const FormularioError = () => {
  return (
    <div className="d-flex justify-content-center align-items-center vh-100 bg-light">
      <div className="text-center p-4 bg-white shadow rounded">
        <h1 className="text-danger">¡Ha ocurrido un error!</h1>
        <p>Se produjo un error no controlado. Por favor, intenta nuevamente más tarde.</p>
        <button
          className="btn btn-primary"
          onClick={() => window.location.reload()}
        >
          Recargar página
        </button>
      </div>
    </div>
  );
};

export default FormularioError;
