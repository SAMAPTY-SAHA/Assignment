using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class MarketInventory
    {

        //public static List<RuiFishType> ruifishList = new List<RuiFishType>();
        //public static List<KatlaFishType> katlafishList = new List<KatlaFishType>();
       // public static List<IlishFishType> IlishfishList = new List<IlishFishType>();

        public static List<RuiFishType> ruifishListRepo = new List<RuiFishType>();
        public static List<KatlaFishType> katlafishListRepo = new List<KatlaFishType>();
        public static List<IlishFishType> ilishfishListRepo = new List<IlishFishType>();

        // GenericRepository<Fish> GR = new GenericRepository<Fish>();
        GenericRepository<RuiFishType> GRRui = new GenericRepository<RuiFishType>();
        GenericRepository<KatlaFishType> GRKatla = new GenericRepository<KatlaFishType>();
        GenericRepository<IlishFishType> GRIlish = new GenericRepository<IlishFishType>();

        //  RuiRepo ruirepo = new RuiRepo();
        // KatlaRepo katlarepo = new KatlaRepo();
        //IlishRepo ilishrepo = new IlishRepo();










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

        // rui list method addd
        public void ruifishListMethod()
        {
            for (int i = 1; i <= 100; i++)
            {
                string ruiname = "Rui";
                String ruiweight = "3kg";
                RuiFishType ruifishtype = new RuiFishType(ruiname, ruiweight);
                // ruifishList.Add(ruifishtype);
                //ruirepo.add(ruifishtype);
                GRRui.add(ruifishtype);
                
            }
            //Console.WriteLine("rui fish method num : " + ruifishList.Count);
            //  Console.WriteLine("rui fish method num  repo : " + ruifishListRepo.Count);
            Console.WriteLine("rui fish method num  repo : " + GRRui.getall().Count);

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
            // int cnt = ruifishList.Count;

            //int cnt = ruifishListRepo.Count;
            int cnt = GRRui.getall().Count;

            //Console.WriteLine("Count : " + cnt);
            listrui = GRRui.getall().Count - s.fishAmount;
            //Console.WriteLine("Count : " + cnt + " " + "listui : " + listrui);
            


            for (int i = cnt-1 ; i >= (cnt - s.fishAmount); i--)
            {
                // ruifishList.RemoveAt(i);
                // Console.WriteLine("remove rui fish from list : " + i);
                //ruirepo.remove(i);
                GRRui.remove("rui",i);


            }

            //Console.WriteLine("Available in market inventory : " + ruifishList.Count);
            Console.WriteLine("Available in market inventory ruirepo : " + GRRui.getall().Count);


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
                    //ruifishList.Add(ruifishtype);
                    //ruirepo.add(ruifishtype);
                    GRRui.add(ruifishtype);


                }
                Console.WriteLine("New RUi COunt: "+ GRRui.getall().Count);
                

            }
           

        }

        public void katlafishListMethod()
        {
            for (int i = 1; i <= 100; i++)
            {
                string katlaname = "katla";
                String katlaweight = "3kg";
                KatlaFishType katlafishtype = new KatlaFishType(katlaname, katlaweight);
                //katlafishList.Add(katlafishtype);
                //katlarepo.add(katlafishtype);
                GRKatla.add(katlafishtype);
            }
            // Console.WriteLine("katla fish list amount : " + katlafishListRepo.Count);
            Console.WriteLine("katla fish list amount : " + GRKatla.getall().Count);
        }

        public void SaleKatlaAmount(Object ob, Sales s)
        {
            
            int cnt2 = GRKatla.getall().Count;
            //Console.WriteLine("Count : " + cnt);
            listkatla = GRKatla.getall().Count - s.fishAmount;
            //Console.WriteLine("Count : " + cnt + " " + "listui : " + listrui);



            for (int i = cnt2 - 1; i >= (cnt2 - s.fishAmount); i--)
            {
                //katlafishList.RemoveAt(i);

                //katlarepo.remove(i);
                // Console.WriteLine("remove rui fish from list : " + i);
                GRKatla.remove("katla", i);

            }

            Console.WriteLine("Available in market inventory katla fish : " + GRKatla.getall().Count);


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
                    //katlafishList.Add(katlafishtype);
                    // katlarepo.add(katlafishtype);
                    GRKatla.add(katlafishtype);
                }
                Console.WriteLine("New Katla COunt: " + GRKatla.getall().Count);


            }


        }
        public void IlishfishListMethod()
        {
            for (int i = 1; i <= 100; i++)
            {
                string Ilishname = "Iatla";
                String Ilishweight = "3kg";
                IlishFishType ilishfishtype = new IlishFishType(Ilishname, Ilishweight);
                //IlishfishList.Add(ilishfishtype);
                // ilishrepo.add(ilishfishtype);
                GRIlish.add(ilishfishtype);
            }
            Console.WriteLine("Ilish fish list amount : " + GRIlish.getall().Count);
        }

        public void SaleIlishAmount(Object ob, Sales s)
        {

            int cnt3 = GRIlish.getall().Count;
            //Console.WriteLine("Count : " + cnt);
            listIlish = GRIlish.getall().Count - s.fishAmount;
            //Console.WriteLine("Count : " + cnt + " " + "listui : " + listrui);



            for (int i = cnt3 - 1; i >= (cnt3 - s.fishAmount); i--)
            {
                //ilishfishListRepo.RemoveAt(i);
                // Console.WriteLine("remove rui fish from list : " + i);
                GRIlish.remove("ilish", i);

            }

            Console.WriteLine("Available in market inventory katla fish : " + GRIlish.getall().Count);


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
                    //IlishfishList.Add(Ilishfishtype);
                    //ilishrepo.add(Ilishfishtype);
                    GRIlish.add(Ilishfishtype);
                }
                Console.WriteLine("New Ilish COunt: " + GRIlish.getall().Count);


            }


        }


    }
}
