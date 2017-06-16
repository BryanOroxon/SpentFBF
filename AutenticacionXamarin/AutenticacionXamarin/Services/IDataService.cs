using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutenticacionXamarin
{
    public interface IDataService
    {
        Task AddExpenseAsync(Expense ex);
        Task<IEnumerable<Expense>> GetExpensesAsync();
    }
}