using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class FootballPlayer
    {
        //fields of the class
        private string name;
        private int age;
       
        //constructors
        public FootballPlayer()
        {
            //creates the instance of the class
        }
        public FootballPlayer(string name)
        {
            this.name = name;
        }

        //these are properties of the class
        public string Name 
        {
            get { return "Mr. "+ name; }
            set { name = value; }
        }

        public string Country { get; set; }

        public double Rateing { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                age = value>0 ? value:0;
            }
        }
    }
}
