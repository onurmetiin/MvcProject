using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        Context con = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = con.Set<T>();
        }

        public void Add(T t)
        {
            _object.Add(t);
            con.SaveChanges();
        }

        public void Delete(T t)
        {
            _object.Remove(t);
            con.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T t)
        {
            con.SaveChanges();
        }
    }
}
