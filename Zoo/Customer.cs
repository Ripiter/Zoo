using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Customer
    {
        private static float satisfaction = 10f;

        public static float Satisfaction
        {
            get { return satisfaction; }
            set
            {
                satisfaction = value;
                Console.WriteLine($"[Customer] Customer satisfaction {Satisfaction}");
            }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
