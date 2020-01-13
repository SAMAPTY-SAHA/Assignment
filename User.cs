using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class User
    {
          int fish;
        Hatvhery hatchery=new Hatvhery();

        public void userNeed()
        {
           
            Console.WriteLine("Sale amount : ");
            fish = Convert.ToInt32(Console.ReadLine());

            MarketPlace mp = new MarketPlace();
            MarketInventory mi = new MarketInventory();

            mp.SaleEvent += mi.SaleRuiAmount;
            mp.saleMethod(fish);
            hatchery.BuyRuiAmount(fish);






           

        }


        
        
    }
}
