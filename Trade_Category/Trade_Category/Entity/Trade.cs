using System;
using System.Collections.Generic;
using System.Text;

namespace Trade_Category.Entity
{
    class Trade : ITrade
    {
        public double value;
        public string clientSector;
        public DateTime nextPaymentDate;

        public double Value
        {
            get
            {
                return value;
            }

        }
        public string ClientSector
        {
            get
            {
                return clientSector;
            }

        }
        public DateTime NextPaymentDate
        {
            get
            {
                return nextPaymentDate;
            }

        }

        public Trade()
        {
            value = 0;
            clientSector = "";
            nextPaymentDate = DateTime.Today;

        }
    }
}
