using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroIntoOOP
{
    class Cat
    {
        //Fields
        private string name;
        private string furColor;
        private int furLength;
        private int age;
        private bool isMale;
        private bool isHungry;
        private string eyeColor;
        private int clawLength;
        
        // Properties, properties allow access to private fields. Prop tab twice
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
        }
        public string EyeColor
        {
            get { return this.eyeColor; }
            set { this.eyeColor = value; }
        }
        public int ClawLength
        {
            get { return this.clawLength; }
            set { this.clawLength = value; }
        }
        public Cat()
        {
            this.name = "Mittens";

        }
        public Cat(string name)
        {
            this.name = name;
        }
        
        
        public Cat(string name, string furColor, int furLength, int age, bool isMale, bool isHungry, string eyeColor, int clawLength)
        {
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isMale = isMale;
            this.isHungry = isHungry;
            this.eyeColor = eyeColor;
            this.clawLength = clawLength;
        }
        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
                Console.WriteLine("I'm stuffed");
            }
            else if (!isHungry)
            {
                Console.WriteLine("Im good no food for me");
            }
        }
        public void Run()
        {
            Console.WriteLine(" I am running really fast!!");
            this.isHungry = true;
        }
        public void Purr()
        {
            Console.WriteLine(" My name is {0} and yes i can purr", this.Name );
        }
        public void sleep()
        {
            Console.WriteLine("Leave me alone im napping");
        }
    }
}
