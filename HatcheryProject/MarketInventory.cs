using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class MarketInventory
    {
       static  int Rui = 1000;
        //Hatvhery hatchery=new Hatvhery();

        public void SaleRuiAmount(Object ob,Sales s)
        {
            if (Rui - s.fishAmount >= 0)
            {
                Rui = Rui - s.fishAmount;
                Console.WriteLine("Available Fish : " + Rui);
                //hatchery.hacheryamount(s.fishAmount);



            }

            else
                Console.WriteLine("Not Available");
            
        }
           
    }
}
