using KuzeyCodeFirst.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyCodeFirst.Repository
{
    public interface IRepository<T,in TId> where T: BaseEntity
    {
        T GetById(TId id);
        IQueryable<T> Get(Func<T, bool> predicate = null);
        void Add(T entity,bool isSavaLater = false);
        void Remove(T entity,bool isSavaLater = false);
        void Update(T entity,bool isSavaLater = false);

        int Save();
    }
}
