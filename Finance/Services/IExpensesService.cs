using Finance.Models;
using System.Collections;

namespace Finance.Services
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetAll();
        Task Add(Expense expense);
        IQueryable GetChartData();
    }
}
