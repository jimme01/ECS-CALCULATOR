param(
    [string]$CommitMessageFile
)

$commitMessage = Get-Content $CommitMessageFile -Raw

if ($commitMessage -notmatch '^(feat|fix|chore|docs|refactor|test): .+') {
    Write-Host "Invalid commit message."
    Write-Host "Use format: type: description"
    exit 1
}

exit 0