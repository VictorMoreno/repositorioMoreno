## Instalación de herramientas necesarias

Para poder instalarlo necesitas ejecutar el powershell en administrador

``` Powershell
Set-ExecutionPolicy Bypass -Scope Process -Force
iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))
choco -v

```

## Instalar nodejs

```
choco install nodejs
```

**Si aun asi da fallo al ejecutar npm start ejecutar el comando en el terminal Set-ExecutionPolicy Unrestricted**

# Getting Started with Create React App

This project was bootstrapped with [Create React App](https://github.com/facebook/create-react-app).

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

[Documentación del curso](https://github.com/gavilanch/React-y-ASP.NET-Core/tree/main/React%2017%20-%20ASP.NET%20Core%205)

## Learn More

You can learn more in the [Create React App documentation](https://facebook.github.io/create-react-app/docs/getting-started).

To learn React, check out the [React documentation](https://reactjs.org/).
