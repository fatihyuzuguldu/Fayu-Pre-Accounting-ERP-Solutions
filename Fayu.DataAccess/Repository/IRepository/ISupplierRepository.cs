using Fayu.Models;

namespace Fayu.DataAccess.Repository.IRepository
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        void Update(Supplier obj);
    }
}
