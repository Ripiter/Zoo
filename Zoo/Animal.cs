using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Animal
    {
        private float timeToRemoveShit;

        public float TimeToRemoveShit
        {
            get { return timeToRemoveShit; }
            set { timeToRemoveShit = value; }
        }

        private int amountOfShitPerDay;

        public int AmountOfShitPerDay
        {
            get { return amountOfShitPerDay; }
            set { amountOfShitPerDay = value; }
        }

        private int shitsTakenToday;

        public int ShitsTakenToday
        {
            get { return shitsTakenToday; }
            set { shitsTakenToday = value; }
        }


        public Animal(float timeToRemove, int amountPerDay)
        {
            this.TimeToRemoveShit = timeToRemove;
            this.AmountOfShitPerDay = amountPerDay;
        }

        public abstract Shit TakeAShit();
    }
}
