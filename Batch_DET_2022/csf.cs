using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class csf
    {
        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($" hai {name}"); };



            Action<string, string> action1 = (string s1, string s2) =>
            { Console.WriteLine($" hai {s1}," + $"you said {s2}"); };






            action.Invoke("keerthi");
            action1.Invoke("keerthi", "am in nellore");


        }
    }
}
