using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        // שליפת כל הרשימה
        Task<IEnumerable<T>> GetAllAsync();

        // שליפה לפי קוד (ID)
        Task<T> GetByIdAsync(int id);

        // הוספה
        Task<T> AddAsync(T entity);

        // עדכון
        Task<T> UpdateAsync(int id,T entity);

        // מחיקה
        Task DeleteAsync(int id);
    }
}
