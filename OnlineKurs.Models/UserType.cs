using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKurs.Models
{
    [Table("UserTypes")]

    public class UserType : BaseModel
    {
        public string Name { get; set; }

    }
}
