using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class MarketInventory
    {

        

        public static List<RuiFishType> ruifishList = new List<RuiFishType>();
        public static List<KatlaFishType> katlafishList = new List<KatlaFishType>();
        public static List<IlishFishType> IlishfishList = new List<IlishFishType>();







        // public static  int Rui = 1000;
        Hatvhery hatchery=new Hatvhery();
        HatcheryInventory hatcheryInventory = new HatcheryInventory();
        Sales s = new Sales();
        public  int listrui=0;
        public int cnt1 = 0;
        public int listkatla = 0;
        public int cnt2 = 0;
        public int listIlish = 0;
        public int cnt3 = 0;


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
           

        }

        public void katlafishListMethod()
        {
            for (int i = 1; i <= 100; i++)
            {
                string katlaname = "katla";
                String katlaweight = "3kg";
                KatlaFishType katlafishtype = new KatlaFishType(katlaname, katlaweight);
                katlafishList.Add(katlafishtype);
            }
            Console.WriteLine("katla fish list amount : " + katlafishList.Count);
        }

        public void SaleKatlaAmount(Object ob, Sales s)
        {
            
            int cnt2 = katlafishList.Count;
            //Console.WriteLine("Count : " + cnt);
            listrui = katlafishList.Count - s.fishAmount;
            //Console.WriteLine("Count : " + cnt + " " + "listui : " + listrui);



            for (int i = cnt2 - 1; i >= (cnt2 - s.fishAmount); i--)
            {
                katlafishList.RemoveAt(i);
                // Console.WriteLine("remove rui fish from list : " + i);

            }

            Console.WriteLine("Available in market inventory katla fish : " + katlafishList.Count);


            if (listkatla <= 50)
            {
                //int temp = listrui + HatcheryInventory.hatcheryfishrui;
                hatchery.BuyKatlaAmount(s.fishAmount);
                int temp = listkatla + HatcheryInventory.hatcheryfishkatla;

                Console.WriteLine("Market Inventory Buy from hatchery amount : " + HatcheryInventory.hatcheryfishkatla);
                Console.WriteLine("Now available in Marketinventory : " + temp);
                for (int i = listkatla + 1; i <= temp; i++)
                {
                    string ruiname = "Katlaui";
                    String ruiweight = "3kg";
                    KatlaFishType katlafishtype = new KatlaFishType(ruiname, ruiweight);
                    katlafishList.Add(katlafishtype);
                }
                Console.WriteLine("New Katla COunt: " + katlafishList.Count);


            }


        }
        public void IlishfishListMethod()
        {
            for (int i = 1; i <= 100; i++)
            {
                string Ilishname = "Iatla";
                String Ilishweight = "3kg";
                IlishFishType ilishfishtype = new IlishFishType(Ilishname, Ilishweight);
                IlishfishList.Add(ilishfishtype);
            }
            Console.WriteLine("Ilish fish list amount : " + IlishfishList.Count);
        }

        public void SaleIlishAmount(Object ob, Sales s)
        {

            int cnt3 = IlishfishList.Count;
            //Console.WriteLine("Count : " + cnt);
            listIlish = IlishfishList.Count - s.fishAmount;
            //Console.WriteLine("Count : " + cnt + " " + "listui : " + listrui);



            for (int i = cnt3 - 1; i >= (cnt3 - s.fishAmount); i--)
            {
                IlishfishList.RemoveAt(i);
                // Console.WriteLine("remove rui fish from list : " + i);

            }

            Console.WriteLine("Available in market inventory katla fish : " + IlishfishList.Count);


            if (listIlish <= 50)
            {
                //int temp = listrui + HatcheryInventory.hatcheryfishrui;
                hatchery.BuyIlishAmount(s.fishAmount);
                int temp = listIlish + HatcheryInventory.hatcheryfishilish;

                Console.WriteLine("Market Inventory Buy from hatchery amount : " + HatcheryInventory.hatcheryfishilish);
                Console.WriteLine("Now available in Marketinventory : " + temp);
                for (int i = listIlish + 1; i <= temp; i++)
                {
                    string Ilishname = "Katlaui";
                    String Ilishweight = "3kg";
                    IlishFishType Ilishfishtype = new IlishFishType(Ilishname, Ilishweight);
                    IlishfishList.Add(Ilishfishtype);
                }
                Console.WriteLine("New Ilish COunt: " + IlishfishList.Count);


            }


        }


    }
}
