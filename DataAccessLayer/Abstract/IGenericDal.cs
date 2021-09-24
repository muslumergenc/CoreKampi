using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        void Inser(T t);
        void Delete(T t);
        void Update(T t);
        Task<List<T>> GetListAll();
        Task<T> GetById(int id);
        List<T> List(Expression<Func<T,bool>> filter);
    }
}
