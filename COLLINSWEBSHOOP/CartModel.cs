using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace COLLINSWEBSHOOP.Styles
    {
        public class Cartmodel
        {
            public string InsertCart(Cart Cart)
            {
                try
                {
                    firstdbEntities1 db = new firstdbEntities1();
                    db.Carts.Add(Cart);
                    db.SaveChanges();
                    return Cart.datepurchased + "was sucessfully inserted";
                }
                catch (Exception e)
                {
                    return "Error:" + e;
                }

            }
            public string UpdateCart(int Id, Cart Cart)
            {
                try
                {
                    firstdbEntities1 db = new firstdbEntities1();
                    // Fetch object from db
                    Cart p = db.Carts.Find(Id);
                    p.datepurchased = Cart.datepurchased;
                    p.Clientid = Cart.Clientid;
                    p.isincart = Cart.isincart;
                    p.productid= Cart.productid;
                    db.SaveChanges();
                    return Cart.datepurchased + "was sucessfully updated";



                }
                catch (Exception e)
                {
                    return "Error:" + e;
                }


            }
            public string DeleteCart(int id)
            {
                try
                {
                    firstdbEntities1 db = new firstdbEntities1();
                    Cart Cart = db.Carts.Find(id);
                    db.Carts.Attach(Cart);
                    db.Carts.Remove(Cart);
                    db.SaveChanges();
                    return Cart.datepurchased + "was sucessfully deleted";
                }
                catch (Exception e)
                {
                    return "Error:" + e;
                }

            }

        }
    }