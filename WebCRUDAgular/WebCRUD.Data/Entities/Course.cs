using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCRUD.Data.Entities
{
    public class Course
    {
        public Course()
        {
            this.Enrollment = new Collection<Enrollment>();
        }

        [Key]
        public int CourseId { get; set; }
        public string Title { get; set; }
        public short Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
