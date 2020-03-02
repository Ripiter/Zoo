using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zoo
{
    static class Time
    {
        public static void StartTime()
        {
            while(true)
            {
                if (Time.CurrectTime > 24)
                    Time.CurrectTime = 0;

                Thread.Sleep(1000);
                Time.CurrectTime++;

                UpdateSatisfaction();
            }
        }
        
        // Am not happy to have it here but for now its fine
        // TO DO: find better place for this method
        static void UpdateSatisfaction()
        {
            for (int i = 0; i < Zoo.places.Length; i++)
            {
                for (int j = 0; j < Zoo.places[i].Shits.Count; j++)
                {
                    Zoo.places[i].Shits[j].TimeAlive += 1;
                }
            }
        }

        private static float currectTime;

        public static float CurrectTime
        {
            get { return currectTime; }
            set { currectTime = value; }
        }

    }
}
