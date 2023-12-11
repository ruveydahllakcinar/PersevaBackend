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
    public class BillingInfoManager : IBillingInfoService
    {
        private readonly IBillingInfoDal _billingInfoDal;

        public BillingInfoManager(IBillingInfoDal billingInfoDal)
        {
            _billingInfoDal = billingInfoDal;
        }

        public void TDelete(BillingInfo t)
        {
            _billingInfoDal.Delete(t);
        }

        public BillingInfo TGetById(int id)
        {
            return _billingInfoDal.GetById(id);
        }

        public List<BillingInfo> TGetList()
        {
            return _billingInfoDal.GetList();
        }

        public void TInsert(BillingInfo t)
        {
            _billingInfoDal.Insert(t);
        }

        public void TUpdate(BillingInfo t)
        {
            _billingInfoDal.Update(t); ;
        }
    }
}
