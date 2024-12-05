Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass -Force

$repoUrl = "https://github.com/VictorMoreno/repositorioMoreno.git"

$desktopPath = [Environment]::GetFolderPath("Desktop")

$repoFolder = Join-Path -Path $desktopPath -ChildPath "ProyectoVictor"

# Verifica si la carpeta ya existe y la elimina para evitar conflictos
if (Test-Path $repoFolder) {
    Remove-Item -Recurse -Force -Path $repoFolder
}

git clone $repoUrl $repoFolder

Write-Host ""
Write-Host "El repositorio se ha descargado correctamente en: $repoFolder" -ForegroundColor Green