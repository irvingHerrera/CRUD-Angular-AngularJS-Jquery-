﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCRUD.Data.Entities
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        public string Grade { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
