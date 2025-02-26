using System.Net.WebSockets;
using Task01.Entities;
using Task01_.Context;

namespace Task01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Students CRUD
            //using AppDbContext appDbContext = new AppDbContext();

            // i added a dept in the db to test
            ////Student student = new Student()
            ////{
            ////    FName = "Youssef",
            ////    LName = "Naser",
            ////    Address = "Cairo",
            ////    Age = 22,
            ////    Dep_Id = 3
            ////};
            ////// Create
            ////appDbContext.Students.Add(student);

            //// Retreive
            ////var result = appDbContext.Students.Find(4);
            ////Console.WriteLine(result?.ToString());
            ////var result = appDbContext.Students.FirstOrDefault(E => E.ID == 4);
            ////Console.WriteLine(result?.ToString());

            //// Update
            ////var result = appDbContext.Students.FirstOrDefault(E => E.ID == 4);
            ////result.FName = "Changed";

            //// delete
            ////var result = appDbContext.Students.FirstOrDefault(E => E.ID == 4);
            ////appDbContext.Students.Remove(result);


            ////appDbContext.SaveChanges(); 
            #endregion

            #region Courses CRUD
            //using AppDbContext appDbContext = new AppDbContext();

            //// i added a topic in the database to test 
            ////Course course = new Course()
            ////{
            ////    Duration = 10,
            ////    Name = "C# Basics",
            ////    Description = "An introductory course on C#",
            ////    Top_ID = 2
            ////};

            //// Create
            ////appDbContext.Courses.Add(course);

            //// Retreive
            ////var result = appDbContext.Courses.Find(4);
            ////Console.WriteLine(result?.ToString());

            //// Update
            ////var result = appDbContext.Courses.FirstOrDefault(E => E.ID == 4);
            ////result.Description = "new description";

            //// Remove
            ////var result = appDbContext.Courses.FirstOrDefault(E => E.ID == 5);
            ////appDbContext.Courses.Remove(result);

            ////appDbContext.SaveChanges(); 
            #endregion

            #region Department CRUD
            //using AppDbContext appDbContext = new AppDbContext();

            ////Department department = new Department()
            ////{
            ////    Name = "Computer Science",
            ////    HiringDate = DateTime.Now,
            ////    Ins_ID = 8
            ////};

            //// Create
            ////appDbContext.Departments.Add(department);

            //// Update
            ////var result = appDbContext.Departments.FirstOrDefault(D => D.ID == 7);
            ////result.Name = "changed";
            ////appDbContext.SaveChanges();

            //// Select
            ////var result = appDbContext.Departments.FirstOrDefault(D => D.ID == 7);
            ////Console.WriteLine(result);

            //// Remove
            ////var result = appDbContext.Departments.FirstOrDefault(D => D.ID == 7);
            ////appDbContext.Departments.Remove(result);
            ////appDbContext.SaveChanges(); 
            #endregion

            #region Instructor CRUD
            //using AppDbContext appDbContext = new AppDbContext();

            //// Create
            ////appDbContext.Add(new Instructor
            ////{
            ////    Name = "Khalid",
            ////    Address = "123 Street, City",
            ////    Bonus = 500,        
            ////    Salary = 5000,      
            ////    HourRate = 50,     
            ////    Dept_ID = 1      
            ////});

            ////// Select
            ////var result = appDbContext.instructors.FirstOrDefault(D => D.ID == 10);
            ////Console.WriteLine(result);

            ////// Update
            ////var result1 = appDbContext.instructors.FirstOrDefault(D => D.ID == 10);
            ////result1.Name = "Changed";

            //var result = appDbContext.instructors.FirstOrDefault(D => D.ID == 10);
            //appDbContext.instructors.Remove(result);
            //appDbContext.SaveChanges(); 
            #endregion

            #region Topic CRUD

            //using AppDbContext appDbContext = new AppDbContext();
            ////Topic topic = new Topic()
            ////{
            ////    Name = "Topic 1",
            ////};

            ////// Create
            ////appDbContext.Add(topic);

            ////appDbContext.SaveChanges();

            ////// Select
            ////var result = appDbContext.topics.FirstOrDefault(T => T.Name == "Topic 1");
            ////Console.WriteLine(result.ID);

            ////// Update
            ////var result = appDbContext.topics.FirstOrDefault(T => T.Name == "Topic 1");
            ////result.Name = "New topic";
            ////appDbContext.SaveChanges();

            ////// Remove
            ////var result = appDbContext.topics.FirstOrDefault(T => T.Name == "New topic");
            ////appDbContext.topics.Remove(result);
            ////appDbContext.SaveChanges(); 
            #endregion

            #region Course_Instructor CRUD
            //using AppDbContext appDbContext = new AppDbContext();

            //// Create
            ////Course_Inst course_Inst = new Course_Inst()
            ////{
            ////    CourseID = 2,
            ////    InstructorID = 3,
            ////    evaluation = 40
            ////};
            ////appDbContext.Add(course_Inst);
            ////appDbContext.SaveChanges();

            ////// Select
            ////var result = appDbContext.Course_Insts.FirstOrDefault(CI => CI.CourseID == 1);
            ////Console.WriteLine(result.evaluation);

            ////// Update
            ////var result = appDbContext.Course_Insts.FirstOrDefault(CI => CI.CourseID == 1);
            ////result.evaluation = 50;
            ////appDbContext.SaveChanges();

            ////// Delete
            ////var result = appDbContext.Course_Insts.FirstOrDefault(CI => CI.CourseID == 1);
            ////appDbContext.Course_Insts.Remove(result);
            ////appDbContext.SaveChanges();

            #endregion

            #region Course_Student CRUD
            //using AppDbContext appDbContext = new AppDbContext();

            ////// Create
            ////Stud_Course course = new Stud_Course()
            ////{
            ////    CourseID = 2,
            ////    StudentID = 5,
            ////    Grade = 90
            ////};
            ////appDbContext.Stud_Courses.Add(course);
            ////appDbContext.SaveChanges();

            ////// Select
            ////var result = appDbContext.Stud_Courses.FirstOrDefault(C => C.Grade == 90);
            ////Console.WriteLine(result.CourseID);

            //////// Update
            ////var result = appDbContext.Stud_Courses.FirstOrDefault(C => C.Grade == 90);
            ////result.Grade = 0;
            ////appDbContext.SaveChanges();

            ////// Remove
            ////var result = appDbContext.Stud_Courses.FirstOrDefault(C => C.Grade == 0);
            ////appDbContext.Stud_Courses.Remove(result);
            ////appDbContext.SaveChanges(); 
            #endregion
        }
    }
}
