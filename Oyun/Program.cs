using Main;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Baslangic seviyesi girin: ");
        int baslangic = Convert.ToInt32(Console.ReadLine());

        Ucak ucak = new Ucak(baslangic);

        Ucak ucak2 = new Ucak(baslangic);

        ucak.KartPuaniGoster();

        ucak.DurumGuncelle(ucak2.Vurus);
        ucak.DurumGuncelle(ucak2.Vurus);

        if ("merhaba" == "merhaba")
        {
            Console.WriteLine("ise yariyor.");
        }
        else
        {
            Console.WriteLine("ise yaramiyor");
        }


    }
}

class Vehicle
{
    public int speed = 0;

    public String name;

    public void go()
    {
        Console.WriteLine($"{name} is moving at {speed} km/h.");

    }
}

class Car : Vehicle
{
    public Car()
    {
        name = "car";
    }
}

class Bicycle : Vehicle
{
    public int wheels = 2;
}
class Boat : Vehicle
{
    public int wheels = 0;
}
