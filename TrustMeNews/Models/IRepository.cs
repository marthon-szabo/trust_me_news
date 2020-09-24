using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrustMeNews.Models
{
    public interface IRepository<T>
    {
        T Create(T model);
        T Get(int id);
        IEnumerable<T> GetAll();
        T Update(T objectChanges);
        T Delete(int id);
    }
}
