using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4;

class WebSite
{
    private string name;
    private string path;
    private string description;
    private string ipAddress;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetPath(string path)
    {
        this.path = path;
    }

    public string GetPath()
    {
        return path;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetIpAddress(string ipAddress)
    {
        this.ipAddress = ipAddress;
    }

    public string GetIpAddress()
    {
        return ipAddress;
    }

    public void DataEntry()
    {
        Console.Write("Введите название сайта: ");
        name = Console.ReadLine();

        Console.Write("Введите путь к сайту: ");
        path = Console.ReadLine();

        Console.Write("Введите описание сайта: ");
        description = Console.ReadLine();

        Console.Write("Введите IP-адрес сайта: ");
        ipAddress = Console.ReadLine();
    }

    public void Print()
    {
        Console.WriteLine($"Название сайта: \t{name}");
        Console.WriteLine($"Путь к сайту:   \t{path}");
        Console.WriteLine($"Описание сайта: \t{description}");
        Console.WriteLine($"IP-адрес сайта: \t{ipAddress}");
    }
}