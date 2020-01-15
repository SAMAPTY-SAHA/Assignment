using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class IlishRepo : IlishInterface
    {
        public void add(IlishFishType ilishFishType)
        {
            MarketInventory.ilishfishListRepo.Add(ilishFishType);
        }

        public List<IlishFishType> getRuiall()
        {
            throw new NotImplementedException();
        }

        public void remove(int x)
        {
            MarketInventory.ilishfishListRepo.RemoveAt(x);
        }
    }
}
