﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class User
    {
          int fish;
        int katlaFish;
        Hatvhery hatchery=new Hatvhery();
        StroreMarket storemarket = new StroreMarket();
        //int count = 0;
        
        

        public void userNeed()
        {
           
            
            Console.WriteLine("option select : ");
            int option;
            option = Convert.ToInt32(Console.ReadLine());
            //int count = 0;

           


            MarketPlace mp = new MarketPlace();
            MarketInventory mi = new MarketInventory();

            if (option == 1)
            {
                //mp.SaleEvent += mi.SaleRuiAmount;
                //mp.saleMethod(fish);
                //hatchery.BuyRuiAmount(fish);
                //count++;
                // Console.WriteLine("Cout : " + count);

                // mi.ruifishListMethod();


                //MarketInventory.Instance.ruifishListMethod();
                Console.WriteLine("Sale amount : ");
                fish = Convert.ToInt32(Console.ReadLine());

                mp.SaleEvent += mi.SaleRuiAmount;
                //mp.SaleEvent += MarketInventory.Instance.SaleRuiAmount;
                mp.saleMethod(fish);


            }

            if (option == 2)
            {
                Console.WriteLine("Sale amount : ");
                katlaFish = Convert.ToInt32(Console.ReadLine());
                mp.SaleEvent += mi.SaleKatlaAmount;
                mp.saleMethod(katlaFish);

            }
        
    }


        
        
    }
}
