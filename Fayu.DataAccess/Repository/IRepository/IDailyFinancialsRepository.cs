using Fayu.Models;

namespace Fayu.DataAccess.Repository.IRepository
{
    public interface IDailyFinancialsRepository : IRepository<DailyFinancials>
    {
        void Update(DailyFinancials obj);
    }
}
