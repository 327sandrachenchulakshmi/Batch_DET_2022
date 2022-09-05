using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Batch_DET_2022.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace Batch_DET_2022
{
    internal class databaseFirstapproach
    {
        //public static void Main()
        //{

        //}
        static void Main(string[] args)
        {
            //GetAllEmpDetails();
            //GetEmpDetailByID();
            // DeleteEmployee();
            //UpdateEmployee();
            //AddNewEmployee();
            //GetEmpdetails();
            //GetEmpdetailsmp();
            //GetEmployeeDetails();
            //RemovingEmpUsingID();
            CallStoredinsert();
            Console.WriteLine();
        }
        //private static void DeleteEmployee()
        //private static void UpdateEmployee()
        //{

        //    var ctx = new TrainingContext();


        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 7499;
        //        employee.Ename = "sandra";
        //        employee.Sal = 3000;
        //        employee.Deptno = 30;
        //        employee.Job = "marketing";
        //        ctx.Update(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("update employee");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);

        //        throw;

        //    }
        //}
        //private static void GetEmpdetails()
        //{
        //    var ctx = new TrainingContext();
        //    var employees = ctx.Emps.FromSqlRaw("GetallEmpsDetails").ToList();
        //    foreach (var emp in employees)
        //    {
        //        Console.WriteLine(emp.Ename);
        //    }
        //}




        //private static void AddNewEmployee()
        //{
        //    var ctx = new TrainingContext();


        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 279;
        //        employee.Ename = "keerthi";
        //        employee.Sal = 1000;
        //        employee.Deptno = 30;
        //        employee.Job = "trainer";
        //        ctx.SaveChanges();
        //        Console.WriteLine("New employee added");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        //private static void GetEmpDetailByID()

        //{
        //    var ctx = new TrainingContext();
        //    var emp = ctx.Emps.Where(e=> e.Empno == 7499).SingleOrDefault();


        //        Console.WriteLine(emp.Ename + "   " + emp.Sal + "  " + emp.Job);

        //}
        //private static void GetAllEmpDetails()
        //{
        //    var ctx = new TrainingContext();
        //    var emps = ctx.Emps;
        //    foreach(var emp in emps)
        //    {
        //        Console.WriteLine(emp.Ename + "   " + emp.Sal);
        //    }
        //}
        //private static void GetEmpdetailsmp()
        //{
        //    var ctx = new TrainingContext();
        //    var employee = ctx.Emps.FromSqlRaw("GetAllEmpsDetails @p0", 7521).ToList();
        //    foreach (var emp in employee)
        //    {
        //        Console.WriteLine(emp.Ename);
        //    }
        //}


        //private static void RemovingEmpUsingID()
        //{
        //    var ctx = new TrainingContext();
        //    var eno = 2979;
        //    var RowsAffected = ctx.Emps.FromSqlRaw($"GetAllEmpsDetails {eno}");

        //    Console.WriteLine($"no of Rows Affected {RowsAffected}");
        //}






        private static void CallStoredinsert()
        {
            var ctx = new TrainingContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@Empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 7566
                        },

                             new SqlParameter() {
                                ParameterName = "@newname",
                                SqlDbType =  System.Data.
                                SqlDbType.VarChar,
                                Size = 100,
                                Direction = System.Data.
                                ParameterDirection.Input,
                                Value = "lucky"},

                              

                           };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("updateNAMES @Empno, @newname", param);
                Console.WriteLine("Inserted");
            }
            catch (Exception ex)
            {

                throw;
            }


            Console.WriteLine("update successful");

        }



    }
    
}
