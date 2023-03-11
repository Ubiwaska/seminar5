//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.Clear();
double[] array = GetArray(10, 1, 8);
Console.WriteLine(String.Join(" ", array));
double MaxNumber = GetMaxNumber(array);
double MinNumber = GetMinNumber(array);
Console.WriteLine($"Difference of {MaxNumber} and {MinNumber} = {MaxNumber - MinNumber} ");

// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]
double[] GetArray(double size, double minValue, double maxValue)
{
    double[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

double GetMaxNumber(double[] arr)
{
    double MaxNumber = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > MaxNumber)
    {
        // найден больший элемент
        MaxNumber = array[i];
    }
    return MaxNumber;
}
}
    double GetMinNumber (double[] arr)
{
    double MinNumber = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < MinNumber)
    {
        MinNumber = array[i];
    }
    return MinNumber;
}
}




