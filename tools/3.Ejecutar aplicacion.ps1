$currentPath = Get-Location

# Verificar si Docker está corriendo
$dockerStatus = Get-Command "docker" -ErrorAction SilentlyContinue
if ($dockerStatus) {
    Write-Host "Docker esta instalado." -ForegroundColor Green
} else {
    Write-Error "Docker no esta instalado o no esta corriendo. Asegúrese de que Docker esté instalado y en ejecución."
    Set-Location $currentPath
    exit
}

# Verificar si Docker Compose está instalado
$dockerComposeStatus = Get-Command "docker-compose" -ErrorAction SilentlyContinue
if ($dockerComposeStatus) {
    Write-Host "Docker Compose esta instalado." -ForegroundColor Green
} else {
    Write-Error "Docker Compose no está instalado. Instalando Docker Compose..."
    Set-Location $currentPath
    exit
}

# Ruta del archivo docker-compose.yml
$dockerComposePath = "./../Peliculas.API/Peliculas.API"

# Navegar al directorio de Docker Compose y ejecutar docker-compose up
Write-Host "Verificando Docker y levantando los contenedores con docker-compose up..."
cd $dockerComposePath

# Ejecutar docker-compose up en segundo plano
docker-compose up -d

# Verificar si el contenedor está corriendo correctamente (opcional)
Start-Sleep -Seconds 5  # Esperar 5 segundos para que Docker Compose inicie los contenedores
docker ps

# Verificar si Node.js y npm están instalados
if (Get-Command "node" -ErrorAction SilentlyContinue) {
    Write-Host "Node.js esta instalado." -ForegroundColor Green
} else {
    Write-Error "Node.js no esta instalado. Instalando Node.js..."
    Set-Location $currentPath
    exit
}

# Verificar si el SDK de .NET 8 está instalado
if (Get-Command "dotnet" -ErrorAction SilentlyContinue) {
    Write-Host ".NET SDK 8 esta instalado." -ForegroundColor Green
} else {
    Write-Error ".NET SDK 8 no está instalado. Instalando .NET SDK 8..."
    Set-Location $currentPath
    exit
}

$dotnetApiPath = "./../Peliculas.API"

# Navegar a la carpeta de la API y aplicar las migraciones de Entity Framework
Write-Host "Aplicando migraciones de Entity Framework..."
cd $dotnetApiPath
dotnet ef database update --configuration Debug

# Iniciar la API en .NET 8 en segundo plano
Write-Host "Iniciando la API en .NET 8..."
Start-Process "dotnet" -ArgumentList "run --configuration Debug" -WorkingDirectory $dotnetApiPath

$reactAppPath = "./../../react-peliculas"

# Navegar a la carpeta de la aplicación React y ejecutar en segundo plano
Write-Host "Iniciando la aplicación React..."
cd $reactAppPath
npm start

# Volver al directorio original
Set-Location $currentPath
Write-Host ""
Write-Host "Aplicaciones ejecutadas correctamente." -ForegroundColor Green
