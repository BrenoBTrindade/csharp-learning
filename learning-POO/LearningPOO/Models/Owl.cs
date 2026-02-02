using learning_POO.Models;

namespace LearningPOO.Models;

public class Owl : Animal, Oviparous, Flyer
{
    public int EggAmount { get; set; }
    public Owl(string name, int age, int eggAmount) : base(name, age)
    {
        EggAmount = eggAmount;
    }

    public Owl() { }

    public override string Comer()
    {
        return "A coruja comeu";
    }

    public void LayEggs()
    {
        Console.WriteLine($"{Name} botou {EggAmount} ovos");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} Voou");
    }
}