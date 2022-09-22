using CurrencyDenomination.ServiceRepository;
using System;

namespace CurrencyDenomination
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal productPrice, paidAmount, returnAmountFloat;

            ICDenomination _currencyDenomination = new CDenomination();

            try
            {
                Console.WriteLine("Please Enter The Product Price : ");
                productPrice = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Paid Amount : ");
                paidAmount = decimal.Parse(Console.ReadLine());

                if (paidAmount > productPrice)
                {
                    returnAmountFloat = paidAmount - productPrice;
                    _currencyDenomination.GetCurrencyDenominarion(returnAmountFloat);
                }
                else if(paidAmount==productPrice)
                {
                    Console.WriteLine("You have given product price. No change.");
                }
                else
                {
                    Console.WriteLine("Paid amount is less than Product amount, Please Enter Correct amount.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Below issue has been occured\n{0}", ex.Message);
            }
            Console.ReadLine();
        }
    }
}
