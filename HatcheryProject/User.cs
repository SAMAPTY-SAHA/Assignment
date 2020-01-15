using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class User
    {
          int fish;
          int katlaFish;
        int IlishFish;
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
                
                Console.WriteLine("Rui Fish sale amount : ");
                fish = Convert.ToInt32(Console.ReadLine());

                mp.SaleEvent += mi.SaleRuiAmount;
                mp.saleMethod(fish);


            }

            else if (option == 2)
            {
                Console.WriteLine("Katla fish sale amount : ");
                katlaFish = Convert.ToInt32(Console.ReadLine());
                mp.SaleEvent += mi.SaleKatlaAmount;
                mp.saleMethod(katlaFish);

            }
            else if (option == 3)
            {
                Console.WriteLine("Ilish fish sale amount : ");
                IlishFish = Convert.ToInt32(Console.ReadLine());
                mp.SaleEvent += mi.SaleIlishAmount;
                mp.saleMethod(IlishFish);

            }



        }


        
        
    }
}
