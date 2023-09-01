using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6;
class Shop
{
    public string name;
    public string adres;
    public string descriptor;
    public string telephon;
    public string email;

    #region GetSetMetods
    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name;
    }
    public void SetAdres(string adres)
    {
        this.adres = adres;
    }
    public string GetAdres()
    {
        return adres;
    }
    public void SetDescriptor(string descriptor)
    {
        this.descriptor = descriptor;
    }
    public string SetDescriptor()
    {
        return descriptor;
    }
    public void SetTelephon(string telephon)
    {
        this.telephon = telephon;
    }
    public string GetTelephon()
    {
        return telephon;
    }
    public void SetEmail(string email)
    {
        this.email = email;
    }
    public string GetEmail()
    {
        return email;
    }

    #endregion GetSetMetods
    public void DataEntry ()
    {
        Console.Write("Введите название магазина: ");
        name = Console.ReadLine();
        Console.Write ("Введите адрес магазина: ");
        adres = Console.ReadLine();
        Console.Write("Введите описание магазина: ");
        descriptor = Console.ReadLine();
        Console.Write("Введите телефон магазина: ");
        telephon = Console.ReadLine();
        Console.Write  ("Введите адрес эл. почты: ");
        email = Console.ReadLine();
    }
public void PrintInfo()
    {
        Console.WriteLine($"Название магазина: \t{name}");
        Console.WriteLine($"Адрес магазина: \t{adres}");
        Console.WriteLine($"Описание магазина: \t{descriptor}");
        Console.WriteLine($"Телефон магазина: \t{telephon}");
        Console.WriteLine($"Адрес. эл. почты: \t{email}");
    }
}
