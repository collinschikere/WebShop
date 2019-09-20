using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COLLINSWEBSHOOP.Styles
{
    public class Productmodel
    { 
        public string Insertproduct(product product)
        {
            try
            {
                firstdbEntities1 db = new firstdbEntities1();
                db.products.Add(product);
                db.SaveChanges();
                return product.Name + "was sucessfully inserted";
            }
            catch(Exception e)
            {
                return "Error:" + e;
            }
        
        }
        public string Updateproduct(int Id, product product)
        {
            try
            {
                firstdbEntities1 db = new firstdbEntities1();
                // Fetch object from db
                product p = db.products.Find(Id);
                p.Name = product.Name;
                p.price = product.price;
                p.TypeId = product.TypeId;
                p.Description = product.Image;
                db.SaveChanges();
                return product.Name + "was sucessfully updated";



            }
            catch(Exception e)
            {
                return "Error:" + e;
            }
            

        }
        public string DeleteProduct(int id)
        {
            try
            {
                firstdbEntities1 db = new firstdbEntities1();
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