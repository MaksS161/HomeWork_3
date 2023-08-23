/*Задание 4
Создайте класс «Веб-сайт». Необходимо хранить в
полях класса: название сайта, путь к сайту, описание
сайта, ip адрес сайта. Реализуйте методы класса для ввода
данных, вывода данных, реализуйте доступ к отдельным
полям через методы класса.
*/


using System;

using Task4;

//class Program
//{
//    static void dis(string[] args)
//    {
        WebSite webSite = new WebSite();
        webSite.DataEntry();
        Console.WriteLine();
        webSite.Print();
//    }
//}


