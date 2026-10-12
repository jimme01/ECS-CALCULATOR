param(
    [string]$CommitMsgFile
)

$devName = git config user.name
$timestamp = Get-Date -Format "yyyy-MM-dd HH:mm:ss"

Add-Content -Path $CommitMsgFile -Value "`n# Автор: $devName | Час: $timestamp"