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
    public class UserAddressManager : IUserAddressService
    {

        private readonly IUserAddressDal _userAddressDal;

        public UserAddressManager(IUserAddressDal userAddressDal)
        {
            _userAddressDal = userAddressDal;
        }

        public void TDelete(UserAddress t)
        {
           _userAddressDal.Delete(t);
        }

        public UserAddress TGetById(int id)
        {
           return _userAddressDal.GetById(id);
        }

        public List<UserAddress> TGetList()
        {
            return _userAddressDal.GetList();
        }

        public void TInsert(UserAddress t)
        {
            _userAddressDal.Insert(t);
        }

        public void TUpdate(UserAddress t)
        {
            _userAddressDal.Update(t);
        }
    }
}
