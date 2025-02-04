using System;
using Animal_Kingdom;
class Program
{
    static void Main()
    {
        Bird parrot = new Bird("Bird", 5);
        Fish goldfish = new Fish("Goldfish", 1);
        parrot.MakeSound();
        goldfish.MakeSound();

        Console.WriteLine(parrot.Name);
        Console.WriteLine(goldfish.Age);
    }
}
