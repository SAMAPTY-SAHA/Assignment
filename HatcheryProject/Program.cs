using System;
using System.Threading;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int fish;
            //Console.WriteLine("Enter fish num : ");
            //fish = Convert.ToInt32(Console.ReadLine());

            //MarketPlace mp = new MarketPlace();
            //MarketInventory mi = new MarketInventory();

            //mp.SaleEvent += mi.SaleRuiAmount;
            //mp.saleMethod(fish);
            MarketInventory mi = new MarketInventory();
            //FishTank fishTank = new FishTank();

            //Thread thread = new Thread(new ThreadStart(fishTank.generatefish));
            //thread.Start();

            mi.ruifishListMethod();
            mi.katlafishListMethod();
            while (true)
            {

                User user = new User();
                user.userNeed();


               


            }


        }
       

    }
}
