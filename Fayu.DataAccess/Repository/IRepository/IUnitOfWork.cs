using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fayu.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IOcekRepository Ocek { get; }
        IAcekRepository Acek { get; }
        IBillRepository Bill { get; }
        ICompanyRepository Company { get; }
        IDailyFinancialsRepository DailyFinancials { get; }
        IFinancialEntRepository FinancialEnt { get; }
        IInstallmentRepository Installment { get; }
        ISupplierRepository Supplier { get; }
        ITodoRepository Todo { get; }
        
        void Save();
    }
}
