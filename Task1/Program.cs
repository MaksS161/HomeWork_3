/*Задание 1
Напишите метод, который отображает квадрат из
некоторого символа. Метод принимает в качестве параметра: длину стороны квадрата, символ.
*/


Console.WriteLine("Введите длину стороны квадрата: ");
var length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите символ:");
char symbol = Convert.ToChar(Console.ReadLine());

print(length, symbol);
void print(int length, char symbol)
{
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            Console.Write($"{symbol} ");
        }
        Console.WriteLine();
    }
}
