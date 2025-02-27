using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data
{
    public class FinanceAppContext : DbContext
    {
        // Constructor
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options):base(options)  { }

        // Instance of the Class to interact with the DB of the Expense table
        DbSet<Expense> Expenses { get; set; }
    }
}
