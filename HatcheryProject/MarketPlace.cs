using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class MarketPlace
    {
        public delegate void SaleDelegate(Object ob,Sales s);
        public event SaleDelegate SaleEvent;



        public delegate void BuyDelegate(Object ob, Sales s);
        public event BuyDelegate BuyEvent;

        StroreMarket storemarket = new StroreMarket();



        public void saleMethod(int amount)
        {
            OnSaleDelegateEvent(amount);
           // storemarket.ruifishremove();
        }

        protected virtual void  OnSaleDelegateEvent(int fishAmount)
        {
            if(SaleEvent != null)
            {
                  SaleEvent(this,new Sales(){ fishAmount=fishAmount });
            }
        }

        public void BuyMethod(int amount)
        {
            OnBuyDelegateEvent(amount);
        }

        protected virtual void  OnBuyDelegateEvent(int fishAmount)
        {
            if(BuyEvent != null)
            {
                  BuyEvent(this,new Sales(){ fishAmount=fishAmount });
            }
        }


        


        


    }
    class Sales : EventArgs
    {
        public int  fishAmount { set; get; }
    }
}
