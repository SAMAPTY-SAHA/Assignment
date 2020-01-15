using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Assignment
{
    class HatcheryInventory
    {
       // public static  int hatcheryfish = 1000;
        FishTank fishTank = new FishTank();

        public static int hatcheryfishrui = 1000;
        public static int hatcheryfishkatla = 1000;





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
           
        }

        public void BuyKatlaAmountevent(Object ob, Sales s)
        {

            hatcheryfishkatla = hatcheryfishkatla - s.fishAmount;
            ///*hatcheryfish = hatcheryfish - MarketInventory.Rui;

            if (hatcheryfishkatla <= 0)
            {
                hatcheryfishkatla = hatcheryfishkatla + FishTank.fishtankfishamountkatla;
                Console.WriteLine(" hatchery Buy from fishtank : " + hatcheryfishkatla);
            }

            Console.WriteLine("Available in  hatchery : " + hatcheryfishkatla);
            fishTank.getFish(hatcheryfishkatla);

        }


    }

}