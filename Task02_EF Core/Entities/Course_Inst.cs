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
    //internal class Course_Inst
    //{
    //    public int Course_InstID { get; set; }
    //    public int Course_ID { get; set; }
    //    public int evaluation { get; set; }
    //}

    //[Table("Course_Inst", Schema = "dbo")]
    //internal class Course_Inst
    //{
    //    [Key]
    //    public int Course_InstID { get; set; }
    //    [NotNull]
    //    public int Course_ID { get; set; }
    //    [NotNull]
    //    [Column("Eval", TypeName = "int")]
    //    public int evaluation { get; set; }
    //} 
    #endregion

    // using Fluent API's
    internal class Course_Inst
    {
        public int CourseID { get; set; }
        public int InstructorID { get; set; }
        public int evaluation { get; set; }
    }
}
