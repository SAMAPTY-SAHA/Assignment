using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class KatlaRepo : KatlaInterface
    {
        public void add(KatlaFishType katlaFishType)
        {
            MarketInventory.katlafishListRepo.Add(katlaFishType);
        }

        public List<RuiFishType> getRuiall()
        {
            throw new NotImplementedException();
        }

        public void remove(int x)
        {
            MarketInventory.katlafishListRepo.RemoveAt(x);
        }
    }
}
