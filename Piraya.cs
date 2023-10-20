using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimals
{
    internal class Piraya : Fish
    {
        float _weight;

        //default constructor
        public Piraya()
        {
            _name = "Maja";
            _color = "mörkgrå";
            _sex = "hen";
            _habitat = "vatten";
            _age = 1;
            _fins = 5;
            _weight = 1;
        }

        //calling the main class constructor and initialize unique field for this class
        public Piraya(string name, string color, string sex, string habitat, int age, int fins, float weight)
            : base (name, color, sex, habitat, age, fins)
        {
            _weight = weight;
        }

        //using already existing methods with override
        public override void PrintAnimalInfo()
        {
            Console.WriteLine($"Pirayan heter {_name} och har färgen {_color}. {_name} är en {_sex} som är {_age} år gammal" +
                $" och lever i {_habitat}. {_name} har {_fins} fenor och väger {_weight} kg.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Pirayan {_name} låter blubb blubb!");
        }

        public override void Eat()
        {
            Console.WriteLine($"{_name} äter allt som kommer i dens väg!");
        }

        //uniqe method for this class
        public void Attack()
        {
            Console.WriteLine($"{_name} attackerar en annan fisk, bäst du simmar iväg innan {_name} tar dig!");
        }

    }
}
