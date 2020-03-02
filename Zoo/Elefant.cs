using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zoo
{
    class Elefant : Animal
    {
        public Elefant(float timeToRemove, int amountPerDay) : base(timeToRemove, amountPerDay)
        {

        }

        public Elefant() : base(6, 15)
        {

        }

        public override Shit TakeAShit()
        {
            Console.WriteLine("[Elefant] Shit Taken");
            ShitsTakenToday += 1;
            return new Shit((int)TimeToRemoveShit);
        }
    }
}
