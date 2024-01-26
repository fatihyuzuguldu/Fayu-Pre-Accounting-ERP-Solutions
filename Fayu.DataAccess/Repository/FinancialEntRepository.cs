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
    public class FinancialEntRepository : Repository<FinancialEnt>, IFinancialEntRepository
    {
        private ApplicationDbContext _db;
        public FinancialEntRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(FinancialEnt obj)
        {
            _db.FinancialEnts.Update(obj);
        }
    }
}
