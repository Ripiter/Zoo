using System;
using System.Collections.Generic;

namespace Zoo
{
    abstract class PlaceForAnimal
    {
        protected readonly object _lock = new object();
        private int amountOfAnimals;

        public int AmountOfAnimals
        {
            get { return amountOfAnimals; }
            set { amountOfAnimals = value; }
        }
        private Animal[] animalsInside;

        public Animal[] AnimalsInside
        {
            get { return animalsInside; }
            set { animalsInside = value; }
        }

        private List<Shit> shits;

        public List<Shit> Shits
        {
            get { return shits; }
            set { shits = value; }
        }

        public virtual void Open()
        {
            while (Zoo.Open)
            {
                Smell();

                for (int i = 0; i < AnimalsInside.Length; i++)
                {
                    lock (_lock)
                    {
                        Shit temp = null;

                        if (AnimalsInside[i].ShitsTakenToday < AnimalsInside[i].AmountOfShitPerDay)
                            temp = AnimalsInside[i].TakeAShit();


                        if (temp != null)
                            Shits.Add(temp);

                        Console.WriteLine("["+AnimalsInside[i]+"] shits: " + Shits.Count);
                    }
                }
            }
        }

        protected virtual void Smell()
        {
            try
            {
                for (int i = 0; i < Shits.Count; i++)
                {
                    if (Shits[i].TimeAlive > Shits[i].TimeToClean)
                        Customer.Satisfaction -= 0.1f;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }

        public PlaceForAnimal(params Animal[] animals)
        {
            this.AnimalsInside = animals;
            this.AmountOfAnimals = animals.Length;
        }

    }
}
