using ConsoleApp19;
using ConsoleApp20;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Batch_DET_2022.person;

namespace Batch_DET_2022
{
    class MyClass
    {
        public static void Main()
        {
            /* try
             {
                /* Emp m = new Manager(4671, "Karthika", new DateTime(2005, 5, 10), "techtrng", 10);  //default constructor
                                                                                                    // Console.WriteLine(m.Print());

                 Emp m1 = new Manager(2345, "Jeeva", new DateTime(2010, 1, 14), "PEMS", 450);
                 // Console.WriteLine(m1.Print());  //base class ref can point to derived object

                 Emp e1 = new Emp(1, "Jiyana", new DateTime(2020, 1, 5));
                 //Console.WriteLine(e1.Print());

                 Console.WriteLine("enter empid b.w 1001 - 25000");
                 int id = Convert.ToInt32(Console.ReadLine());
                 if (id < 1001 || id > 25000)
                     throw new invalidemplexception("Entered empid is not in the range...");

                 Console.WriteLine("enter emp name");
                 string name = Console.ReadLine();

                 Console.WriteLine("enter doj");
                 DateTime doj = DateTime.Parse(Console.ReadLine());

                 Emp e2 = new(id, name, doj);


                 List<Emp> list = new List<Emp>();
                 list.Add(m);
                 list.Add(m1);
                 list.Add(e1);
                 foreach (Emp x in list)
                     Console.WriteLine(x.Print());
             }
             catch (invalidemplexception e)
             {
                 Console.WriteLine(e.Message);
             }
             catch (Exception e)
             { }
            */
            //Companymanager m = new Companymanager { Name = "Balaji", Surname = "R", Phone = "987456321" };
            //Company Company = new Company { Name = "SSL", Address = "Global ", Manager = m, Phone = "987456321", Website = "sonata-software.com" };
            //Console.WriteLine(Company.Print());
            //try
            //{
            //    Console.WriteLine("enter age b.w 0-100");
            //        int age = Convert.ToInt32(Console.ReadLine());
            //    if (age > 100)
            //        throw new InvalidAgeException("enter age is invalid---");
            //}
            //catch (InvalidAgeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{ }
            try
            {
                Person t = new Person("Tony", "Stark", "tonystark@stark.com", new DateOnly(1988, 05, 04));
                int byear = t.BirthYear();
                if (byear < 1900 || byear > 2022)
                {
                    throw new InvalidEmpIdException("ENTER VALID BIRTH YEAR");
                }
                string r = t.GetSunSign();
                string s = t.ChineseZodiac();
                string w = t.IsAdult();
                string b = t.BDayStatus();
                string u = t.DefaultUsername();
                string n = t.GetInfo();
                Console.WriteLine($"NAME = {n}");
                Console.WriteLine($"Sun Sign = {r}");
                Console.WriteLine($"Chinese Zodiac = {s}");
                Console.WriteLine($"Age Status = {w}");
                Console.WriteLine($"Birthday Status = {b}");
                Console.WriteLine($"Default Username = {u}");
            }
            catch (InvalidEmpIdException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
    
}
