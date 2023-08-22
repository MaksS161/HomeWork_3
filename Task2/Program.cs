/*Задание 2
Напишите метод, который проверяет является ли
переданное число «палиндромом». Число передаётся в
качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
Палиндром — число, которое читается одинаково как
справа налево, так и слева направо. Например:
1221 — палиндром;
3443 — палиндром;
7854 — не палиндром.
*/


using System.Runtime.InteropServices;

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nПроверка:");
bool checkPalindrom (int number)
{
    int revers = 0;
    int buffer = 0;
    int initial = number;
    for (int i = 1; number != 0;i++)
    {
        buffer = number % 10;
        number = number / 10;
        revers = buffer + (revers * 10);
    }
    //Console.WriteLine(revers);

    if (revers == initial) return true;
    else return false;
}

Console.WriteLine(checkPalindrom(number));




