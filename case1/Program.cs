// Рекурсия
// Напишите программу, которая сложит два числа a и b, без прямого сложения
int SumNumbers(int x, int y) // x - 1, y + 1
{
    if (x == 0)
        return y;
    return SumNumbers(x - 1, y + 1);
}


Console.Clear();
Console.Write("Введите два числа: ");
int[] numbers = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray(); // Числа нужно вводить через пробел
Console.WriteLine($"Результат {numbers[0]} + {numbers[1]} = {SumNumbers(numbers[0], numbers[1])}");