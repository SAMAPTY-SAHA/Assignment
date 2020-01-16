using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class GenericRepository<T> : GeneralInterface<T> where T : Fish
    {
        //RuiFishType rui = new RuiFishType();
        public void add(T obj)
        {
            if (typeof(T).Equals(typeof(RuiFishType)))
            {
                //RuiFishType = (RuiFishType)(object);
                //Do some operation
                MarketInventory.ruifishListRepo.Add((RuiFishType)(Object)obj);
            }

            else if(typeof(T).Equals(typeof(KatlaFishType)))
            {
                MarketInventory.katlafishListRepo.Add((KatlaFishType)(Object)obj);
            }
            else if(typeof(T).Equals(typeof(IlishFishType)))
            {
                MarketInventory.ilishfishListRepo.Add((IlishFishType)(Object)(obj));
            }
            
        }

        public List<RuiFishType> getRuiall()
        {
            throw new NotImplementedException();
        }

        public void remove(string objname,int x)
        {
            if (objname=="rui")
            {
                MarketInventory.ruifishListRepo.RemoveAt(x);
            }
            else if (objname=="katla")
            {
                MarketInventory.katlafishListRepo.RemoveAt(x);
            }
            else if (objname=="ilish")
            {
                MarketInventory.ilishfishListRepo.RemoveAt(x);
            }

        }
        
    }
}
