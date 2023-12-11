using PersevaBackend.BusinessLayer.Abstract;
using PersevaBackend.DataAccessLayer.Abstract;
using PersevaBackend.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.BusinessLayer.Concrete
{
    public class ReturnManager : IReturnService
    {
        private readonly IReturnDal _returnDal;

        public ReturnManager(IReturnDal returnDal)
        {
            _returnDal = returnDal;
        }

        public void TDelete(Return t)
        {
            _returnDal.Delete(t);
        }

        public Return TGetById(int id)
        {
            return _returnDal.GetById(id);
        }

        public List<Return> TGetList()
        {
            return _returnDal.GetList();
        }

        public void TInsert(Return t)
        {
            _returnDal.Insert(t);
        }

        public void TUpdate(Return t)
        {
            _returnDal.Update(t);
        }
    }
}
