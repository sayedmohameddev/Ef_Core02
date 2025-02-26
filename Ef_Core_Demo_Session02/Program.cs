using System.Net.Http.Headers;
using EF_Core_Session02_Demo.Contexts;
using EF_Core_Session02_Demo.Entities;

namespace EF_Core_Session02_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Revision
            // Ef core is the ORM 
            // Object Relation mapper 


            // 1. Mapping 
            //   1.1 Code first [Generate Table Per Class]
            //   1.2 DB first   [Generate Class Per Table]
            // 2. LINQ to EFCore

            // 3 Ways For generation
            // 1. TPC : Table Per Class
            // 2. RPH : Table Per Hiraricy
            // 3. TPCC: Table Per Complete Class

            //AppContext appContext = new AppContext(); 
            #endregion

            #region Prepare For CRUD Operations
            // CRUD Operations --> Create Retrive Update Delete
            //using AppDBContext appDBContext = new AppDBContext();



            //try
            //{
            //    // Crud operation
            //}
            //finally
            //{
            //    // Dispose
            //    appDBContext.Dispose();
            //}

            //using (appDBContext) 
            //{
            //    // CRUD operation
            //    // using automaticlly close the connection so you dont have to dispose it yourself
            //} 
            #endregion

            #region Create CRUD-Operation

            //using AppDBContext appDBContext = new AppDBContext();

            //// Create - Insert 

            //Employee employee = new Employee()
            //{
            //    Address = "Cairo",
            //    Name = "Test1",
            //    Age = 21,
            //    Salary = 21000
            //};

            ////// appDBContext.Add(employee); CLR determines the type of the object and adds it to the DB

            ////Console.WriteLine(appDBContext.Entry(employee).State); // Detached

            ////employee.Name = "testtest";

            ////Console.WriteLine(appDBContext.Entry(employee).State);

            ////appDBContext.employees.Add(employee);

            ////Console.WriteLine(appDBContext.Entry(employee).State); // Added

            ////appDBContext.SaveChanges();

            ////employee.Name = "testtesttest";

            ////Console.WriteLine(appDBContext.Entry(employee).State); // Unchanged in memory and Database

            //appDBContext.Add(employee);

            ////appDBContext.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Added;

            //appDBContext.SaveChanges(); 
            #endregion

            #region Retreive CRUD-Operation
            ////// Read - Select
            //using AppDBContext appDBContext = new AppDBContext();

            ////Employee employee = new Employee()
            ////{
            ////    Address = "Cairo",
            ////    Name = "Test1",
            ////    Age = 21,
            ////    Salary = 21000
            ////};

            ////var Result = appDBContext.employees.Where(E => E.Id == 6).FirstOrDefault();
            ////Console.WriteLine(Result?.ToString());

            ////var result = appDBContext.employees.Select(E => E.Name);
            ////foreach (var e in result)
            ////{
            ////    Console.WriteLine(e);
            ////} 
            #endregion

            #region Update CRUD-Operation

            //AppDBContext appDBContext = new AppDBContext();

            //var result = appDBContext.employees.FirstOrDefault(E => E.Id == 6);

            //Console.WriteLine(appDBContext.Entry(result).State);

            //result.Name = "Changed";

            //Console.WriteLine(appDBContext.Entry(result).State);

            //appDBContext.Update(result);

            //Console.WriteLine(appDBContext.Entry(result).State);


            ////appDBContext.SaveChanges();
            #endregion

            #region Delete CRUD-Operation
            //AppDBContext appDBContext = new AppDBContext();

            //var result = appDBContext.employees.FirstOrDefault(E => E.Id == 6);

            //appDBContext.employees.Remove(result);

            //Console.WriteLine(appDBContext.Entry(result).State);

            //appDBContext.SaveChanges();
            #endregion


        }
    }
}
