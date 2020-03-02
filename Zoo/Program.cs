using System.Threading;
using System.Threading.Tasks;
using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread timeThread = new Thread(Time.StartTime);
            timeThread.Start();
            Zoo.OpenZoo();

            // All Console writelines are for debug info
        }
    }
}
