using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKurs.Models
{
    [Table("Videos")]
    public class Video : BaseModel
    {
        public string VideoTitle { get; set; }
        public string VideoContent { get; set; }
        public string VideoUrl { get; set; }
        public string VideoImage { get; set; }
        public bool VideoStatus { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
