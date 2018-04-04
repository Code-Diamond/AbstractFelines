using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFelines
{
    class Program
    {
        //Create an abstract class for the Genus Felis
        public abstract class Felis
        {
            public void Meow()
            {
                //All cats can meow
                Console.WriteLine("Meow!");
            }
        }

        //Create an interface for kittens
        public interface IKitten
        {
            //Kitty meow signiture
            void KittyMeow();
        }
        //Create a class for cats
        public class Cat : Felis, IKitten
        {
            private int age;
            //KittyMeow's implementation
            void IKitten.KittyMeow()
            {
                //Kittens mew
                Console.WriteLine("mew!");
            }
            //Age getter setter
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }
        }
              

        static void Main(string[] args)
        {
            //Create Mr. Whiskers the cat
            Cat mrWhiskers = new Cat();
            //Mr. Whiskers has his methods and mutators
            mrWhiskers.Meow();
            mrWhiskers.Age = 5;
            Console.WriteLine("My age is {0}.", mrWhiskers.Age);
            //Create KitKat the kitty kitten cat
            IKitten kitKat = new Cat();
            //Say meow as a kitten
            kitKat.KittyMeow();
            //Keep console open
            Console.ReadLine();
        }
    }
}
