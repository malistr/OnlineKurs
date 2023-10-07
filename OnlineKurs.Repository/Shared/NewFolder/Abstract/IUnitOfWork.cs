using OnlineKurs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKurs.Repository.Shared.NewFolder.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<AppUser> Users { get; }
        IRepository<About> Abouts { get; }
        IRepository<Category> Categories { get; }
        IRepository<Comment> Comments { get; }
        IRepository<ContactForm> ContactForms { get; }
        IRepository<Course> Courses { get; }
        IRepository<Student> Students { get; }
        IRepository<Teacher> Teachers { get; }
        IRepository<SubCategory> SubCategories { get; }
        IRepository<UserType> UserTypes { get; }
        IRepository<Video> Videos { get; }

        void Save();

    }
}
