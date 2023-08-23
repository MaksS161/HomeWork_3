/*Задание 3
Напишите метод, фильтрующий массив на основании
переданных параметров. Метод принимает параметры:
оригинальный_массив, массив_с_данными_для_фильтрации.Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
Например:
1 2 6 - 1 88 7 6 — оригинальный массив;
6 88 7 — массив для фильтрации;
1 2 - 1 — результат работы метода.
*/

// Не доделал (

Console.Write("Введите размер массива: ");
var linghtArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Заполните массив из {linghtArr} элиментов: ");
var arr = new int[linghtArr];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введенный массив ");
PrintCollection(arr);

Console.Write("\nСколько цифр убираем: ");
var linghtBrr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элименты фильтрации: ");
var brr = new int [linghtBrr];

for (int i = 0; i < brr.Length; i++)
{
    brr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Массив фильтрации ");
PrintCollection(brr);

void PrintCollection(IEnumerable<int> collection) 
{
    Console.Write("[ ");
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine("]");
}


void filter(int[] arr, int[] brr)
{
    var newArr = new List<int>();
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < brr.Length; j++)
        {
            if (arr[i] != brr[j])
            { 
            newArr.Add(i);
            }
        }
    }
PrintCollection(newArr);
}

filter(arr, brr);