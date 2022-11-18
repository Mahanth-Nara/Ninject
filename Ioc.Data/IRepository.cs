using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc.Core;

namespace Ioc.Data
{
    //Here at the declaration itself we are saying that the interface requires one argument 
    //provided the arument should be of type BaseEntity or its derivative
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }
    }
}
