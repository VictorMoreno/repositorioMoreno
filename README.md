# Herramientas necesarias
- .NET 8
- React
- Node.js
- Docker

Para la instalación de los componentes necesarios, se han generado utilidades **.ps1** que se pueden encontrar en la carpeta tools, de manera que sino queremos instalar las dependencias manualmente, simplemente ejecutando el script de instalacion de componentes los aplicara por nosotros.

**Debemos tener en cuenta que el terminar / powershell se debe ejecutar en modo administrador para poder ejecutar los comandos, en caso de que no nos deje ejecutar los scripts debemos ejecutar el siguiente comando desde el terminar /powershell**

```
Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass -Force
```

# Frameworks utilidados

## Instalar nodejs

```
choco install nodejs
```

### Instalar Bootstrap 
```
npm install bootstrap
```

### Instalar Router 
```
npm i react-router-dom
npm i --save-dev @types/react-router-dom
```

### Instalar Formik
```
npm install formik
```

### Instalar Yup
```
npm i yup
```

### Instalar Componentes para uso de MarkDown
```
npm install react-markdown typed-react-markdown
```

### Instalar Leaflet para mapas en React
```
npm install --save-exact leaflet react-leaflet @react-leaflet/core

npm i -D @types/leaflet
```

### Instalar typeahead para buscador filtrado
```
npm i react-bootstrap-typeahead
npm i -D @types/react-bootstrap-typeahead
```

### Instalación de Axios para peticiones HTTP
```
npm i axios
```

### Instalación de sweetalert2 para ventanas de confirmación animados
```
npm i sweetalert2
```

### Instalación de font Awesome para iconos
```
npm install --save @fortawesome/fontawesome-svg-core
npm install --save @fortawesome/free-solid-svg-icons
npm install --save @fortawesome/react-fontawesome

```

**Si aun asi da fallo al ejecutar npm start ejecutar el comando en el terminal Set-ExecutionPolicy Unrestricted**

## Available Scripts

In the project directory, you can run:

### `npm start`

Runs the app in the development mode.\
Open [http://localhost:3000](http://localhost:3000) to view it in the browser.

The page will reload if you make edits.\
You will also see any lint errors in the console.

### `npm test`

Launches the test runner in the interactive watch mode.\
See the section about [running tests](https://facebook.github.io/create-react-app/docs/running-tests) for more information.

### `npm run build`

Builds the app for production to the `build` folder.\
It correctly bundles React in production mode and optimizes the build for the best performance.

The build is minified and the filenames include the hashes.\
Your app is ready to be deployed!

See the section about [deployment](https://facebook.github.io/create-react-app/docs/deployment) for more information.

### `npm run eject`

**Note: this is a one-way operation. Once you `eject`, you can’t go back!**

If you aren’t satisfied with the build tool and configuration choices, you can `eject` at any time. This command will remove the single build dependency from your project.

Instead, it will copy all the configuration files and the transitive dependencies (webpack, Babel, ESLint, etc) right into your project so you have full control over them. All of the commands except `eject` will still work, but they will point to the copied scripts so you can tweak them. At this point you’re on your own.

You don’t have to ever use `eject`. The curated feature set is suitable for small and middle deployments, and you shouldn’t feel obligated to use this feature. However we understand that this tool wouldn’t be useful if you couldn’t customize it when you are ready for it.



## Learn More

You can learn more in the [Create React App documentation](https://facebook.github.io/create-react-app/docs/getting-started).

To learn React, check out the [React documentation](https://reactjs.org/).
