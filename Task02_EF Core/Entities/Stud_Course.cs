using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Entities
{
    #region part1
    //internal class Stud_Course
    //{
    //    public int Stud_CourseID { get; set; }
    //    public int Course_ID { get; set; }
    //    public double Grade { get; set; }
    //}
    //[Table("Stud_Course", Schema = "dbo")]
    //internal class Stud_Course
    //{
    //    [Key]
    //    public int Stud_CourseID { get; set; }
    //    [NotNull]
    //    public int Course_ID { get; set; }
    //    [Required]
    //    public double Grade { get; set; }
    //}
    // using Fluent API's 
    #endregion
    internal class Stud_Course
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public double? Grade { get; set; }
    }
}
