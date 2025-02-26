using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Entities
{

    #region Part1
    //internal class Topic
    //{
    //   
    //    public int ID { get; set; }
    //  
    //    public string Name { get; set; }
    //}

    //[Table("Topic", Schema = "dbo")]
    //internal class Topic
    //{
    //    [Key]
    //    public int ID { get; set; }
    //    [Required]
    //    public string Name { get; set; }
    //}

    #endregion
    // using Fluent API's
    internal class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }

}
