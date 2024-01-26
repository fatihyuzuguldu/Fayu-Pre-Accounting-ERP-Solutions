using Fayu.DataAccess.Data;
using Fayu.DataAccess.Repository.IRepository;
using Fayu.Models;

namespace Fayu.DataAccess.Repository
{
    public class BillRepository : Repository<Bill>, IBillRepository
    {
        private ApplicationDbContext _db;
        public BillRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(Bill obj)
        {
            _db.Bills.Update(obj);
        }
    }
}
