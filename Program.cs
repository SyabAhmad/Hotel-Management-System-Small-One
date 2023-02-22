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
        protected double discount;
        protected double totalPrice;
        protected double totalPriceWithDiscount;
        public void displayList()
        {

            Console.WriteLine("1: Chicken Pulao : " + chickenPulao + " PKR ");
            Console.WriteLine("2: Chicken Tikka : " + chickenTikka + " PKR ");
            Console.WriteLine("3: Mutton : " + mutton + " PKR ");
            Console.WriteLine("4: Haleem : " + haleem + " PKR ");
            Console.WriteLine("5: Rice : " + rice + " PKR ");
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
                    displayList();
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
            return (int)totalPriceWithDiscount;
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
            Console.WriteLine("1: PKR");
            Console.WriteLine("2: $$$");
            Console.WriteLine("3: INR");
            byte Choice1 = byte.Parse(Console.ReadLine());
            if (Choice1 == 1)
            {
                Console.WriteLine("Your bill is : " + totalPrice);
                Console.WriteLine("Your Discount is: " + discount);
                Console.WriteLine("After Discount Total Price is: " + totalPriceWithDiscount);

            } else if (Choice1 == 2)
            {
                Console.WriteLine("Your bill is : " + totalPrice/220 + " $ ");
                Console.WriteLine("Your Discount is: " + discount/220 + " $ ");
                Console.WriteLine("After Discount Total Price is: " + totalPriceWithDiscount/220 + "$");
            } else if (Choice1 == 3)
            {
                Console.WriteLine("Your bill is : " + totalPrice/3 + " INR ");
                Console.WriteLine("Your Discount is: " + discount / 220 + " INR ");
                Console.WriteLine("After Discount Total Price is: " + totalPriceWithDiscount / 220 + " INR ");
            }
            else
            {
                Console.WriteLine("Invalid arguments");
                displayBill();
            }
            //Console.WriteLine("Your bill is : " + totalPrice);
            //Console.WriteLine("Your Discount is: " + discount);
            //Console.WriteLine("After Discount Total Price is: " + totalPriceWithDiscount);
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
