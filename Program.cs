using System;
namespace HMSystem
{
    class displayInformation
    {
        protected int chickenPulao = 1200;
        protected int chickenTikka = 1300;
        protected int mutton = 500;
        protected int haleem = 1400;
        protected int rice = 700;
        protected int choice;
        protected int quantity;
        protected int discount;
        protected int totalPrice;
        protected int totalPriceWithDiscount;
        public void displayList()
        {

            Console.WriteLine("1: Chicken Pulao");
            Console.WriteLine("2: Chicken Tikka");
            Console.WriteLine("3: Mutton");
            Console.WriteLine("4: Haleem");
            Console.WriteLine("5: Rice");
            Console.WriteLine("Enter Responed with Item number Only (1 for Chicken Pulao)");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    chickenPulaoPanel();
                    break;
                case 2:
                    chickenTikkaPanel();
                    break;
                case 3:
                    muttonPanel();
                    break;
                case 4:
                    haleemPanel();
                    break;
                case 5:
                    ricePanel();
                    break;
                default:
                    Console.WriteLine("Invalid arguments");
                    break;
            }


        }
        int getQuantity()
        {
            Console.WriteLine("Enter Quantity Here: ");
            quantity = int.Parse(Console.ReadLine());
            return quantity;
        }
        int calculation(int value)
        {
            
            totalPrice = quantity*value;
            totalPriceWithDiscount = totalPrice;
            if (totalPriceWithDiscount >= 1200 || totalPriceWithDiscount <=2200)
            {
                discount = 150;
                totalPriceWithDiscount -= discount;
            }else if(totalPriceWithDiscount >= 2500 || totalPriceWithDiscount <= 4000)
            {
                discount = 220;
                totalPriceWithDiscount -= discount;
            }else if(totalPriceWithDiscount > 4000)
            {
                discount = 550;
                totalPriceWithDiscount -= discount;
            }
            else
            {
                discount = 50;
                totalPriceWithDiscount -= discount;
            }
            return totalPriceWithDiscount;
        }
        void chickenPulaoPanel()
        {
            getQuantity();
            calculation(chickenPulao);
            Console.WriteLine("You Order: Chicken Pulao" + " on " + chickenPulao + " RS");
        }

        void chickenTikkaPanel()
        {
            getQuantity();
            calculation(chickenTikka);
            Console.WriteLine("You Order: Chicken Tikka" + " on " + chickenTikka + " RS");
        }
        void muttonPanel()
        {
            getQuantity();
            calculation(mutton);
            Console.WriteLine("You Order: Mutton" + " on " + mutton + " RS");

        }
        void haleemPanel()
        {
            getQuantity();
            calculation(haleem);
            Console.WriteLine("You Order: Haleem" + " on " + haleem + " RS");
        }
        void ricePanel()
        {
            getQuantity();
            calculation(rice);
            Console.WriteLine("You Order: Rice" + " on " + rice + " RS");
        }
        public void displayBill()
        {
            Console.WriteLine("Your bill is : " + totalPrice);
            Console.WriteLine("Your Discount is: " + discount);
            Console.WriteLine("After Discount Total Price is: " + totalPriceWithDiscount);
        }
    }
    class HManagementSystem: displayInformation
    {
        
        static void Main(string[]args)
        {
            displayInformation display1 = new displayInformation();
            display1.displayList();
            HManagementSystem system = new HManagementSystem();
            display1.displayBill();
        }
    }
}