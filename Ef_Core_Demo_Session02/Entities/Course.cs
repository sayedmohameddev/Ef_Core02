﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core_Demo_Session02.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StudentCourse> Students { get; set; }
    }
}
