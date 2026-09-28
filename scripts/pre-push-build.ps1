Write-Host "Perevirka zbirky proektu pered push..." -ForegroundColor Cyan

dotnet build ECS-Calculator/ECS-Calculator.sln --nologo

if ($LASTEXITCODE -ne 0) {
    Write-Host "Zbirka provalylas. Push zablokovano." -ForegroundColor Red
    exit 1
}

Write-Host "Zbirka uspishna. Push dozvoleno." -ForegroundColor Green
exit 0