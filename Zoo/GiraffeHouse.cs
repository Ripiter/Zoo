using System;
using System.Collections.Generic;

namespace Zoo
{
    class GiraffeHouse : PlaceForAnimal
    {
        public GiraffeHouse(params Animal[] animals) : base(animals)
        {
            Shits = new List<Shit>();
        }

        public override void Open()
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

                    }
                    //Console.WriteLine("[GirafeHouse] shits: " + Shits.Count);
                }
            }
        }

        protected override void Smell()
        {
            try
            {
                for (int i = 0; i < Shits.Count; i++)
                {
                    if (Shits[i].TimeAlive > Shits[i].TimeToClean)
                        Customer.Satisfaction -= 0.3f;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }
    }
}
