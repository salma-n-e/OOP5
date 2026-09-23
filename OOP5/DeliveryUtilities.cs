using System;

namespace OOP04
{
    
    public static class DeliveryUtilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine("--------------------------------");
        }

        public static void PrintSystemTitle(string title)
        {
            PrintSeparator();
            Console.WriteLine($"{title}");
            PrintSeparator();
        }
    }
}