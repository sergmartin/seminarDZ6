// задача № 41
Console.Clear();
Console.Write("Введите количество чисел в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[m];

for (int i = 0; i<m; i++ )
{
    Console.Write("Введите число в массив: ");
    mass[i] = Convert.ToInt32(Console.ReadLine());
}


// метод для вычесления числа больше нуля
int Plus0(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i] > 0) count++;
    
    }
    return count;
}


// вывод массива
Console.WriteLine("[" + string.Join(",", mass) + "]");
Console.WriteLine($"Чисел больше нуля: {Plus0(mass)}");