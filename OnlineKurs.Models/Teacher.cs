using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKurs.Models
{
    [Table("Teachers")]

    public class Teacher : BaseModel
    {
        public string? Biography { get; set; }
        public string TeacherImage { get; set; }
        public string TeacherMail { get; set; }
        public string TeacherPassword { get; set; }
        public bool TeacherStatus { get; set; }
        //public int AppUserTypeId { get; set; }
        //public virtual AppUserType AppUserType { get; set; }
        public virtual ICollection<Video> Videos { get; set; } = new List<Video>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
