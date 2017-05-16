using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1430683_ASG.Models
{
    public class GpuModel
    {
        public string InsertProduct(Product product)
        {
            try
            {
                db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
                db.Products.Add(product);
                db.SaveChanges();

                return product.GpuName + "was successfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }


        }

        public string UpdateProduct(int id, Product product)
        {
            try
            {
                db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();

                //Retrieve from database
                Product p = db.Products.Find(id);

                p.GpuName = product.GpuName;
                p.Price = product.Price;
                p.GpuId = product.GpuId;
                p.Descriptionofgpu = product.Descriptionofgpu;
                p.Image = product.Image;

                db.SaveChanges();
                return product.GpuName + "was successfully updated";



            }
            catch (Exception e)
            {
                return "Error:" + e;
            }


        }

        public string DeleteProduct(int id)
        {
            try
            {
                db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
                Product product = db.Products.Find(id);

                db.Products.Attach(product);
                db.Products.Remove(product);
                db.SaveChanges();

                return product.GpuName + "was successfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }


        }

        public Product GetProduct(int id)
        {
            try
            {
                using (db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities())
                {
                    Product product = db.Products.Find(id);
                    return product;
                }
          
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                using (db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities())
                {
                    List<Product> products = (from x in db.Products select x).ToList();
                    return products;

                }
            }
            catch (Exception)
            {
                return null;
            }

        }

        public List<Product>GetProductsByType(int gpuId)
        {
            try
            {
                using (db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities())
                {
                    List<Product> products = (from x in db.Products
                                              where x.GpuId == gpuId
                                              select x).ToList();
                    return products;

                }
            }
            catch (Exception)
            {
                return null;
            }

        }

    }
}