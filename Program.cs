namespace ZooAnimals
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            Fish myFish = new Fish("Lennart", "silver", "hane", "Östersjön", 6, 4);
            myFish.PrintAnimalInfo();
            myFish.MakeSound();
            myFish.Eat();
            myFish.Swim();

            Console.WriteLine("");

            Lion myLion = new Lion("Bosse", "brun", "hane", "Afrikas savann", 4, 80);
            myLion.PrintAnimalInfo();
            myLion.MakeSound();
            myLion.Eat();
            myLion.Run();

            Console.WriteLine("");

            Giraffe myGiraffe = new Giraffe("Stina", "beige med bruna prickar", "hona", "Afrikas savann", 8, 4.5f);
            myGiraffe.PrintAnimalInfo();
            myGiraffe.MakeSound();
            myGiraffe.Eat();
            myGiraffe.Bath();

            Console.WriteLine("");

            Clownfish myClownfish = new Clownfish("Lisa", "lysande orange", "hona", "ett korallrev i Stilla havet", 2, 8, 3);
            myClownfish.PrintAnimalInfo();
            myClownfish.MakeSound();
            myClownfish.Eat();
            myClownfish.Sleep();

            Console.WriteLine("");

            //creating object and calling default constructor
            Piraya myPiraya = new Piraya();
            myPiraya.PrintAnimalInfo();
            myPiraya.MakeSound();
            myPiraya.Eat();
            myPiraya.Attack();

            Console.WriteLine("");

            Animal myAnimal = new Animal();
            myAnimal.PrintAnimalInfo();
            myAnimal.MakeSound();
            myAnimal.Eat();
        }
    }
}