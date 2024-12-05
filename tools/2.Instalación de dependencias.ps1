# Configurar permisos de ejecución local
Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass -Force

# Función para instalar Node.js
function Install-NodeJS {
    Write-Host "Iniciando la instalacion de Node.js..." -ForegroundColor Cyan
    $nodeInstallerUrl = "https://nodejs.org/dist/v18.18.2/node-v18.18.2-x64.msi"  # Última versión LTS
    $nodeInstallerPath = "$env:TEMP\nodejs-installer.msi"

    # Descargar instalador de Node.js
    Invoke-WebRequest -Uri $nodeInstallerUrl -OutFile $nodeInstallerPath

    # Instalar Node.js
    Start-Process -FilePath "msiexec.exe" -ArgumentList "/i `"$nodeInstallerPath`" /quiet /norestart" -Wait
    Write-Host "Node.js se ha instalado correctamente." -ForegroundColor Green
}

# Función para instalar .NET SDK 8
function Install-DotNetSDK {
    Write-Host "Iniciando la instalacion del .NET SDK 8..." -ForegroundColor Cyan
    $dotnetInstallerPath = "./dotnet-8-x64.exe"

    # Instalar .NET SDK
    Start-Process -FilePath $dotnetInstallerPath -ArgumentList "/quiet /norestart" -Wait
    Write-Host ".NET SDK 8 se ha instalado correctamente." -ForegroundColor Green
}

function Install-Docker {
	# Verificar si Docker ya está instalado
	if (Get-Command "docker" -ErrorAction SilentlyContinue) {
		Write-Host "Docker ya esta instalado."
	} else {
		Write-Host "Docker no esta instalado. Procediendo con la instalacion..."

		# Habilitar el soporte de WSL 2
		Write-Host "Habilitando la característica de WSL..."
		dism.exe /online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all /norestart
		dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart

		# Descargar Docker Desktop
		$dockerUrl = "https://desktop.docker.com/latest/stable/Docker%20Desktop%20Installer.exe"
		$outputPath = "$env:TEMP\DockerDesktopInstaller.exe"

		Write-Host "Descargando Docker Desktop..."
		Invoke-WebRequest -Uri $dockerUrl -OutFile $outputPath

		# Ejecutar el instalador de Docker
		Write-Host "Instalando Docker Desktop..."
		Start-Process -FilePath $outputPath -ArgumentList "/quiet" -Wait

		# Iniciar Docker Desktop
		Write-Host "Iniciando Docker Desktop..."
		Start-Process "C:\Program Files\Docker\Docker\Docker Desktop.exe"

		Write-Host "Docker ha sido instalado correctamente. Se recomienda reiniciar el sistema." -ForegroundColor Green
	}

	# Verificar si Docker está funcionando correctamente
	docker --version


}

# Verificar si el usuario tiene permisos de administrador
if (-Not ([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)) {
    Write-Error "Por favor, ejecute este script como administrador."
    exit
}

# Instalar Node.js y .NET SDK
Install-NodeJS
Install-DotNetSDK
Install-Docker

# Confirmación
Write-Host "Todas las herramientas se han instalado correctamente." -ForegroundColor Green
