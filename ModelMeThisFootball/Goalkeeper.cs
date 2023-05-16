using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMeThisFootball
{
    public class Goalkeeper : FootballPlayer
    {
        //public string Name { get; set; }
        //public int Number { get; set; }
        //public int Age { get; set; }
        //public double Height { get; set; }

        public Goalkeeper(string name, int number, int age, double height)
            :base(name, number, age, height)
        {
            
        }
    }

}
