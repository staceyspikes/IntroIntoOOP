using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroIntoOOP
{
    class Cat
    {
        private string name;
        private string furColor;
        private int furLength;
        private int age;
        private bool isMale;
        private bool isHungry;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
        }
        public Cat()
        {
            this.name = "Mittens";

        }
        public Cat(string name)
        {
            this.name = name;
        }
        
        
        public Cat(string name, string furColor, int furLength, int age, bool isMale)
        {
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isMale = isMale;
        }
    }
}
