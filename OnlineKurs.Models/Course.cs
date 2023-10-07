using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKurs.Models
{
    [Table("Courses")]

    public class Course : BaseModel
    {
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Video> Videos { get; set; } = new List<Video>();
        public bool Paid { get; set; } = false;
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
