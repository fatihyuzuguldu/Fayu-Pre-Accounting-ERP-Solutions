using Fayu.DataAccess.Repository.IRepository;
using Fayu.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fayu.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IOcekRepository Ocek { get; private set; }
        public IAcekRepository Acek { get; private set; }
        public IFinancialEntRepository FinancialEnt { get; private set; }
        public IBillRepository Bill { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public IDailyFinancialsRepository DailyFinancials { get; private set; }
        public IInstallmentRepository Installment { get; private set; }
        public ISupplierRepository Supplier { get; private set; }
        public ITodoRepository Todo { get; private set; }

        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            Ocek = new OcekRepository(_db);
            Bill = new BillRepository(_db);
            Company = new CompanyRepository(_db);
            DailyFinancials = new DailyFinancialsRepository(_db);
            FinancialEnt = new FinancialEntRepository(_db);
            Acek = new AcekRepository(_db);
            Installment = new InstallmentRepository(_db);
            Supplier = new SupplierRepository(_db);
            Todo = new TodoRepository(_db);
    }

    public void Save()
        {
            _db.SaveChanges();
        }
    }
}
