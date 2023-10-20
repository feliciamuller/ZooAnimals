using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimals
{
    internal class Clownfish : Fish
    {
        int _stripes;

        //default constructor
        public Clownfish()
        {
            _name = "Nemo";
            _color = "orange";
            _sex = "hen";
            _habitat = "vatten";
            _age = 1;
            _fins = 6;
            _stripes = 3;
        }

        //calling the main class constructor and initialize unique field for this class
        public Clownfish(string name, string color, string sex, string habitat, int age, int fins, int stripes)
            : base (name, color, sex, habitat, age, fins)
        {
            _stripes = stripes;
        }

        //using already existing methods with override
        public override void PrintAnimalInfo()
        {
            Console.WriteLine($"Clownfisken heter {_name} och har färgen {_color} med {_stripes} vita ränder. {_name} är en {_sex} som är {_age} år gammal" +
                $" och lever i {_habitat}. {_name} har {_fins} fenor.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Clownfisken {_name} låter blubb blubb!");
        }

        public override void Eat()
        {
            Console.WriteLine($"{_name} äter alger.");
        }

        //uniqe method for this class
        public void Sleep()
        {
            Console.WriteLine($"{_name} sover, var tyst så du inte väcker {_name}!");
        }
    }
}
