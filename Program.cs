using System;

namespace CSHRG444
{
    class Program
    {
        static void Main(string[] args)
        {
            (double payment, double purchase) = CheckPayment();
            double change = payment - purchase;

            if (payment > purchase)
            {

                Console.WriteLine($"Your change due is:{change} ");
                change = changeDue(change, 20.0, "twenties");
                change = changeDue(change, 10.0, "tens");
                change = changeDue(change, 5.0, "fives");
                change = changeDue(change, 1.0, "ones");
                change = changeDue(change, 0.25, "quarters");
                change = changeDue(change, 0.10, "dimes");
                change = changeDue(change, 0.05, "nickels");
                change = changeDue(change, 0.01, "pennies");
            }

        }

        static (double, double) CheckPayment()
        {
            double purchase = Convert("Enter purchase amount");
            double payment = Convert("Enter First payment amount");


            while (payment < purchase)
            {
                Console.WriteLine("Not enough money");
                payment = Convert("Invalid Amount. Reenter new amount");
            }

            if (payment == purchase)
            {
                Console.WriteLine("Thanks my guy");
            }
            return (payment, purchase);
        }

        static double Convert(string prompt)
        
       
        {
            double NewAmount = 0;
            bool k = false;
            
             while (k == false)
            {
                try
                {
                    if (NewAmount <= 0)
                    {
                        Console.WriteLine(prompt);
                        NewAmount = double.Parse(Console.ReadLine());
                    }

                    else
                    {
                        k = true;
                    }


                }

                catch
                {
                    Console.WriteLine("I need a number");
                }
            }

                return NewAmount;
        }



        static double changeDue(double payment, double denomination, string name)
        {
            int changeDue = (int) (payment / denomination);
            if (changeDue > 0)
            {
                Console.WriteLine($"Your change is {changeDue} of {name}");

            }
            
            

            return Math.Round(payment % denomination, 2); 
        }
           
        
    }
}
