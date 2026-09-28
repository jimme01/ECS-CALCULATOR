using System;
using System.Collections.Generic;

namespace ECS_Calculator.Operations
{
    public class OperationHistory
    {
        private readonly List<string> _history = new List<string>();

        public void AddEntry(string operation)
        {
            if (string.IsNullOrWhiteSpace(operation))
                throw new ArgumentException("Запис не може бути порожнім..");

            _history.Add($"{DateTime.Now:HH:mm:ss} - {operation}");
        }

        public List<string> GetHistory() => new List<string>(_history);
    }
}