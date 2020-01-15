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


    }
}
