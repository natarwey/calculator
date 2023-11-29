using System;

Console.WriteLine("Введите выражение:");
string expression = Console.ReadLine();

string[] parts = expression.Split(' ');

int[] operands = new int[parts.Length / 2 + 1];
for (int i = 0; i < parts.Length; i += 2)
{
    operands[i / 2] = int.Parse(parts[i]);
}

for (int i = 1; i < parts.Length; i += 2)
{
    char operatorChar = char.Parse(parts[i]);
    int operand2 = int.Parse(parts[i + 1]);

    switch (operatorChar)
    {
        case '*':
            operands[i / 2] *= operand2;
            break;
        case '/':
            operands[i / 2] /= operand2;
            break;
        case '+':
        case '-':
            if (i + 2 < parts.Length && (parts[i + 2] == "+" || parts[i + 2] == "-"))
            {
                operands[i / 2 + 1] = operands[i / 2];
            }
            break;
    }
}

int result = operands[0];
for (int i = 1; i < parts.Length; i += 2)
{
    char operatorChar = char.Parse(parts[i]);
    int operand2 = int.Parse(parts[i + 1]);

    switch (operatorChar)
    {
        case '+':
            result += operand2;
            break;
        case '-':
            result -= operand2;
            break;
    }
}
Console.WriteLine("Результат: " + result);