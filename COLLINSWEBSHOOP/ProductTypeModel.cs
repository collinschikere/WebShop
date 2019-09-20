using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COLLINSWEBSHOOP.Styles
 {  
    public class ProductTypemodel
    {
        public string InsertproductType(Product_Type productType)
        {
            try
            {
                firstdbEntities1 db = new firstdbEntities1();
                db.Product_Types.Add(productType);
                db.SaveChanges();
                return productType.Name + "was sucessfully inserted";
            }
            catch(Exception e)
            {
                return "Error:" + e;
            }

        }
        public string UpdateproductType(int id,Product_Type productType)
        {
            try
            {
                firstdbEntities1 db = new firstdbEntities1();
                //Fetch object from db
                Product_Type p = db.Product_Types.Find(id);
                p.Name = productType.Name;
                db.SaveChanges();
                return productType.Name + "was sucessfully updated";
            }
            catch(Exception e)
            {
                return "Error:" + e;
            }
        } 
        public string DeleteproductType(int id)
        {
            try
            {
                firstdbEntities1 db = new firstdbEntities1();
                Product_Type product_Type = db.Product_Types.Find(id);
                db.Product_Types.Attach(product_Type);
                db.Product_Types.Remove(product_Type);
                db.SaveChanges();
                return product_Type.Name + "was sucessfully deleted";

            }
            catch(Exception e)
            {
                return "Error:" + e;
            }
        }
    }
      
 }