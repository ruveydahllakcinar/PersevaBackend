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
    public class IFulFillmentManager : IFulFillmentsService
    {
        private readonly IFulfillmentDal _fulfillmentDal;

        public IFulFillmentManager(IFulfillmentDal fulfillmentDal)
        {
            _fulfillmentDal = fulfillmentDal;
        }

        public void TDelete(Fulfillment t)
        {
           _fulfillmentDal.Delete(t);
        }

        public Fulfillment TGetById(int id)
        {
            return _fulfillmentDal.GetById(id);
        }

        public List<Fulfillment> TGetList()
        {
            return _fulfillmentDal.GetList();
        }

        public void TInsert(Fulfillment t)
        {
            _fulfillmentDal.Insert(t);
        }

        public void TUpdate(Fulfillment t)
        {
            _fulfillmentDal.Update(t);
        }
    }
}
