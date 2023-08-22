// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Введите массив данных!");
var arr = new char[9];
var brr = new char[4] { '6', '8', '8', '7' };


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToChar(Console.ReadLine());
}

void filterData(char[] arr, char[] brr)
{
    var crr = new char[9];
    for (int i = 0; i < arr.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < brr.Length; j++)
        {
            if (arr[i] == brr[j]) count++;
        }
        if (count == 0) crr[i] = arr[i];
    }

    for (int i = 0; i < crr.Length; i++)
    {
        Console.Write(crr[i]);
    }
}

filterData(arr, brr);