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
    }
}
