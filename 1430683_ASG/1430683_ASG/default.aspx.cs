using _1430683_ASG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1430683_ASG
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        private void FillPage()
        {
            //get ist of products in db
            GpuModel gpumodel = new GpuModel();
            List<Product> products = gpumodel.GetAllProducts();
            
            //check product in db
            if (products != null)
            {
                // create panel with imagebutton and 2 label for product
                foreach (Product product in products)
                {
                    Panel productPanel = new Panel();
                    ImageButton imageButton = new ImageButton();
                    Label lblName = new Label();
                    Label lblPrice = new Label();

                    imageButton.ImageUrl = "~/Image/Products/" + product.Image;
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/Pages/Product.aspx?id=" + product.GpuId;

                    lblName.Text = product.GpuName;
                    lblName.CssClass = "productName";

                    lblPrice.Text = "$" + product.Price;
                    lblPrice.CssClass = "productPrice";

                    //Add control to panel
                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblPrice);

                    pnlGraphic.Controls.Add(productPanel);
                
                }

            }
            else
            {
                pnlGraphic.Controls.Add(new Literal { Text = "No products found!" });
            }
        }
    }
}