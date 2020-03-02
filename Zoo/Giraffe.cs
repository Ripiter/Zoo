using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Giraffe : Animal
    {
        public Giraffe() : base(4, 6)
        {

        }

        public Giraffe(float timeToRemove, int amountPerDay) : base(timeToRemove, amountPerDay)
        {

        }

        public override Shit TakeAShit()
        {
            //Console.WriteLine("[Giraffe] Shit Taken");
            ShitsTakenToday += 1;
            return new Shit((int)TimeToRemoveShit);
        }
    }
}
