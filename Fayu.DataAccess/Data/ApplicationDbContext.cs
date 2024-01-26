using Fayu.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fayu.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Ocek> Oceks { get; set; }
        public DbSet<Acek> Aceks { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<DailyFinancials> DailyFinancialies { get; set; }
        public DbSet<FinancialEnt> FinancialEnts { get; set; }
        public DbSet<Installment> Installments { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        
    }
}