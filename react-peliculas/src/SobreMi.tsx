export default function SobreMi() {
  return (
    <div className="sobre-mi-container">
      <h1 className="titulo">Sobre Mí</h1>
      <div className="contenido">
        <section className="carta-presentacion">
          <h2>Carta de Presentación</h2>
          <p>Hola,</p>
          <p>
            Soy Víctor Moreno Ruiz, apasionado del desarrollo frontend y backend
            con experiencia en React, Node.js, diseño de interfaces y APIS en
            .NET y .NET Core. Me afrontar y resolver problemas complejos,
            realizar diversas optimizaciónes de rendimiento y transformar ideas
            en aplicaciones funcionales e intuitivas.
          </p>
          <p>
            Mi objetivo es seguir creciendo profesionalmente en entornos
            colaborativos, aportar valor a través de soluciones tecnológicas
            innovadoras y continuar aprendiendo constantemente mediante cursos y
            conferencias.
          </p>
        </section>

        <section className="curriculum">
          <h2>Currículum</h2>

          <img
            src="./Curriculum.png"
            alt="imagen seleccionada"
            className="img-fluid"    
          />
        </section>
      </div>
    </div>
  );
}
