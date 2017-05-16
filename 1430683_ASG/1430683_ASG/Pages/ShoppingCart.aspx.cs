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
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get id of current logged in user and display items in cart
            string userId = User.Identity.GetUserId();
            GetPurchasesInCart(userId);
        }

        private void GetPurchasesInCart(string userId)
        {
            CartModel model = new CartModel();
            double subTotal = 0;

            List<GVGCart> purchaseList = model.GetOrdersInCart(userId);
            CreateShopTable(purchaseList, out subTotal);

            //Add totals to webpage
            double vat = subTotal * 0.10;
            double totalAmount = subTotal + vat + 10;

            //shows the amount on page
            litTotal.Text = "$" + subTotal;
            litVat.Text = "$" + vat;
            litTotalAmount.Text = "$" + totalAmount;
        }

        private void CreateShopTable(List<GVGCart> purchaseList, out double subTotal)
        {
            subTotal = new double();
            GpuModel model = new Models.GpuModel();

            foreach (GVGCart gvgcart in purchaseList)
            {
                Product product = model.GetProduct(gvgcart.GpuID);

                //Create the image  button
                ImageButton btnImage = new ImageButton
                {
                    ImageUrl = string.Format("~/Image/Products/{0}", product.Image),
                    PostBackUrl = string.Format("~/Pages/product.aspx?id={0}", product.ID)
                };

                //Create the delete link
                LinkButton linkDelete = new LinkButton
                {
                    PostBackUrl = string.Format("~/Pages/ShoppingCart.aspx?productId={0}", gvgcart.ID),
                    Text = "Delete Item",
                    ID = "del" + gvgcart.ID
                };

                //Add an OnClick Event
                linkDelete.Click += Delete_Item;

                //Create the quantity dropdownlist
                //Generate list  with numer from 1 to 20
                int[] amount = Enumerable.Range(1, 20).ToArray();
                DropDownList ddlAmount = new DropDownList
                {
                    DataSource = amount,
                    AppendDataBoundItems = true,
                    AutoPostBack = true,
                    ID = gvgcart.ID.ToString()
                };

                ddlAmount.DataBind();
                ddlAmount.SelectedValue = gvgcart.AmountCost.ToString();
                ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;

                //Create HTML table with 2 rows
                Table table = new Table { CssClass = "cartTable" };
                TableRow a = new TableRow();
                TableRow b = new TableRow();

                //Create 6 cells for row a
                TableCell a1 = new TableCell { RowSpan = 2, Width = 50 };
                TableCell a2 = new TableCell
                {
                    Text = string.Format("<h4>{0}</h4><br/>{1}<br/>In Stock",
                    product.GpuName, "Item No: " + product.ID),
                    HorizontalAlign = HorizontalAlign.Left,
                    Width = 350
                };
                TableCell a3 = new TableCell { Text = "Unit Price<hr/>" };
                TableCell a4 = new TableCell { Text = "Quantity<hr/>" };
                TableCell a5 = new TableCell { Text = "Item Total<hr/>" };
                TableCell a6 = new TableCell { };

                //Create 6 cells for row b
                TableCell b1 = new TableCell { };
                TableCell b2 = new TableCell { Text = "$" + product.Price };
                TableCell b3 = new TableCell { };
                TableCell b4 = new TableCell { Text = "$" + Math.Round((gvgcart.AmountCost * (double)product.Price), 2) };
                TableCell b5 = new TableCell { };
                TableCell b6 = new TableCell { };

                a1.Controls.Add(btnImage);
                a6.Controls.Add(linkDelete);
                b3.Controls.Add(ddlAmount);

                a.Cells.Add(a1);
                a.Cells.Add(a2);
                a.Cells.Add(a3);
                a.Cells.Add(a4);
                a.Cells.Add(a5);
                a.Cells.Add(a6);

                b.Cells.Add(b1);
                b.Cells.Add(b2);
                b.Cells.Add(b3);
                b.Cells.Add(b4);
                b.Cells.Add(b5);
                b.Cells.Add(b6);

                // add row to table
                table.Rows.Add(a);
                table.Rows.Add(b);

                //add table to pnlshoppingcart
                pnlShopCart.Controls.Add(table);

                //add total amount of item in cart to subtotal
                subTotal += (gvgcart.AmountCost * (double)product.Price);
            

            }

            // add current user's shopping cart to user specification session value
            Session[User.Identity.GetUserId()] = purchaseList;
        }

        private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList selectedList = (DropDownList)sender;
            int quantity = Convert.ToInt32(selectedList.SelectedValue);
            int gvgcartId = Convert.ToInt32(selectedList.ID);

            GVGCart model = new GVGCart();
            model.UpdateQuantity(gvgcartId, quantity);

            Response.Redirect("~/Pages/ShoppingCart.aspx");

        }

        private void Delete_Item(object sender, EventArgs e)
        {
            LinkButton selectedLink = (LinkButton)sender;
            string link = selectedLink.ID.Replace("del", "");
            int gvgcartId = Convert.ToInt32(link);

            CartModel model = new CartModel();
            model.DeleteGVGCart(gvgcartId);

            Response.Redirect("~/Pages/ShoppingCart.aspx");
        }

        
            
    }
}