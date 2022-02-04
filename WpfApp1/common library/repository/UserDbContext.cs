using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using common_library.model;
//using Microsoft.EntityFrameworkCore;

namespace common_library.repository
{
    class UserDbContext // : DbContext
    {
        private static UserDbContext instance = null;

        // public DbSet<User> Users { get; set; }

        public static UserDbContext Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UserDbContext();
                }
                return instance;
            }
        }

        private UserDbContext()
        {
            //Database.EnsureCreated();
        }

        /*protected override void OnConfiguration(DbContextOptionsBuilder optionsBuilder)
        {

        }*/
    }
}

