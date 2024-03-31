using GHWeb.DataAccess.Data;
using GHWeb.DataAccess.Repository.IRepository;
using GHWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GHWeb.DataAccess.Repository
{
    public class ApplicationUserRepository : Repos<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
