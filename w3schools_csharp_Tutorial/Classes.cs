using System;
using System.IO;

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

class BusPrivate
{
    // não é possível chamar essa variavel em outro lugar além daqui
    private string model = "Mercedes";
 }

class Person
{
    private string name ;

    public string Name
    {
        get {return name;}
        set {name = value;}
    }
}
//Person obj = new Person();
//obj.Name = "Liliam";
//Console.WriteLine(obj.Name);

//Propriedades Automáticas(Short Hand)
class Person2
{
    public string name
    { get; set; }

}

//Herança
class Veiculo
{
    public string brand = "Ford";
    public void honk()
    {
        Console.WriteLine(brand + "Exibindo");
    }
}

class Car2 : Veiculo
{
    public string modelName = "Tarefado";
}


// Polimorfismo (alterações em funções)
class Animal  // Base class (parent) 
{
    public void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}
//Animal myAnimal = new Animal();  // Create a Animal object
//Animal myPig = new Pig();  // Create a Pig object
//Animal myDog = new Dog();  // Create a Dog object

//myAnimal.animalSound();
//myPig.animalSound();
//myDog.animalSound();

enum Level
{
    Low,
    Medium,
    High
}

//Level myVar = Level.Medium;
//switch (myVar)
//{
//    case Level.Low:
//        Console.WriteLine("Low level");
//        break;
//    case Level.Medium:
//        Console.WriteLine("Medium level");
//        break;
//    case Level.High:
//        Console.WriteLine("High level");
//        break;
//}

enum Months
{
    January,    // 0
    February,   // 1
    March,      // 2
    April,      // 3
    May,        // 4
    June,       // 5
    July        // 6
}
//int myNum = (int)Months.April;
//Console.WriteLine(myNum);

// Arquivos

