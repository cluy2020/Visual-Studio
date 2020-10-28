

// C# program to convert seconds 
// into days, hours,minutes,seconds
using System;

namespace Complex_Calculations
{
    class Program
    {
        static void ConvertSectoDay (int n)
        {
            int day = n / (24 * 3600);

            n = n % (24 * 3600);
            int hour = n / 3600;

            n %= 3600;
            int minutes = n / 60;

            n %= 60;
            int seconds = n;

            Console.WriteLine(day + " "
                  + "days " + hour + " "
              + "hours " + minutes + " "
            + "minutes " + seconds + " "
                            + "seconds ");
        }

        // Driver code  
        public static void Main()
        {

            // Given n is in seconds 
            int n = 129600;

            ConvertSectoDay(n);
        }
    }

    // This code is contributed by vt_m. 

}
    

 
  
