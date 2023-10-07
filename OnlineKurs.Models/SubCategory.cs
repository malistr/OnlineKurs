using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKurs.Models
{
    public class SubCategory : BaseModel
    {
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Video> Videos { get; set; } = new List<Video>();

    }
}
