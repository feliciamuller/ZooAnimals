using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimals
{
    internal class Animal
    {
        //creating fields
        public string _name;
        public string _color;
        public string _sex;
        public string _habitat;
        public int _age;

     
        //default constructor
        public Animal() 
        {
            _name = "Lasse";
            _color = "svart";
            _sex = "hen";
            _habitat = "skogen";
            _age = 1;
        }

        //creating constructor and initializing fields
        public Animal(string name, string color, string sex, string habitat, int age)
        {
            _name = name;
            _color = color;
            _sex = sex;
            _habitat = habitat;
            _age = age;
        }

        //creating 3 virtual methods
        public virtual void MakeSound() 
        {
            Console.WriteLine($"Djuret {_name} låter morr.");
        }
       
        public virtual void PrintAnimalInfo()
        {
            Console.WriteLine($"Djuret heter {_name} och har färgen {_color}. {_name} är en {_sex} som är {_age} år gammal " +
                $"och lever i {_habitat}.");
        }
        
        public virtual void Eat()
        {
            Console.WriteLine($"{_name} är allätare.");
        }
       

    }

}
