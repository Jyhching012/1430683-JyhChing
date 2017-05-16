using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1430683_ASG.Models
{
    public class GpuSpecsModel
    {
        public string Insertproductspec(ProductSpec productspec)
        {
            try
            {
                db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
                db.ProductSpecs.Add(productspec);
                db.SaveChanges();

                return productspec.GpuName + "was successfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }


        }

        public string Updateproductspec(int id, ProductSpec productspec)
        {
            try
            {
                db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();

                //Retrieve from database
                ProductSpec p = db.ProductSpecs.Find(id);

                p.GpuName = productspec.GpuName;


                db.SaveChanges();
                return productspec.GpuName + "was successfully updated";



            }
            catch (Exception e)
            {
                return "Error:" + e;
            }


        }

        public string Deleteproductspec(int id)
        {
            try
            {
                db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
                ProductSpec productspec = db.ProductSpecs.Find(id);

                db.ProductSpecs.Attach(productspec);
                db.ProductSpecs.Remove(productspec);
                db.SaveChanges();

                return productspec.GpuName + "was successfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }


        }


    }
}