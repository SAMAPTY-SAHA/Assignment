using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Assignment
{
    class HatcheryInventory
    {
        public static  int hatcheryfish = 1000;
        FishTank fishTank = new FishTank();
       
        

        public void BuyAmount(Object ob, Sales s)
        {

            hatcheryfish = hatcheryfish - s.fishAmount;
            Console.WriteLine("Available in  hatchery : "+ hatcheryfish);
            fishTank.getFish(hatcheryfish);
            Thread thread = new Thread(new ThreadStart(fishTank.generatefish));
            thread.Start();

            // fishTank.generatefish(s.fishAmount);
        }

       
    }

}