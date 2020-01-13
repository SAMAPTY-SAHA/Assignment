using System;
using System.Collections.Generic;
using System.Text;

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
        }

        public void generatefish()
        {   
            
            fishtankfishamount = fishtankfishamount - fishfromHatchery;
            Console.WriteLine("fish tank fish amount :" + fishtankfishamount);
            if (fishtankfishamount<300)
            {
                fishtankfishamount = 1000;
                Console.WriteLine("Auto generated: "+fishtankfishamount);
            }

        }

    }
}
