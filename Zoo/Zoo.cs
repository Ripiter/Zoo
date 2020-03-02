using System;
using System.Threading;

namespace Zoo
{
    static class Zoo
    {
        static bool open = true;
        static int openTime = 10;
        static int closeTime = 20;
        static readonly object _lock = new object();

        public static bool Open { get => open; set => open = value; }

        public static void OpenZoo()
        {
            GenerateAnimals();
            
            for (int i = 0; i < places.Length; i++)
            {
                Thread t1 = new Thread(places[i].Open);
                t1.Start();
            }

            Thread t2 = new Thread(CleanPlace);
            t2.Start();

        }

        static void GenerateAnimals()
        {
            for (int i = 0; i < elefants.Length; i++)
            {
                elefants[i] = new Elefant();
            }

            for (int i = 0; i < giraffes.Length; i++)
            {
                giraffes[i] = new Giraffe();
            }

            places[0] = new ElefantHouse(elefants);
            places[1] = new GiraffeHouse(giraffes);
        }

        

        public static ZooKeeper[] zooKeepers = new ZooKeeper[]
        {
            new ZooKeeper("Melody"),
            new ZooKeeper("Karen")
        };

        public static Animal[] elefants = new Elefant[6];

        public static Animal[] giraffes = new Giraffe[12];

        public static PlaceForAnimal[] places = new PlaceForAnimal[2];

        static void CleanPlace()
        {
            while (Open)
            {
                for (int i = 0; i < zooKeepers.Length; i++)
                {
                    lock (_lock)
                    {
                        zooKeepers[i].CleanPlace(places[new Random(Guid.NewGuid().GetHashCode()).Next(0, places.Length)]);
                    }
                }
            }
        }
    }
}
