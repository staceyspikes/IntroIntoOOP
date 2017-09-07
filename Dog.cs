using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroIntoOOP
{
    class Dog
    {
        private int hairLength;
        private double height;
        private int runningSpeed;
        private decimal weight;

        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }


        public Dog()
        {

        }

        

        public Dog( int hairLength, double height, int runningSpeed, decimal weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;

        }
        public void Run()
        {
            Console.WriteLine("Look at me go");
        }
        public void Bark()
        {
            Console.WriteLine(" Dont get me angry or ill bark");
        }
        public void Potty()
        {
            Console.WriteLine(" Dont worry I'll stand by the door so you know");
        }
        public void Cuddle()
        {
            Console.WriteLine(" When i want to show affection i would like to cuddle");
        }

    }
}
