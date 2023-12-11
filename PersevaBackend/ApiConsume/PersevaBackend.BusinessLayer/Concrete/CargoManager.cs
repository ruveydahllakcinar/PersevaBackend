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
    public class CargoManager : ICargoService
    {
        private readonly ICargoDal _cargoDal;

        public CargoManager(ICargoDal cargoDal)
        {
            _cargoDal = cargoDal;
        }

        public void TDelete(Cargo t)
        {
            _cargoDal.Delete(t);
        }

        public Cargo TGetById(int id)
        {
            return _cargoDal.GetById(id);
        }

        public List<Cargo> TGetList()
        {
            return _cargoDal.GetList();
        }

        public void TInsert(Cargo t)
        {
             _cargoDal.Insert(t);
        }

        public void TUpdate(Cargo t)
        {
            _cargoDal.Update(t);
        }
    }
}
