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
    public class ShopOwnerManager : IShopOwnerService
    {
        private readonly IShopOwnerDal _shopOwnerDal;

        public ShopOwnerManager(IShopOwnerDal shopOwnerDal)
        {
            _shopOwnerDal = shopOwnerDal;
        }

        public void TDelete(ShopOwner t)
        {
            _shopOwnerDal.Delete(t);
        }

        public ShopOwner TGetById(int id)
        {
           return _shopOwnerDal.GetById(id);
        }

        public List<ShopOwner> TGetList()
        {
            return _shopOwnerDal.GetList();
        }

        public void TInsert(ShopOwner t)
        {
            _shopOwnerDal.Insert(t);
        }

        public void TUpdate(ShopOwner t)
        {
            _shopOwnerDal.Update(t);
        }
    }
}
