using Finance.Models;
using Microsoft.EntityFrameworkCore;

namespace Finance.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options):base(options)
        {
            
        }
        public DbSet<Expense> Expenses { get; set; }
    }
}
