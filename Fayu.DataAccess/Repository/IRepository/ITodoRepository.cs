using Fayu.Models;

namespace Fayu.DataAccess.Repository.IRepository
{
    public interface ITodoRepository : IRepository<Todo>
    {
        void Update(Todo obj);
    }
}
