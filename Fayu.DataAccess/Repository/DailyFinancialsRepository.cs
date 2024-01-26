using Fayu.DataAccess.Data;
using Fayu.DataAccess.Repository.IRepository;
using Fayu.Models;

namespace Fayu.DataAccess.Repository
{
    public class DailyFinancialsRepository : Repository<DailyFinancials>, IDailyFinancialsRepository
    {
        private ApplicationDbContext _db;
        public DailyFinancialsRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(DailyFinancials obj)
        {
            _db.DailyFinancialies.Update(obj);
        }
    }
}
