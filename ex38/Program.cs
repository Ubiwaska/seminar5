//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. 
    //[3 7 22 2 78] -> 76 
    Console.Clear(); 
    double[] array = GetArray(10, 1, 8); 
    Console.WriteLine(String.Join(" ", array)); 
    double MaxNumber = GetMaxNumber(array); 
    double MinNumber = GetMinNumber(array); 
    Console.WriteLine($"Difference between the maximal number {MaxNumber} and the minimal number {MinNumber} equals to {MaxNumber - MinNumber} "); 
     
     
    // Возвращает массив из size элементов, 
    // заполненный случайными числами из промежутка [minValue, maxValue] 
    double[] GetArray(int size, double minValue, double maxValue) 
    { 
        double[] res = new double[size]; 
        for (int i = 0; i < size; i++) 
        { 
            res[i] = new Random().NextDouble()*(maxValue - minValue) + minValue; 
        } 
        return res; 
    } 
     
    double GetMaxNumber(double[] array) 
    { 
        double MaxNumber = array[0]; 
        for (int i = 0; i < array.Length; i++) 
        { 
            if (array[i] > MaxNumber) 
            { 
                MaxNumber = array[i]; 
            } 
        }
        return MaxNumber; 
    
    } 
    double GetMinNumber (double[] array) 
    { 
        double MinNumber = array[0]; 
        
        for (int i = 0; i < array.Length; i++) 
        { 
            if (array[i] < MinNumber) 
            { 
                MinNumber = array[i]; 
            } 
        } 
        return MinNumber; 
    }




