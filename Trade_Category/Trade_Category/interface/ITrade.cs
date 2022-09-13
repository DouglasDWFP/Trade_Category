using System;
using System.Collections.Generic;
using System.Text;

namespace Trade_Category
{
    interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
        DateTime NextPaymentDate { get; }


    }
}
