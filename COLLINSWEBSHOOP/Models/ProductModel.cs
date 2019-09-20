using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COLLINSWEBSHOOP.Models
{
    public class ProductModel
    {
        public string Insertproduct(product product)
        {
            try
            {
                firstdbEntities2 db= new firstdbEntities2();
                db.products.Add(product);
                db.SaveChanges();
                return product.Name + "was sucessfully inserted";
            }
            catch(Exception e)
            {
                return "Error:" + e;
            }

        }
        public string Updateproduct(int id, product product)
        {
            try
            {
                firstdbEntities2 db = new firstdbEntities2();
                // Fetch object from db
                product p = db.products.Find(id);
                p.Name = product.Name;
                p.price = product.price;
                p.TypeId = product.TypeId;
                p.Description = product.Description;
                p.Image = product.Image;
                db.SaveChanges();
                return product.Name + "was sucessfully updated";
            }
            catch(Exception e)
            {
                return "Error:" + e;
            }
        }
        public string Deleteproduct(int id)
        {
            try
            {
                firstdbEntities2 db = new firstdbEntities2();
                product product = db.products.Find(id);
                db.products.Attach(product);
                db.products.Remove(product);
                db.SaveChanges();
                return product.Name + "was sucessfully deleted";
            }
            catch(Exception e)
            {
                return "Error:" + e;
            }

        }
    }

}