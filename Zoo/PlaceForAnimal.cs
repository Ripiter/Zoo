using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public abstract void Open();

        protected abstract void Smell();

        public PlaceForAnimal(params Animal[] animals)
        {
            this.AnimalsInside = animals;
            this.AmountOfAnimals = animals.Length;
        }

    }
}
