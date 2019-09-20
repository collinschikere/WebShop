using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COLLINSWEBSHOOP.Models
{
    public class Cartmodel
    {
        public string Insertcart(Cart cart)
        {
            try
            {
                firstdbEntities2 db = new firstdbEntities2();
                db.Carts.Add(cart);
                db.SaveChanges();
                return cart.datepurchased + "was sucessfully inserted";
            }
            catch(Exception e)
            {
                return "Error:" + e;
            }
        }
        public string Updatecart(int id, Cart cart)
        {
            try
            {
                firstdbEntities2 db = new firstdbEntities2();
                // Fetch object from db
                Cart p = db.Carts.Find(id);
                p.datepurchased = cart.datepurchased;
                p.Clientid = cart.Clientid;
                p.amount = cart.amount;
                p.isincart = cart.isincart;
                p.productid = cart.productid;
                db.SaveChanges();
                return cart.datepurchased + "was sucessfully updated";

            }
            catch(Exception e)
            {
                return "Error:" + e;
            }
        }
        public string Deletecart(int id)
        {
            try
            {
                firstdbEntities2 db = new firstdbEntities2();
                Cart cart = db.Carts.Find(id);
                db.Carts.Attach(cart);
                db.Carts.Remove(cart);
                db.SaveChanges();
                return cart.datepurchased + "was succefully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
    }
}