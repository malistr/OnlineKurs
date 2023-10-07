using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKurs.Models
{
    [Table("Students")]

    public class Student : BaseModel
    {
        public string StudentEmail { get; set; }
        public string StudentPassword { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
