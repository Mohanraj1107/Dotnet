
using System;
using System.Collections.Generic;

namespace EnergyTechBillingSystem
{
    class Program
    {
        
        class Consumer
        {
            public string ConsumerID;
            public int Units;
            public int Type; 
            public double BaseCharge;
            public double Surcharge;
            public double Penalty;
            public double Discount;
            public double FinalBill;
        }

        static int Main()
        {
            Console.Write("Enter number of consumers: ");
            int N = int.Parse(Console.ReadLine());

            List<Consumer> consumers = new List<Consumer>();

            double totalRevenue = 0;
            double highestBill = 0;
            string highestBillID = "";

            int domesticCount = 0;
            int commercialCount = 0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"\nEnter details for consumer {i + 1}:");

                Console.Write("Consumer ID: ");
                string cid = Console.ReadLine();

                Console.Write("Units Consumed: ");
                int units = int.Parse(Console.ReadLine());

                Console.Write("Connection Type (1=Domestic, 2=Commercial): ");
                int type = int.Parse(Console.ReadLine());

                Consumer c = new Consumer();
                c.ConsumerID = cid;
                c.Units = units;
                c.Type = type;

              
                if (type == 1) domesticCount++;
                else commercialCount++;

                c.BaseCharge = CalculateBaseCharge(units, type);

                c.Surcharge = c.BaseCharge * 0.03;

                c.Penalty = (units > 500) ? 200 : 0;

                double totalBeforeDiscount = c.BaseCharge + c.Surcharge + c.Penalty;

                c.Discount = (totalBeforeDiscount > 2000) ? totalBeforeDiscount * 0.05 : 0;

                c.FinalBill = totalBeforeDiscount - c.Discount;

                consumers.Add(c);
                totalRevenue += c.FinalBill;

                if (c.FinalBill > highestBill)
                {
                    highestBill = c.FinalBill;
                    highestBillID = c.ConsumerID;
                }
            }

            Console.WriteLine("\n--- Individual Bills ---\n");

            foreach (var c in consumers)
            {
                Console.WriteLine(
                    $"{c.ConsumerID}  " +
                    $"{(c.Type == 1 ? "Domestic" : "Commercial")}  " +
                    $"Units:{c.Units}  " +
                    $"Base:₹{c.BaseCharge:F2}  " +
                    $"Surcharge:₹{c.Surcharge:F2}  " +
                    $"Penalty:₹{c.Penalty:F2}  " +
                    $"Discount:₹{c.Discount:F2}  " +
                    $"Final:₹{c.FinalBill:F2}"
                );
            }

            Console.WriteLine("\n--- Summary ---");
            Console.WriteLine($"Total Consumers: {N}");
            Console.WriteLine($"Total Revenue: ₹{totalRevenue:F2}");
            Console.WriteLine($"Highest Bill: {highestBillID} ₹{highestBill:F2}");
            Console.WriteLine($"Domestic: {domesticCount}   Commercial: {commercialCount}");
        }

        static double CalculateBaseCharge(int units, int type)
        {
            double rate = 0;

            if (type == 1) 
            {
                if (units <= 100) rate = 1.50;
                else if (units <= 300) rate = 2.50;
                else rate = 4.00;
            }
            else 
            {
                if (units <= 200) rate = 5.00;
                else if (units <= 500) rate = 6.50;
                else rate = 8.00;
            }

            return units * rate;
        }
    }
}

