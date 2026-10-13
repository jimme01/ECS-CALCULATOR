# 0002. Використання Conventional Commits та Squash and Merge

## Status

Accepted

## Context

Команда з трьох розробників працює в одному репозиторії. Історія `main`
має бути читабельною, а повідомлення комітів придатними для автоматичної
генерації changelog та визначення версії за SemVer.

## Decision

Усі коміти й назви Pull Request відповідають Conventional Commits.
Формат перевіряє локальний хук `commit-msg` (pre-commit framework).
Pull Request зливаються стратегією Squash and Merge.

## Consequences

- Історія `main` лінійна, один PR дорівнює одному коміту.
- Changelog і номер версії можна генерувати автоматично.
- Розробники мусять дотримуватись формату, інакше коміт буде відхилено.
