# API Reference

Опис публічних класів простору імен `ECS_Calculator.Operations`.

## AddSubtract

| Метод | Опис |
| --- | --- |
| `Add(double a, double b)` | сума |
| `Subtract(double a, double b)` | різниця |

## MultiplyDivide

| Метод | Опис |
| --- | --- |
| `Multiply(double a, double b)` | добуток |
| `Divide(double a, double b)` | частка |

## PowerModulo

| Метод | Опис |
| --- | --- |
| `Power(double baseNumber, double exponent)` | піднесення до степеня |
| `Modulo(double a, double b)` | остача від ділення |

## GcdLcm

| Метод | Опис |
| --- | --- |
| `Gcd(long a, long b)` | НСД (алгоритм Евкліда) |
| `Lcm(long a, long b)` | НСК через НСД |

## Factorial

Клас `internal static`, доступний лише в межах збірки.

| Метод | Опис |
| --- | --- |
| `Calculate(int number)` | факторіал числа, повертає `BigInteger` |

**Винятки:** `ArgumentException`, якщо `number < 0`.

**Нотатка:** тип `BigInteger` (`System.Numerics`) не переповнюється після `20!`, на відміну від `long`.

## OperationHistory

Зберігає історію виконаних операцій у пам'яті.

| Метод | Опис |
| --- | --- |
| `AddEntry(string operation)` | додає запис в історію після перевірки формату |

**Валідація:** запис не може бути `null`, порожнім чи складатись із пробілів, а також має містити хоча б один оператор з набору `+`, `-`, `*`, `/`, `^`.

**Винятки:** `ArgumentException`, якщо формат некоректний.
