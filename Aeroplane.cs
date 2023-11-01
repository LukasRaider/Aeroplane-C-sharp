using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplane
{
    class Person {
        public String Gender { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public Person(String sex,int height, int age) { 
            Gender = sex;
            Height = height;
            Age = age;
        }
        public int GetWeight()
        { return Height - 100; }
    }
    class Animal {
        public enum AnimalType { mammal = 50, reptile = 10, fish = 5, bird = 3, insect = 1/10}
        public AnimalType Type { get; set; }
        public Animal(AnimalType type) {
            Type = type;
        }
        public double GetWeight()
        { 
            switch(Type)
                {
                case AnimalType.mammal:return 50;
                    case AnimalType.reptile:return 10;
                    case AnimalType.fish:return 5;
                    case AnimalType.bird:return 3;
                    case AnimalType.insect:return 0.1;
                default: return 0;
            }
        }
    }
    class Thing {
        public int Height {get;set;}
        public int Lenght { get; set; }
        public int Width { get; set; }
        public Thing(int height,int lenght, int width) { 
            Height=height; Lenght=lenght; Width=width;
        }
        public double GetWeight() { return (Height * Lenght * Width) * 2; }
    }
    class TestAeroplane
    {
        public static void Mainx(string[] args)
        {
            List<object> cargo = new List<object>();
            cargo.Add(new Person("Male", 180, 30));
            cargo.Add(new Person("Female", 160, 25));
            cargo.Add(new Animal(Animal.AnimalType.mammal));
            cargo.Add(new Animal(Animal.AnimalType.reptile));
            cargo.Add(new Thing(10, 20, 30));
            cargo.Add(new Thing(5, 10, 15));

            double totalWeight = 0;

            foreach (var item in cargo)
            {
                if (item is Person)
                {
                    totalWeight += ((Person)item).GetWeight();
                }
                else if (item is Animal)
                {
                    totalWeight += ((Animal)item).GetWeight();
                }
                else if (item is Thing)
                {
                    totalWeight += ((Thing)item).GetWeight();
                }
            }

            Console.WriteLine("Total weight of cargo: " + totalWeight + " kg");
        }
    }
}
    
