using Mapster;
using PersevaBackend.BusinessLayer.Abstract;
using PersevaBackend.DataAccessLayer.Abstract;
using PersevaBackend.EntityLayer.Concrete;
using PersevaBackend.WebApi.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public void TDelete(ProductRequest t)
        {
            throw new NotImplementedException();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void TInsert(ProductRequest t)
        {

            var product = t.Adapt<Product>();

            _productDal.Insert(product);


        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }

        public void TUpdate(ProductRequest t)
        {
            throw new NotImplementedException();
        }

        ProductRequest IGenericService<ProductRequest>.TGetById(int id)
        {
            throw new NotImplementedException();
        }

        List<ProductRequest?> IGenericService<ProductRequest?>.TGetList()
        {
            var productList = _productDal.GetList();
            var product = productList.Adapt<List<ProductRequest?>>();

            return product;
        }

        async Task<RestResponse?> IProductService.GetShopierProductList()
        {
            var options = new RestClientOptions("https://api.shopier.com/v1/products?limit=10&page=1&sort=dateDesc");
            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("accept", "application/json");
            request.AddHeader("authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiI3MWM5ODc1N2ZhYWFjZGE4ZTRhNjYyYjJiOTkwY2YzYyIsImp0aSI6IjZiZWJmNjRlM2E1OGQxM2VkY2U3ZjQzOTdmZjlmZWZjNzFiMDU4YjA0MGJkNDkwNGFjMjliMDdjYjA2ZDUwNTA5NDJjOWNlNGM0MmZhMmVhYzhhM2FkZTVlNjExMDdiMzkxMmIwNjUwZTE2MGQ0NTY2MmM4MzlmOTQzOTY2NGZmZTgyZjc0MGJjM2EzMGUzMDNjNmU4NmE2NWE2MjRlYzciLCJpYXQiOjE2OTk1NTQ2NDMsIm5iZiI6MTY5OTU1NDY0MywiZXhwIjoxODU3MzM5NDAzLCJzdWIiOiIxMDE0MDM2Iiwic2NvcGVzIjpbIm9yZGVyczpyZWFkIiwib3JkZXJzOndyaXRlIiwicHJvZHVjdHM6cmVhZCIsInByb2R1Y3RzOndyaXRlIiwic2hpcHBpbmdzOnJlYWQiLCJzaGlwcGluZ3M6d3JpdGUiLCJkaXNjb3VudHM6cmVhZCIsImRpc2NvdW50czp3cml0ZSIsInBheW91dHM6cmVhZCIsInJlZnVuZHM6cmVhZCIsInJlZnVuZHM6d3JpdGUiLCJzaG9wOnJlYWQiLCJzaG9wOndyaXRlIl19.fYrGbtuKOVYfcAhltboMulcrOpsTTq4_lsdcORzUmcUUQ_zZDoHhmpu4n6JbXb1ZuW1j_SxMSREVTsABBG-VFN0obuVqOir-XyMKnLw7t-qYQxI0pd4KcAQSx0IPrTT8UyJOM-1ltzCuG_jHo2aA9G58hMB1TrNKKV2c9AbX7xdrmHhW9TNVnRhUjQXDmUyEVbEnaauDdZuxB4IcTgNjxe_ZKexxQxqSqTNLZwyiqOIyY_TjM2239NYifv81w29muF1SP-q8iuk23LzpUQt01V5WkMNtxi_R0Ex-ORKm_0UUEbPbMv5B3Q7s3v2Yi0ImYV97MlbeAb2_8EDgC0l9FQ");
            var response = await client.GetAsync(request);

            return response;
        }

    }
}
