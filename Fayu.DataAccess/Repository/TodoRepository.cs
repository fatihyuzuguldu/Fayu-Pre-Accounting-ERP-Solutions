using Fayu.DataAccess.Data;
using Fayu.DataAccess.Repository.IRepository;
using Fayu.Models;

namespace Fayu.DataAccess.Repository
{
    public class TodoRepository : Repository<Todo>, ITodoRepository
    {
        private ApplicationDbContext _db;
        public TodoRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(Todo obj)
        {
            _db.Todos.Update(obj);
        }
    }
}
