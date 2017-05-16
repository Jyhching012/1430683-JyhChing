using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1430683_ASG.Models
{
    public class CartModel
    {

        public string InsertCart(GVGCart cart)
        {
            try
            {
                db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
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
                db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();

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
                db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
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

        public List<GVGCart>GetOrdersInCart(string userId)
        {
            db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
            List<GVGCart> orders = (from x in db.GVGCarts
                                    where x.CustomerId == userId
                                    && x.ItemsInCart
                                    orderby x.DatePurchased
                                    select x).ToList();

            return orders;
        }

        public int GetAmountOfOrders(string userId)
        {
            try
            {
                db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
                int amount = (from x in db.GVGCarts
                              where x.CustomerId == userId
                              && x.ItemsInCart
                              select x.AmountCost).Sum();

                return amount;
            }
            catch
            {
                return 0;
            }
        }

        public void UpdateQuantity(int id, int quantity)
        {
            db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
            GVGCart GVGCart = db.GVGCarts.Find(id);
            GVGCart.AmountCost = quantity;

            db.SaveChanges();
        }

        public void MarkOrdersAsPaid(List<GVGCart> gvgcarts)
        {
            db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();

            if(gvgcarts !=null)
              {
                foreach(GVGCart gvgcart in gvgcarts)
                {
                    GVGCart oldCart = db.GVGCarts.Find(gvgcart.ID);
                    oldCart.DatePurchased = DateTime.Now;
                    oldCart.ItemsInCart = false;
                }

                db.SaveChanges();
            }  
        }


    }
}