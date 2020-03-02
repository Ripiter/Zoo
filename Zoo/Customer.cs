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
                if (satisfaction > 0)
                    satisfaction = value;
                else
                    satisfaction = 0;

                Console.WriteLine($"[Customer] Customer satisfaction {satisfaction}");
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
