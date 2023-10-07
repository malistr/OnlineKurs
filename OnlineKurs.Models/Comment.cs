using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKurs.Models
{
    [Table("Comments")]

    public class Comment : BaseModel
    {
        public string CommentContent { get; set; }
        public bool CommentStatus { get; set; }

        public int VideoId { get; set; } // Örnek olarak, bir videoya bağlı yorumlar için bir foreign key

        public virtual Video Video { get; set; }
        //public Video Video { get; set; } // Comment ile Video arasındaki ilişkiyi temsil eden navigation property
    }
}
