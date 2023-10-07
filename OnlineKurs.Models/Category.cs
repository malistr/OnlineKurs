using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKurs.Models
{
    [Table("Categories")]

    public class Category : BaseModel
    {
        public virtual ICollection<SubCategory> SubCategories { get; set; }
        public virtual ICollection<Video> Videos { get; set; } = new List<Video>();
    }
}
