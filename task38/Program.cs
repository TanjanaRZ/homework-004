// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. Найдите
// разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = { 5, 93, 3, 59, 6, 4, 5, 19, 8 };
double max = array[0];
    double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max=array[i];
    }
    else if (min > array[i])
    {
        min =array[i];
    }
}
Console.WriteLine(max - min);