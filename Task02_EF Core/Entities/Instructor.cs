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
    #region Part1
    //internal class Instructor
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public double Bonus { get; set; }
    //    public double Salary { get; set; }
    //    public string Address { get; set; }
    //    public double HourRate { get; set; }
    //    public int Dept_ID { get; set; }
    //}

    //[Table("Instructor", Schema = "dbo")]
    //internal class Instructor
    //{
    //    [Key]
    //    public int ID { get; set; }
    //    [Column("Name", TypeName = "varchar")]
    //    [StringLength(maximumLength: 120, MinimumLength = 12, ErrorMessage = "Invalid Name")]
    //    public string Name { get; set; }
    //    [Required]
    //    [DataType(DataType.Currency)]
    //    public double Bonus { get; set; }
    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; }
    //    [StringLength(maximumLength: 120, MinimumLength = 12)]
    //    [Column("Address", TypeName = "varchar")]
    //    public string Address { get; set; }
    //    [DataType(DataType.Currency)]
    //    public double HourRate { get; set; }
    //    [NotNull]
    //    public int Dept_ID { get; set; }

    // using Fluent API's 
    #endregion

    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Bonus { get; set; }
        public double Salary { get; set; }
        public string? Address { get; set; }
        public double HourRate { get; set; }
        [ForeignKey(nameof(department))]
        public int? Dept_ID { get; set; }
        [InverseProperty(nameof(department.Instructors))]
        public Department department { get; set; }
        [InverseProperty(nameof(department.instructor))]
        public Department Department { get; set; }

        public List<Course_Inst>? courses { get; set; }
    }
}

