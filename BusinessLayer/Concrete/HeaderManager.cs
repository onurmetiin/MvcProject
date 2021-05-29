using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeaderManager : IHeaderService
    {
        IHeaderDal _headerDal;

        public HeaderManager(IHeaderDal headerDal)
        {
            _headerDal = headerDal;
        }

        public void HeaderAdd(Header header)
        {
            _headerDal.Add(header);
        }

        public Header GetById(int id)
        {
            return _headerDal.Get(x => x.HeaderID == id);
        }

        public List<Header> GetList()
        {
            return _headerDal.List(x => x.HeaderName != null);
        }

        public void HeaderDelete(Header header)
        {
            _headerDal.Delete(header);
        }

        public void HeaderUpdate(Header header)
        {
            _headerDal.Update(header);
        }
    }
}
