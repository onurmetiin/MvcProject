//using DataAccessLayer.Abstract;
//using EntityLayer.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccessLayer.Concrete.Repositories
//{
//    public class CategoryRepository : ICategoryDal
//    {
//        Context C = new Context();
//        DbSet<Category> _object;

//        public void Add(Category t)
//        {
//            _object.Add(t);
//            C.SaveChanges();
//        }

//        public void Delete(Category t)
//        {
//            _object.Remove(t);
//            C.SaveChanges();
//        }

//        public List<Category> GetAll()
//        {
//            return _object.ToList();
//        }

//        public List<Category> List(Expression<Func<Category, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Category t)
//        {
//            C.SaveChanges();
//        }
//    }
//}
