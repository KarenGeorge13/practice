using System;
using System.Text.RegularExpressions;

namespace Z08_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Я хочу встретиться с вами в 12:59:53";
            Console.WriteLine(s);
            string pattern = @"\d{2}:\d{2}:\d{2}";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(s);
            foreach (Match match in matches) 
            {
                string[] textDate  = match.Value.Split(':');
                int hh = Convert.ToInt32(textDate[0]);
                int mm = Convert.ToInt32(textDate[1]);
                int ss = Convert.ToInt32(textDate[2]);
                if (hh >= 0 && hh < 24 && mm >= 0 && mm < 60 && ss >= 0 && ss < 60)  
                {
                    if (ss >= 30) 
                    {
                        mm++;
                    }
                    TimeSpan time = new TimeSpan(hh, mm, ss);
                    s = regex.Replace(s, time.ToString(@"hh\:mm"));
                }
            }
            Console.WriteLine(s);
        }
    }
}
