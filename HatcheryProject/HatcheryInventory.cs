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

        public static int hatcheryfishrui = 1000;





        public void BuyRuiAmountevent(Object ob, Sales s)
        {

            hatcheryfishrui = hatcheryfishrui - s.fishAmount;
            ///*hatcheryfish = hatcheryfish - MarketInventory.Rui;
            
            if(hatcheryfishrui <= 0)
            {
                hatcheryfishrui = hatcheryfishrui + FishTank.fishtankfishamount;
                Console.WriteLine(" hatchery Buy from fishtank : " + hatcheryfishrui);
            }

            Console.WriteLine("Available in  hatchery : "+ hatcheryfishrui);
            fishTank.getFish(hatcheryfishrui);
            /*Thread thread = new Thread(new ThreadStart(fishTank.generatefish));
           thread.Start();*/
            

            // fishTank.generatefish(s.fishAmount);
        }

       
    }

}