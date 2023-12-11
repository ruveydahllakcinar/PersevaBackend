using PersevaBackend.EntityLayer.Concrete;
using PersevaBackend.WebApi.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<ProductRequest>
    {

        Task<RestResponse?> GetShopierProductList();



    }
}
