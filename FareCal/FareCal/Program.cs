//By: Anuj

using System;

namespace FareCal
{
    class Program
    {
        const int base_charge = 35;
        const int charge_per_km = 7;
        const int charge_per_minute = 1;

        
        static void Main(string[] args)
        {
            Console.WriteLine("Write the ride-start time in HH:MM and 24 HRS format");
            String startTime = Console.ReadLine();

            Console.WriteLine("Write the ride-end time in HH:MM and 24 HRS format");
            String endTime = Console.ReadLine();

            Console.WriteLine("Write the travelled distance in 123KM or 123M format");
            String distance = Console.ReadLine();

            double time_taken = timer(startTime, endTime);

            Console.WriteLine(calculate(distance, time_taken) + " Rupees");
        }
        // calculate method is for calculate the total payable fare  
        static double calculate(String s, double time)
        {
            double total_fare = 0;

            // two conditions have been checked for distance If it is in Kilometer or meter.
            if (s.Contains("KM"))
            {
                string str = (s.Substring(0, (s.Length - 2)));
                double distance = int.Parse(str);
                Console.Write("Payable amount after getting the Valentine's Day discount is :");
                total_fare = base_charge + (distance * charge_per_km) + (time * charge_per_minute);
            }
            else if (s.Contains("M"))
            {
                string str = (s.Substring(0, (s.Length - 1)));
                double distance = int.Parse(str);
                Console.Write("Payable amount after getting the Valentine's Day discount is :");
                total_fare = base_charge + ((double)(distance / 1000) * charge_per_km) + (time * charge_per_minute);
            }
            else
                Console.WriteLine("plese write the distance in correct format");

            //Discount of 25% upto Rs 50
            double payable_ammount = 0;
            double temp = total_fare * 0.25;
            if (temp < 50)
                payable_ammount = total_fare - temp;
            else
                payable_ammount = total_fare - 50;
            return payable_ammount;
            
        }
      // timer method convers the given input time in minutes
       static double timer(string s1,string s2)
        {
            TimeSpan ts = TimeSpan.Parse(s1);
            double startTime = ts.TotalMinutes;
            TimeSpan ts1 = TimeSpan.Parse(s2);
            double endTime = ts1.TotalMinutes;

            return endTime - startTime;
        }      
    }
}









