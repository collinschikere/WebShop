using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COLLINSWEBSHOOP.Models
{
    public class ProductTypeModel
    {
        public string InsertproductType(productType productType)
        {
            try
            {
                firstdbEntities2 db = new firstdbEntities2();
                db.productTypes.Add(productType);
                db.SaveChanges();
                return productType.Name + "was sucessfully inserted";
            }
            catch(Exception e)
            {
                return "Error:" + e;
            }
        }
        public string UpdateproductType(int id, productType productType)
        {
            try
            {
                firstdbEntities2 db = new firstdbEntities2();
                //Fetch object from db
                productType p = db.productTypes.Find(id);
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
                firstdbEntities2 db = new firstdbEntities2();
                productType productType = db.productTypes.Find(id);
                db.productTypes.Attach(productType);
                db.productTypes.Remove(productType);
                db.SaveChanges();
                return productType.Name + "was sucessfully deleted";
            }
            catch(Exception e)
            {
                return "Error:" + e;
            }
        }
    }
}