using Fayu.DataAccess.Repository.IRepository;
using Fayu.Models;
using Fayu.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fayu.DataAccess.Repository
{
    public class AcekRepository : Repository<Acek>, IAcekRepository
    {
        private ApplicationDbContext _db;
        public AcekRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(Acek obj)
        {
            _db.Aceks.Update(obj);
        }
    }
}
