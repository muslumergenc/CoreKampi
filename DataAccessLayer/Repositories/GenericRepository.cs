using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        public void Delete(T t)
        {
            using var context = new Context();
            context.Set<T>().Remove(t);
        }

        public async Task<T> GetById(int id)
        {
            using var context = new Context();
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetListAll()
        {
            using var context = new Context();
            return await context.Set<T>().ToListAsync();
        }

        public void Inser(T t)
        {
            using var context = new Context();
            context.Set<T>().Add(t);
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            using var context = new Context();
            return context.Set<T>().Where(filter).ToList();
        }

        public void Update(T t)
        {
            using var context = new Context();
            context.Entry(t).State = EntityState.Modified;
        }
    }
}