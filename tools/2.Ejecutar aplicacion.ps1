$currentPath = Get-Location

# Verificar si Docker está instalado
$dockerStatus = Get-Command "docker" -ErrorAction SilentlyContinue
if ($dockerStatus) {
    Write-Host "Docker esta instalado." -ForegroundColor Green

	$dockerPath = "C:\Program Files\Docker\Docker\Docker Desktop.exe"
	Start-Process $dockerPath	
	Start-Sleep -Seconds 10	
} else {
    Write-Error "Docker no está instalado. Asegurate de que Docker este instalado."
    Set-Location $currentPath
    exit
}

# Verificar si Docker Compose está instalado
$dockerComposeStatus = Get-Command "docker-compose" -ErrorAction SilentlyContinue
if ($dockerComposeStatus) {
    Write-Host "Docker Compose esta instalado." -ForegroundColor Green
} else {
    Write-Error "Docker Compose no esta instalado. Asegurate de instalarlo."
    Set-Location $currentPath
    exit
}

# Ruta del archivo docker-compose.yml
$dockerComposePath = "./../Peliculas.API/Peliculas.API"

# Navegar al directorio de Docker Compose y ejecutar docker-compose up
Write-Host "Levantando los contenedores con docker-compose up..."
cd $dockerComposePath

# Ejecutar docker-compose up en segundo plano
docker-compose up -d

# Verificar si los contenedores están corriendo correctamente
Start-Sleep -Seconds 5
docker ps

# Verificar si el SDK de .NET 8 está instalado
if (Get-Command "dotnet" -ErrorAction SilentlyContinue) {
    Write-Host ".NET SDK 8 está instalado." -ForegroundColor Green
} else {
    Write-Error ".NET SDK 8 no está instalado. Asegúrate de instalarlo."
    Set-Location $currentPath
    exit
}

$dotnetApiPath = "./../Peliculas.API"

# Navegar a la carpeta de la API y aplicar las migraciones de Entity Framework
Write-Host "Aplicando migraciones de Entity Framework..."
cd $dotnetApiPath
dotnet tool install --global dotnet-ef
dotnet build
dotnet ef database update --project Peliculas.API.csproj --startup-project Peliculas.API.csproj --context Peliculas.API.Infraestructura.ApplicationDbContext --configuration Debug "20241127151213_Datos Sinopsis"

# Iniciar la API en .NET 8 en segundo plano
Write-Host "Iniciando la API en .NET 8..."
dotnet dev-certs https --trust
Start-Process "dotnet" -ArgumentList "run --configuration Debug" -WorkingDirectory $dotnetApiPath

$reactAppPath = "./../../react-peliculas"

# Navegar a la carpeta de la aplicación React y ejecutar en segundo plano
Write-Host "Iniciando la aplicación React..."
cd $reactAppPath
npm install
npm start

# Volver al directorio original
Set-Location $currentPath
Write-Host ""
Write-Host "Aplicaciones ejecutadas correctamente." -ForegroundColor Green
