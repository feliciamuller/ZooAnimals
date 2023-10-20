using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimals
{
    internal class Lion : Animal
    {
        int _speed;

        //default constructor
        public Lion()
        {
            _name = "Leo";
            _color = "orange";
            _sex = "hen";
            _habitat = "savannen";
            _age = 1;
            _speed = 70;
        }

        //calling the main class constructor and initialize unique field for this class
        public Lion(string name, string color, string sex, string habitat, int age, int speed)
            : base (name, color, sex, habitat, age)
        {
            _speed = speed;
        }

        //using already existing methods with override
        public override void PrintAnimalInfo()
        {
            Console.WriteLine($"Lejonet heter {_name} och har färgen {_color}. {_name} är en {_sex} som är {_age} år gammal" +
                $" och lever i {_habitat}. {_name} har en topphastighet på {_speed} km/h.");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Lejonet {_name} låter RAAAAWR!");
        }

        public override void Eat()
        {
            Console.WriteLine($"{_name} äter kött.");
        }

        //uniqe method for this class
        public void Run()
        {
            Console.WriteLine($"{_name} springer fort!");
        }
    }
}
