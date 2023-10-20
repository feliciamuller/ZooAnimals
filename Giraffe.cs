using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimals
{
    internal class Giraffe : Animal
    {
        float _height;

        //default constructor
        public Giraffe()
        {
            _name = "Bibbi";
            _color = "brun";
            _sex = "hen";
            _habitat = "savannen";
            _age = 1;
            _height = 4.3f;
        }

        //calling the main class constructor and initialize unique field for this class
        public Giraffe(string name, string color, string sex, string habitat, int age, float height)
            : base (name, color, sex, habitat, age)
        { 
            _height = height;
        }

        //using already existing methods with override
        public override void PrintAnimalInfo()
        {
            Console.WriteLine($"Giraffen heter {_name} och har färgen {_color}. {_name} är en {_sex} som är {_age} år gammal" +
                $" och lever i {_habitat}. {_name} är hela {_height} meter lång!");
        }
        
        public override void MakeSound()
        {
            Console.WriteLine($"Giraffen {_name} låter wrrhaaiii! \n(ni får gå in på den här länken för att höra hur hon låter https://www.youtube.com/watch?v=2_P-2VB0quM) ");
        }

        public override void Eat()
        {
            Console.WriteLine($"{_name} äter löv från träd och buskar.");
        }

        public void Bath()
        {
            Console.WriteLine($"{_name} badar i ett vattenhål.");
        }

    }
}
