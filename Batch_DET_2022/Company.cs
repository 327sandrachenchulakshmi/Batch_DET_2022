using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public Companymanager Manager { get; set; }
        public string Print()
        {
            return $"Name={Name},Address={Address},Phone={Phone},Website={Website},Manager={Manager.Print()}";
        }
    }
}
 






