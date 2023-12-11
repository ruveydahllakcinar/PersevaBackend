using PersevaBackend.DataAccessLayer.Abstract;
using PersevaBackend.DataAccessLayer.Concrete;
using PersevaBackend.DataAccessLayer.Repositories;
using PersevaBackend.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.DataAccessLayer.EntityFramework
{
    public class EfShopOwnerDal : GenericRepository<ShopOwner>, IShopOwnerDal
    {
        public EfShopOwnerDal(Context context) : base(context)
        {
        }
    }
}
