using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Hatvhery
    {
        public void BuyRuiAmount(int saleFish)
        {
                     
            MarketPlace mp = new MarketPlace();
            //MarketInventory mi = new MarketInventory();
            HatcheryInventory hatcheryInventory = new HatcheryInventory();

            mp.BuyEvent += hatcheryInventory.BuyAmount;
            mp.BuyMethod(saleFish);

        }



    }




}


