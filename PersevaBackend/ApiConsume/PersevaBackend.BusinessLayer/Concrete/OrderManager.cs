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
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TDelete(Order t)
        {
            _orderDal.Delete(t);
        }

        public Order TGetById(int id)
        {
            return _orderDal.GetById(id);
        }

        public List<Order> TGetList()
        {
           return _orderDal.GetList();
        }

        public void TInsert(Order t)
        {
            _orderDal.Insert(t);
        }

        public void TUpdate(Order t)
        {
            _orderDal.Update(t);
        }
    }
}
