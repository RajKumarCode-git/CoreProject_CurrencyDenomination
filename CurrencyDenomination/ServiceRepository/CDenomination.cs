using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyDenomination.ServiceRepository
{
    public class CDenomination : ICDenomination
    {
        int temp, returnAmount, precision;
        public CDenomination()
        {
            temp = 0;
            returnAmount = 0;
            precision = 0;
        }
        public void GetCurrencyDenominarion(decimal returnAmountFloat)
        {
            

            returnAmount = (int)returnAmountFloat;
            precision = (int)((returnAmountFloat - returnAmount) * 100);

            Console.WriteLine("\nYour Change is :");

            temp = returnAmount / 100;
            returnAmount = returnAmount - (temp * 100);
            if (temp > 0)
            {
                Console.WriteLine("{0} x £100 ", temp);
            }

            temp = returnAmount / 50;
            returnAmount = returnAmount - (temp * 50);
            if (temp > 0)
            {
                Console.WriteLine("{0} x £50 ", temp);
            }

            temp = returnAmount / 10;
            returnAmount = returnAmount - (temp * 10);
            if (temp > 0)
            {
                Console.WriteLine("{0} x £10 ", temp);
            }

            temp = returnAmount / 5;
            returnAmount = returnAmount - (temp * 5);
            if (temp > 0)
            {
                Console.WriteLine("{0} x £5 ", temp);
            }

            temp = returnAmount / 2;
            returnAmount = returnAmount - (temp * 2);
            if (temp > 0)
            {
                Console.WriteLine("{0} x £2 ", temp);
            }

            temp = returnAmount / 1;
            returnAmount = returnAmount - (temp * 1);
            if (temp > 0)
            {
                Console.WriteLine("{0} x £1 ", temp);
            }
            if (precision > 0)
            {
                Console.WriteLine("1 x {0}p ", precision);
            }
        }
    }
}
