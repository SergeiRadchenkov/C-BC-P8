// Быстрая сортировка O(n * log2(n))
/*
[7, 4, 1, 3, 5, 2, 6]
pivot = 7
[4, 1, 3, 5, 2, 6] + [7] + []
pivot = 4
[1, 3, 2] + [4] + [5, 6]
pivot = 1
[] + [1] + [3, 2]
pivot = 5
[] + [5] + [6]
pivot = 3
[2] + [3] + []
[1, 2, 3, 4, 5, 6, 7]
*/
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 21);
}

int[] QuickSort(int[] array, int leftIndex, int rightIndex)
{
    Console.WriteLine($"[{string.Join(", ", array)}] ({leftIndex}, {rightIndex})"); // Чтобы видеть этапы сортировки
    int i = leftIndex, j = rightIndex, pivot = array[leftIndex];
    while (i <= j)
    {
        while (array[i] < pivot)
        {
            i++;
        }
        while (array[j] > pivot)
        {
            j--;
        }
        if (i <= j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }
    if (leftIndex < j)
        QuickSort(array, leftIndex, j);
    if (i < rightIndex)
        QuickSort(array, i, rightIndex);

    return array;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", QuickSort(array, 0, array.Length - 1))}]");