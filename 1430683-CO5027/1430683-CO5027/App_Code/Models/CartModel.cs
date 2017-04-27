using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1430683_CO5027.App_Code.Models
{
    public class CartModel
    {

        public string InsertCart(GVGCart cart)
        {
            try
            {
                db_1430683_co5027_productEntities1 db = new db_1430683_co5027_productEntities1();
                db.GVGCarts.Add(cart);
                db.SaveChanges();

                return cart.DatePurchased + "was successfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }


        }

        public string UpdateCart(int id, GVGCart GVGCart)
        {
            try
            {
                db_1430683_co5027_productEntities1 db = new db_1430683_co5027_productEntities1();

                //Retrieve from database
                GVGCart p = db.GVGCarts.Find(id);

                p.DatePurchased = GVGCart.DatePurchased;
                p.CustomerId = GVGCart.CustomerId;
                p.AmountCost = GVGCart.AmountCost;
                p.ItemsInCart = GVGCart.ItemsInCart;
                p.GpuID = GVGCart.GpuID;

                db.SaveChanges();
                return GVGCart.DatePurchased + "was successfully updated";



            }
            catch (Exception e)
            {
                return "Error:" + e;
            }


        }

        public string DeleteGVGCart(int id)
        {
            try
            {
                db_1430683_co5027_productEntities1 db = new db_1430683_co5027_productEntities1();
                GVGCart GVGCart = db.GVGCarts.Find(id);

                db.GVGCarts.Attach(GVGCart);
                db.GVGCarts.Remove(GVGCart);
                db.SaveChanges();

                return GVGCart.DatePurchased + "was successfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }


        }
    }
}