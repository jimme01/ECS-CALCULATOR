# Contributing

Дякуємо за внесок у проєкт ECS-CALCULATOR!

## Початок роботи

1. Клонуйте репозиторій і встановіть хуки:

```powershell
    pip install pre-commit
    pre-commit install
    pre-commit install --hook-type commit-msg
    pre-commit install --hook-type pre-push
    pre-commit install --hook-type prepare-commit-msg
```

2. Переконайтесь, що проєкт збирається:
   `dotnet build ECS-Calculator/ECS-Calculator.sln`.

## Стратегія гілкування

Використовуємо **GitHub Flow**: `feature -> main`.

- `main` завжди стабільна, прямі коміти заборонені.
- Нова робота починається від актуальної `main`.
- Формат назв гілок: `feat/<назва>`, `fix/<назва>`, `docs/<назва>`,
  `chore/<назва>`.

## Коміти

Усі повідомлення мають відповідати **Conventional Commits**:
`<тип>: <опис>`.

| Тип | Коли застосовувати |
| --- | --- |
| `feat` | нова функціональність |
| `fix` | виправлення помилки |
| `docs` | зміни в документації |
| `refactor` | рефакторинг без зміни поведінки |
| `test` | тести |
| `chore` | налаштування, інфраструктура |

Приклад: `feat: add GCD and LCM operations`.

Формат перевіряє хук `commit-msg`, а форматування коду перевіряє
`dotnet format`. Коміт із помилкою буде відхилено.

## Pull Requests

1. Запуште гілку та створіть Pull Request у `main`.
2. Назва PR відповідає Conventional Commits, адже вона стане повідомленням
   squash-коміту.
3. В описі коротко поясніть, що зроблено і як перевірено.
4. Потрібно щонайменше одне схвалення (Approve) від іншого учасника.
5. Злиття виконується лише стратегією **Squash and Merge**.

## Code Review

Коментарі пишемо за **Conventional Comments**:

- `nit:` дрібниця, не блокує злиття;
- `suggestion:` рекомендація;
- `issue:` проблема, яку обов'язково виправити.

## Перед відправкою

- Код збирається, `dotnet format` не має зауважень.
- Документація (`.md`) проходить markdownlint.
- Для архітектурних рішень додано ADR у `docs/adr/`.