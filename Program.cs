using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroIntoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat("neko", "black", 3, 1, true, false, "blue", 4 );

            //Console.WriteLine(cat1.Name);
            //Console.WriteLine(cat2.Name);
            cat1.Name = "gato";
            //Console.WriteLine(cat1.Name);
            //Console.WriteLine(cat2.Age);
            //Console.WriteLine(cat1.Age);
            cat2.Eat();
            cat2.Run();
            Console.WriteLine(cat2.EyeColor);
            Console.WriteLine(cat2.ClawLength);

            cat2.sleep();
            cat2.Purr();

            Dog dog1 = new Dog();
            Dog dog2 = new Dog(7, 4.12, 25, 67);

            dog2.Bark();
            
        }
    }
}
