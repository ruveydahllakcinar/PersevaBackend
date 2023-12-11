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
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void TDelete(Basket t)
        {
            _basketDal.Delete(t);
        }

        public Basket TGetById(int id)
        {
            return _basketDal.GetById(id);
        }

        public List<Basket> TGetList()
        {
            return _basketDal.GetList();
        }

        public void TInsert(Basket t)
        {
            _basketDal.Insert(t);
        }

        public void TUpdate(Basket t)
        {
            _basketDal.Update(t);
        }
    }
}
