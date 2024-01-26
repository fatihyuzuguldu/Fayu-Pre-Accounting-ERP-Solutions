using Fayu.DataAccess.Data;
using Fayu.DataAccess.Repository.IRepository;
using Fayu.Models;

namespace Fayu.DataAccess.Repository
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        private ApplicationDbContext _db;
        public SupplierRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(Supplier obj)
        {
            _db.Suppliers.Update(obj);
        }
    }
}
