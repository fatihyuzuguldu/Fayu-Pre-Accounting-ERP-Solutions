using Fayu.DataAccess.Data;
using Fayu.DataAccess.Repository.IRepository;
using Fayu.Models;

namespace Fayu.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(Company obj)
        {
            _db.Companys.Update(obj);
        }
    }
}
