using OnlineKurs.Data;
using OnlineKurs.Models;
using OnlineKurs.Repository.Shared.NewFolder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineKurs.Repository.Shared.NewFolder.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IRepository<AppUser> Users { get; private set; }

        public IRepository<About> Abouts { get; private set; }

        public IRepository<Category> Categories { get; private set; }

        public IRepository<Comment> Comments { get; private set; }

        public IRepository<ContactForm> ContactForms { get; private set; }

        public IRepository<Course> Courses { get; private set; }

        public IRepository<Student> Students { get; private set; }

        public IRepository<Teacher> Teachers { get; private set; }

        public IRepository<SubCategory> SubCategories { get; private set; }

        public IRepository<UserType> UserTypes { get; private set; }

        public IRepository<Video> Videos { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Users = new Repository<AppUser>(_context);
            Abouts = new Repository<About>(_context);
            Categories = new Repository<Category>(_context);
            Comments = new Repository<Comment>(_context);
            ContactForms = new Repository<ContactForm>(_context);
            Courses = new Repository<Course>(_context);
            Students = new Repository<Student>(_context);
            Teachers = new Repository<Teacher>(_context);
            SubCategories = new Repository<SubCategory>(_context);
            UserTypes = new Repository<UserType>(_context);
            Videos = new Repository<Video>(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
