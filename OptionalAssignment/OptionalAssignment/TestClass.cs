using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class TestClass
    {
        public static void Main()
        {
            //testing the App Tag Interpreter

            OptionalAssignment optionalAssignment = new OptionalAssignment();
            Console.WriteLine(optionalAssignment.AppTagInterpreter("<app></app></app><app><app>"));


            //practicing dates & strings

            string text = "Hello World!";
            string[] array = text.Split(" ");

            foreach (var word in array)
            {
                Console.WriteLine(word);
            }

            string joined = string.Join("@", array);
            Console.WriteLine(joined);

            TimeSpan time = new TimeSpan(1, 60, 60);
            Console.WriteLine(time);

            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTimeOffset dateOffsetNow = DateTimeOffset.Now;
            DateTimeOffset dateOffsetUtcNow = DateTimeOffset.UtcNow;

            TimeZone localZone = TimeZone.CurrentTimeZone;

            Console.WriteLine("Standard time name:" + localZone.StandardName);
            Console.WriteLine("Daylight saving time name:" + localZone.DaylightName);

            CultureInfo cultureInfo = new CultureInfo("ro-RO", false);
            Console.WriteLine($"Culture: {cultureInfo.DisplayName}");
            CultureInfo cultureInfo2 = new CultureInfo("en-US", false);
            Console.WriteLine("Culture " + cultureInfo2.NativeName);


        }
    }
}
