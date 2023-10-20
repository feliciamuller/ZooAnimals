using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimals
{
    internal class Fish : Animal
    {
        //public field so other classes can reach it
        public int _fins;
       
        //default constructor
        public Fish()
        {
            _name = "Firre";
            _color = "blå";
            _sex = "hen";
            _habitat = "vatten";
            _age = 1;
            _fins = 4; 
        }

        //calling the main class constructor and initialize unique field for this class
        public Fish(string name, string color, string sex, string habitat, int age, int fins)
            : base (name, color, sex, habitat, age)
        {
            _fins = fins;
        }

        //using already existing methods with override
        public override void PrintAnimalInfo()
        {
            Console.WriteLine($"Fisken heter {_name} och har färgen {_color}. {_name} är en {_sex} som är {_age} år gammal" +
                $" och lever i {_habitat}. {_name} har {_fins} fenor.");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Fisken {_name} låter blubb blubb!");
        }

        public override void Eat()
        {
            Console.WriteLine($"{_name} äter alger och plankton.");
        }

        //uniqe method for this class
        public void Swim()
        {
            Console.WriteLine($"{_name} simmar.");
        }


    }
}
