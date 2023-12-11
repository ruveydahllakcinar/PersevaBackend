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
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TDelete(User t)
        {
           _userDal.Delete(t);
        }

        public User TGetById(int id)
        {
            return _userDal.GetById(id);    
        }

        public List<User> TGetList()
        {
            return _userDal.GetList();
        }

        public void TInsert(User t)
        {
            _userDal.Insert(t);
        }

        public void TUpdate(User t)
        {
           _userDal.Update(t);
        }
    }
}
