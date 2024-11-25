import Menu from "./utilidades/Menu";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import rutas from "./route-config";
import configurarValidaciones from "./validaciones";
import { useEffect, useState } from "react";
import { claim } from "./auth/auth.model";
import AutenticacionContext from "./auth/AutenticacionContext";
import { obtenerClaims } from "./auth/manejadorJwt";
import { configurarInterceptor } from "./utilidades/interceptores";
import React from "react";
import ErrorBoundary from "./ErrorBoundary";

configurarValidaciones();
configurarInterceptor();

function App() {
  React.useEffect(() => {
    document.body.style.backgroundColor = "#f5f5f5";
  }, []);

  const [claims, setClaims] = useState<claim[]>([]);
  useEffect(() => {
    setClaims(obtenerClaims());
  }, []);

  function actualizar(claims: claim[]) {
    setClaims(claims);
  }

  function esAdmin() {
    return (
      claims.findIndex(
        (claim) => claim.nombre === "role" && claim.valor === "admin"
      ) > -1
    );
  }

  return (
    <>
      <BrowserRouter>
        <AutenticacionContext.Provider value={{ claims, actualizar }}>
          <Menu />
          <div className="container">
              <Routes>
                {rutas.map((ruta) => (
                  <Route
                    key={ruta.path}
                    path={ruta.path}
                    element={
                      ruta.esAdmin && !esAdmin() ? (
                        <>No tiene permiso para acceder a este componente</>
                      ) : (
                        <ruta.componente />
                      )
                    }
                  />
                ))}
              </Routes>
          </div>
        </AutenticacionContext.Provider>
      </BrowserRouter>
    </>
  );
}

export default App;
