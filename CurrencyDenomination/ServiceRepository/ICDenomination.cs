using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyDenomination.ServiceRepository
{
    interface ICDenomination
    {
        void GetCurrencyDenominarion(decimal returnAmountFloat);
    }
}
