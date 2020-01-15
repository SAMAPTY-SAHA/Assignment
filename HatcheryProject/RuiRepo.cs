using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class RuiRepo : RuiInterface
    {
       // public static List<RuiFishType> ruifishList = new List<RuiFishType>();
        public void add(RuiFishType ruiFishType )
        {

           
                MarketInventory.ruifishListRepo.Add(ruiFishType);
            
                      
        }

        public List<RuiFishType> getRuiall()
        {
            return MarketInventory.ruifishListRepo;
        }

        public void remove(int x)
        {

            MarketInventory.ruifishListRepo.RemoveAt(x);
          
        }

    }
}
