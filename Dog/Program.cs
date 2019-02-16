// Code for INFOTC 2040's Dog challenge
// By Brandon Buttlar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Gender
{
    Male,
    Female
}

namespace Dog
{
    public class Dog
    {
        public string name, owner, p1, p2, year;
        public int age;
        public Gender gender;

        // Constructor for each Dog instance, which also defines the pronouns
        // and checks if we need a plural string for "year"
        public Dog(string s1, string s2, int a, Gender g)
        {
            name = s1;
            owner = s2;
            age = a;
            gender = g;

            if (g == Gender.Male)
            {
                p1 = "His";
                p2 = "he";
            }
            else
            {
                p1 = "Her";
                p2 = "she";
            }

            if (a < 2) { year = "year"; }
            else { year = "years"; }
        }

        public void Bark(int barks)
        {
            for (int i = 1; i <= barks; i++)
            {
                Console.WriteLine("Woof!");
            }
        }   // I feel like I need to generate a newline at the end of this loop,
            // but for some reason it looks fine in my console, so...

        public string GetTag()
        {
            string tag = $"If lost, call {owner}. {p1} name is {name} and {p2} is {age} {year} old.\n";
            return tag;
        }
    }

    class Program
    {
        // This Main provides test instances for the Dog class, provided by Dale Musser
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.Bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            myDog.Bark(1); // output: Woof!
            Console.WriteLine(myDog.GetTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.

            Console.ReadLine();
        }
    }
}
