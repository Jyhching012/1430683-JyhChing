using _1430683_ASG.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1430683_ASG.Pages
{
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        private void FillPage()
        {
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                GpuModel gpuModel = new GpuModel();
                Product product = gpuModel.GetProduct(id);

                //fill data
                lblPrice.Text = "Price per unit: <br/>$" + product.Price;
                lblTitle.Text = product.GpuName;
                lblDescription.Text = product.Descriptionofgpu;
                lblItemNumber.Text = id.ToString();
                imgProduct.ImageUrl = "~/Image/Products/" + product.Image;

                int[] amount = Enumerable.Range(1, 20).ToArray();
                ddlAmount.DataSource = amount;
                ddlAmount.AppendDataBoundItems = true;
                ddlAmount.DataBind();


            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                string CustomerId = Context.User.Identity.GetUserId();

                if(CustomerId != null)
                { 
                int id = Convert.ToInt32(Request.QueryString["id"]);
                int amount = Convert.ToInt32(ddlAmount.SelectedValue);

                GVGCart cart = new GVGCart
                {
                    AmountCost = amount,
                    CustomerId = CustomerId,
                    DatePurchased = DateTime.Now,
                    ItemsInCart = true,
                    GpuID = id
                };

                CartModel model = new CartModel();
                lblResult.Text = model.InsertCart(cart);
                }
                else
                {
                    lblResult.Text = "You must Log In to order items";
                }

            }
        }
    }
}