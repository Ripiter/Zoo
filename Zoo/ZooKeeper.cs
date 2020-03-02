using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zoo
{
    class ZooKeeper
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool busy;

        public bool Busy
        {
            get { return busy; }
            set { busy = value; }
        }

        public ZooKeeper(string _name)
        {
            this.Name = _name;
        }

        public void CleanPlace(PlaceForAnimal place)
        {
            Shit shit = null;

            if (place.Shits.Count != 0)
                shit = place.Shits[new Random().Next(0, place.Shits.Count)];

            if (shit != null)
            {
                Busy = true;
                Console.WriteLine("[ZooKeeper] Cleaning" + place);
                CleanShit(shit);
                place.Shits.Remove(shit);
                Busy = false;
            }
        }

        void CleanShit(Shit shit)
        {
            Thread.Sleep(shit.TimeToClean);
        }
    }
}
