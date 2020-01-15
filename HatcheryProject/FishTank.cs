using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Assignment
{
    class FishTank
    {
       public static int fishtankfishamount=1200;
       // HatcheryInventory HI = new HatcheryInventory();
        public int fishfromHatchery;
        public static int fishtankfishamountkatla = 1200;
        public int fishfromHatcherykatla;
        public void getFish(int f)
        {
            fishfromHatchery = f;
            Console.WriteLine("get fish " + fishfromHatchery);
            Thread thread = new Thread(new ThreadStart(generatefish));
            thread.Start();
           
        }

        public void generatefish()
        {
            Thread.Sleep(3000);

            fishtankfishamount = fishtankfishamount - fishfromHatchery;
            Console.WriteLine("fish tank fish amount :" + fishtankfishamount);
            if (fishtankfishamount<=300)
            {                   
                fishtankfishamount = 1000;
                Console.WriteLine("Auto generated: "+fishtankfishamount);
            }

        }
        public void getkatlaFish(int f)
        {
            fishfromHatcherykatla = f;
            Console.WriteLine("get fish " + fishfromHatcherykatla);
            Thread thread = new Thread(new ThreadStart(generatekatlafish));
            thread.Start();

        }

        public void generatekatlafish()
        {
            Thread.Sleep(3000);

            fishtankfishamountkatla = fishtankfishamountkatla - fishfromHatcherykatla;
            Console.WriteLine("fish tank fish amount :" + fishtankfishamountkatla);
            if (fishtankfishamountkatla <= 300)
            {
                fishtankfishamountkatla = 1000;
                Console.WriteLine("Auto generated: " + fishtankfishamountkatla);
            }

        }


    }
}
