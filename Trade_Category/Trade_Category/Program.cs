using System;
using System.Collections.Generic;
using System.Globalization;
using Trade_Category.Entity;

namespace Trade_Category
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Trade> ts = new List<Trade>();

            DateTime aTime = new DateTime();
            int quant = 0;


            aTime = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
            quant = int.Parse(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                Trade t = new Trade();
                string a = Console.ReadLine();
                string[] aList = a.Split(" ");

                t.value = Double.Parse(aList[0]);
                t.clientSector = aList[1];
                t.nextPaymentDate = DateTime.ParseExact(aList[2], "MM/dd/yyyy", CultureInfo.InvariantCulture);
                ts.Add(t);
            }

            foreach (Trade tr in ts)
            {
                TimeSpan tms = aTime.Subtract(tr.NextPaymentDate);
                if (tr.Value > 1000000 && tr.ClientSector == "Public")
                {
                    Console.WriteLine("MEDIUMRISK");
                }
                if (tr.Value > 1000000 && tr.ClientSector == "Private")
                {
                    Console.WriteLine("HIGHRISK");
                }
                if (tms.Days > 30)
                {
                    Console.WriteLine("EXPIRED");
                }
                
            }

            //Console.WriteLine("Value: " + t.Value);
            //Console.WriteLine("Sector: " + t.ClientSector);
            //Console.WriteLine("Payment Date: " + t.NextPaymentDate);
        }
    }
}
