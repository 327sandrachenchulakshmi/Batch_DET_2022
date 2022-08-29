using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    
        public class Classmain1
        {
            public static Student Student { get; private set; }

            public static void Main()
            {
                ScienceStudent Student = new ScienceStudent { regno = 17, Name = "keerthi" };
                ScienceStudent sciencesubject = new ScienceStudent { physics = 51, chemistry =57 , maths = 66 };
                CommerceStudent Commercessubject = new CommerceStudent { economices = 54, accounts = 78, banking = 54 };

                Console.WriteLine(sciencesubject.GetAvgMarks());
                Console.WriteLine(Commercessubject.GetAvgMarks());
            }
        }
    
}
