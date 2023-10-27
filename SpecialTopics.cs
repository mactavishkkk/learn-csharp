using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    internal class SpecialTopics {
        static void Main(string[] args) {
            // Var

            var x = 10;
            var y = 10.0;
            var z = "10";

            // Switch-Case

            var number = 10;

            switch (number) {
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(3);
                    break;
                default:
                    Console.WriteLine(number);
                    break;
            }

            // Ternary Conditional

            int age = 16;
            string warning = age > 18 ? "Maior de idade" : "Menor de idade";

            Console.WriteLine(warning);

            // String Functions

            string original = "abc DEF HjK lmN o PQ rs T u v wxyZ   ";
            string ORIGINALMAX = original.ToUpper();
            string originalmin = original.ToLower();
            string OriginalTrim = original.Trim();
            int index = original.IndexOf("bc");
            int indexTwo = original.LastIndexOf("lm");

            string or_iginal = original.Substring(5);
            string or_igi_nal = original.Substring(5, indexTwo);

            string origin = original.Replace("a", "x");

            bool emptyString = String.IsNullOrEmpty(original);
            bool emptyStringTwo = String.IsNullOrWhiteSpace(original);

            // DateTime

            DateTime dateTime = DateTime.Now;
            long dateTicks = dateTime.Ticks;

            DateTime dateOne = new DateTime(2018, 11, 25);
            DateTime dateTwo = new DateTime(2022, 02, 17, 22, 03, 45);
            DateTime dateThree = DateTime.Parse("2000-08-15");
            DateTime dateFour = DateTime.Parse("2000-08-15 20:05:45");
            DateTime dateFive = DateTime.Parse("27/10/2023");
            DateTime dateSix = DateTime.ParseExact("2000-08-15", "yyyyESPmmESPdd", CultureInfo.InvariantCulture);

            // TimeSpan

            TimeSpan timeSpan = new TimeSpan();
            TimeSpan timeSpanOne = new TimeSpan(0, 1, 30);
            TimeSpan timeSpanTwo = new TimeSpan(900000000L); // Ticks
            TimeSpan timeSpanThree = new TimeSpan(2, 0, 1, 30);
            TimeSpan timeSpanFour = new TimeSpan(2, 0, 1, 30, 350);

            TimeSpan timeSpanFrom = TimeSpan.FromDays(1.5);

            // DateTimeKind

            DateTime dateOneKindLocal = dateOne.ToLocalTime(); // print to user
            DateTime dateOneKindUtc = dateOne.ToUniversalTime(); // data persist
        }
    }
}
