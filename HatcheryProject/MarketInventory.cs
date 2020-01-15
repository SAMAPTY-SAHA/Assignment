using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class MarketInventory
    {

        // public delegate void neededAmountFromHatcheryIn(int neededamount);
        //public event neededAmountFromHatcheryIn neededAmountFromHatcheryEvent;
        // List<RuiFishType> ruifishList = new List<RuiFishType>();

            // for implement single ton pattern 
            /*private MarketInventory()
            {

            }
        private static MarketInventory instance = null;
        public static MarketInventory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MarketInventory();
                }
                return instance;
            }
        }*/

        public static List<RuiFishType> ruifishList = new List<RuiFishType>();







       // public static  int Rui = 1000;
        Hatvhery hatchery=new Hatvhery();
        HatcheryInventory hatcheryInventory = new HatcheryInventory();
        Sales s = new Sales();
        public  int listrui=0;
        public int cnt = 0;
 

        public void ruifishListMethod()
        {
            for (int i = 1; i <= 100; i++)
            {
                string ruiname = "Rui";
                String ruiweight = "3kg";
                RuiFishType ruifishtype = new RuiFishType(ruiname, ruiweight);
                ruifishList.Add(ruifishtype);
                
            }
            Console.WriteLine("rui fish method num : " + ruifishList.Count);
        }


        public void SaleRuiAmount(Object ob,Sales s)
        {
            /* if (Rui - s.fishAmount >= 0)
             {
                 Rui = Rui - s.fishAmount;
                 Console.WriteLine("Available Fish : " + Rui);
                 //hatchery.hacheryamount(s.fishAmount);
             }

             else if(Rui<=0)
             {

                 Rui = Rui + HatcheryInventory.hatcheryfish;
                 Console.WriteLine("MarketInventory Buy from Hatchery amount : " + Rui);
             }*/
            int cnt = ruifishList.Count;
            //Console.WriteLine("Count : " + cnt);
            listrui = ruifishList.Count - s.fishAmount;
            //Console.WriteLine("Count : " + cnt + " " + "listui : " + listrui);
            


            for (int i = cnt-1 ; i >= (cnt - s.fishAmount); i--)
            {
                ruifishList.RemoveAt(i);
                // Console.WriteLine("remove rui fish from list : " + i);

            }
            //ruifishList.RemoveRange(listrui-1, cnt-1);




            //Console.WriteLine("Available fish : " + listrui);
            Console.WriteLine("Available in market inventory : " + ruifishList.Count);

            
            if (listrui<=50)
            {
                //int temp = listrui + HatcheryInventory.hatcheryfishrui;
                hatchery.BuyRuiAmount(s.fishAmount);
                int temp = listrui + HatcheryInventory.hatcheryfishrui;

                Console.WriteLine("Buy from hatchery amount : " + HatcheryInventory.hatcheryfishrui);
                Console.WriteLine("Now available in Marketinventory : " + temp);
                for(int i=listrui+1;i<=temp;i++)
                {
                    string ruiname = "Rui";
                    String ruiweight = "3kg";
                    RuiFishType ruifishtype = new RuiFishType(ruiname, ruiweight);
                    ruifishList.Add(ruifishtype);
                }
                Console.WriteLine("New RUi COunt: "+ruifishList.Count);
                

            }
           // Console.WriteLine("New RUi COuntttttttt: " + ruifishList.Count);

        }
           
    }
}
