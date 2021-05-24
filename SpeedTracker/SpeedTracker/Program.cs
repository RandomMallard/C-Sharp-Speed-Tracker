using System;

namespace SpeedTracker
{
    class Program
    {

        static void Main(string[] args)
        {

            //Defining Variables

            double TimeInZoneSecs = 0;
            double TimeInZoneHours = 0;
            double ZoneLength = 0;
            double STon = 0;
            double SpeedLimitKMH = 0;
            double SpeedLimitMPH = 0;
            double SpeedKMH = 0;
            double SpeedMPH = 0;
            double SpeedConverter = 1.609;
            double SpeedDiffKMH = 0;
            double SpeedDiffMPH = 0;

            //User Interface

            Console.WriteLine("Welcome to the speed tracker!");
            Console.WriteLine("Press 1 to use the speed tracker!");
            Console.WriteLine("Press 0 to quit!");
            Console.WriteLine("Enter your choice:");
            STon = Convert.ToInt32(Console.ReadLine());

            if(STon == 0)
            {
                Console.WriteLine("Goodbye");
            }

            else if(STon == 1)
            {
                //The main Speed Tracker program itself

                Console.WriteLine("How long (in seconds) was the car in the zone)? Type here:");
                TimeInZoneSecs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How long is the zone (in KM)? Type here:");
                ZoneLength = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the speed limit (in KMH) for this zone? Type here");
                SpeedLimitKMH = Convert.ToInt32(Console.ReadLine());

                //Finds the Speed Limit in MPH

                SpeedLimitMPH = SpeedLimitKMH / SpeedConverter;

                Console.WriteLine("" +
                    "" +
                    "");
                Console.WriteLine("Speed Limit in MPH = " + SpeedLimitMPH);
                Console.WriteLine("");

                //Finds the avergae speed in KMH

                TimeInZoneHours = TimeInZoneSecs / 3600;

                SpeedKMH = ZoneLength / TimeInZoneHours;

                SpeedMPH = SpeedKMH / SpeedConverter;

                Console.WriteLine("The car's speed in KMH is " + SpeedKMH + " kilometres per hour");
                Console.WriteLine("The car's speed in MPH is " + SpeedMPH + " miles per hour" + "" +
                    " ");
                Console.WriteLine("");

                //Compares to see if the car is breaking the speed limit

                if (SpeedKMH > SpeedLimitKMH)
                {
                    SpeedDiffKMH = SpeedKMH - SpeedLimitKMH;
                    SpeedDiffMPH = SpeedMPH - SpeedLimitMPH;
                    Console.WriteLine("The car is travelling " + SpeedDiffKMH + " KM/H over the speed limit");
                    Console.WriteLine("The car is travelling " + SpeedDiffMPH + " miles per hour over the speed limit");
                }
                else if (SpeedLimitKMH > SpeedKMH)
                {
                    SpeedDiffKMH = SpeedLimitKMH - SpeedKMH;
                    SpeedDiffMPH = SpeedLimitMPH - SpeedMPH;
                    Console.WriteLine("The car is travelling " + SpeedDiffKMH + " KM/H below the speed limit");
                    Console.WriteLine("The car is travelling " + SpeedDiffMPH + " miles per hour below the speed limit");
                }
                else if(SpeedKMH == SpeedLimitKMH)
                {
                    Console.WriteLine("The car is travelling exactly at the speed limit");
                }
                else
                {
                    Console.WriteLine("Error");
                }



            }

            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
