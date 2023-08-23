using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task5;

class Journal
{
    private string name;
    private string year;
    private string description;
    private string telephone;
    private string email;
    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name;
    }

    public void SetYear (string year)
    {
        this.year = year;
    }

    public string GetYear()
    {
        return year;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }
    public string GetDescription() 
    {
        return description;
    }
    public void SetTelephone(string telephone)
    {
        this.telephone = telephone;
    }
    public string GetTelephone()
    {
        return telephone;
    }

    public void SetEmail (string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }
    public void DataEntry()
    {
        Console.Write("Введите название журнала: ");
        name = Console.ReadLine();

        Console.Write("Введите год основания: ");
        year = Console.ReadLine();

        Console.Write("Введите описание журнала: ");
        description = Console.ReadLine();

        Console.Write("Введите контактный телефон: ");
        telephone = Console.ReadLine();

        Console.Write("Введите адрес эл.ппочты : ");
        email = Console.ReadLine();
    }
    public void Print()
    {
        Console.WriteLine($"Название журнала: \t{name}");
        Console.WriteLine($"Год основания:    \t{year}");
        Console.WriteLine($"Описание журныла: \t{description}");
        Console.WriteLine($"Контактный телефон: \t{telephone}");
        Console.WriteLine($"Адрес эл. почты:  \t{email}");
    }
}
