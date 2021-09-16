using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCreationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Humain humain = new Humain();
            humain._name = "Sergey";
            humain.SayHello("Ashot");
            Dog dog = new Dog();
            dog._name = "Rex";
            dog.Bark("Cat");
            Cat cat = new Cat();
            cat._name = "Piso";
            cat.Meow("no metter");
        }
    }
    public class Animal
    {
        public string _name;


    }
    public class Humain : Animal
    {
        public void SayHello(string helloObject)
        {
            Console.WriteLine($"{_name} say hallo to {helloObject}");
        }
    }
    public class Dog : Animal
    {
        public void Bark(string barkObject)
        {
            Console.WriteLine($"{_name} bark on {barkObject}");
        }
    }
    public class Cat : Animal 
    {
        public void Meow(string meowObject) 
        {
            Console.WriteLine($"{_name} meow on {meowObject}");
        }
    }
}
