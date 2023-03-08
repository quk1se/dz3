using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace dz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 3 task
            string mail = "alexandrkalyan953@gmail.com";
            var regex = new Regex(@"^[a-zA-Z0-9_]{1,20}\@[a-zA-Z0-9_]{1,20}\.[a-zA-Z]{1,5}");
            Match match = regex.Match(mail);

            while(match.Success)
            {
                Console.WriteLine(match);
                match = match.NextMatch();
            }
            #endregion

            #region 4 task
            string twentyFourFormatTime = "22:59:59";
            var timeRegex = new Regex(@"^(?:[01]\d | 2[0 - 3])\:[0 - 59]\w\:[0 - 59]\w");
            Match match2 = timeRegex.Match(twentyFourFormatTime);
            // не могу понять почему не выводится время, если встваить на regix.com, то все работает(
            while (match2.Success)
            {
                Console.WriteLine(match2);
                match2 = match2.NextMatch();
            }
            #endregion

            #region 5 task (from presentation)
            string course = "Dollar to euro: 1 = 0.9427; Euro to dollar: 1 = 1.0608";
            var courseRegex = new Regex(@"\d = \d?\.\d{0,20}");

            Match match3 = courseRegex.Match(course);

            while (match3.Success)
            {
                Console.WriteLine(match3);
                match3 = match3.NextMatch();
            }

            #endregion
            Console.Read();

        }
        
    }
}
