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
    public class RefundManager : IRefundService
    {
        private readonly IRefundDal _refundDal;

        public RefundManager(IRefundDal refundDal)
        {
            _refundDal = refundDal;
        }

        public void TDelete(Refund t)
        {
            _refundDal.Delete(t);
        }

        public Refund TGetById(int id)
        {
           return _refundDal.GetById(id);
        }

        public List<Refund> TGetList()
        {
            return _refundDal.GetList();
        }

        public void TInsert(Refund t)
        {
            _refundDal.Insert(t);
        }

        public void TUpdate(Refund t)
        {
            _refundDal.Update(t);
        }
    }
}
