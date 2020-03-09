using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace new_1.Controllers
{
    public class ValuesController : ApiController
    {
        private my_DBEntities db = new my_DBEntities();
        public IEnumerable<Product> Get()
        
        {
            return db.Product.ToList();
        }
        public Product Get(int id)
        {
            return db.Product.Find(id);
        }
        public void Post(Product value)
        {
            Product obj = new Product();
            obj.Name = value.Name;
            obj.Category = value.Category;
            obj.CreateDate = DateTime.Now;
            obj.Price = value.Price;
            db.Product.Add(obj);
            db.SaveChanges();
        }
        public void Put(Product value)
        {
            db.Entry(value).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            Product product = db.Product.Find(id);
            db.Product.Remove(product);
            db.SaveChanges();
        }
    }
}
