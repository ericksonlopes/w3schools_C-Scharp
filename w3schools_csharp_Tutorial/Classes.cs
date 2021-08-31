using System;

class Bus
{
    public string color = "Minha cor";
    // Car obj = new Car();
    // Console.WriteLine(obj.color);
}


class MinhaClasse
{
    string color = "Vermelho";

    int maxSleep = 400;

    public void Executar()
    {
        Console.WriteLine("Você esta rápido");
        //  MinhaClasse obj = new MinhaClasse();
        // obj.Executar();
    }
}

class Skate
{
    string shape;
    string truck;
    int rolamentos;
}

class Car
{
    public string name;
    public string color;
    public int year;

    public Car(string modelName, string modelColor, int modelYear)
    {
        name = modelName;
        color = modelColor;
        year = modelYear;
    }

    // Car Ford = new Car("Brasilia", "Vermelha", 1999);
}