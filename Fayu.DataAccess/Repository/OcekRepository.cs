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
    public class OcekRepository : Repository<Ocek>, IOcekRepository
    {
        private ApplicationDbContext _db;
        public OcekRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(Ocek obj)
        {
            _db.Oceks.Update(obj);
        }
    }
}
