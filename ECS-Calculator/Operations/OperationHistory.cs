public class OperationHistory
{
    private readonly List<string> _history = new List<string>();

    public void AddEntry(string operation)
    {
        // Перевірка формату операції перед додаванням (виправляє issue)
        if (!IsValidOperation(operation))
        {
            throw new ArgumentException("Некоректний або порожній формат операції.", nameof(operation));
        }

        _history.Add(operation);
    }

    // Окремий метод валідації (виправляє suggestion)
    private bool IsValidOperation(string operation)
    {
        // 1. Перевірка на null або порожній рядок
        if (string.IsNullOrWhiteSpace(operation))
        {
            return false;
        }

        // 2. Перевірка на наявність хоча б одного математичного оператора
        string[] validOperators = { "+", "-", "*", "/", "^" };
        return validOperators.Any(op => operation.Contains(op));
    }
}