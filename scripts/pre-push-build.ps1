Write-Host "Перевірка збірки проєкту перед push..." -ForegroundColor Cyan

dotnet build ECS-Calculator/ECS-Calculator.sln --nologo

if ($LASTEXITCODE -ne 0) {
    Write-Host "Збірка провалилась. Push заблоковано." -ForegroundColor Red
    exit 1
}

Write-Host "Збірка успішна. Push дозволено." -ForegroundColor Green
exit 0