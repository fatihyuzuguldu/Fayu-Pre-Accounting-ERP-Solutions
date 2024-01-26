using Fayu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fayu.DataAccess.Repository.IRepository
{
    public interface IFinancialEntRepository : IRepository<FinancialEnt>
    {
        void Update(FinancialEnt obj);
    }
}
