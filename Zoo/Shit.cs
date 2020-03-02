using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zoo
{
    class Shit
    {
        private int timeToClean;

        public int TimeToClean
        {
            get { return timeToClean; }
            set { timeToClean = value; }
        }

        public float TimeAlive { get => timeAlive; set => timeAlive = value; }

        private float timeAlive = 0;
        

        public Shit(int time)
        {
            this.TimeToClean = time;
        }

    }
}
