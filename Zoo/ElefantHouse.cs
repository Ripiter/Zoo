using System;
using System.Collections.Generic;

namespace Zoo
{
    class ElefantHouse : PlaceForAnimal
    {

        public ElefantHouse(params Animal[] animals) : base(animals)
        {
            Shits = new List<Shit>();
        }
    }
}
