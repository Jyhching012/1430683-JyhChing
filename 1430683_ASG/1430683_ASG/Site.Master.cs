using _1430683_ASG.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1430683_ASG
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = Context.User.Identity;

            if (user.IsAuthenticated)
            {
                litStatus.Text = Context.User.Identity.Name;

                linkLogin.Visible = false;
                linkRegister.Visible = false;

                LinkLogout.Visible = true;
                litStatus.Visible = true;

                CartModel model = new CartModel();
                string userId = HttpContext.Current.User.Identity.GetUserId();
                litStatus.Text = string.Format("{0} ({1})", Context.User.Identity.Name,
                    model.GetAmountOfOrders(userId));
            }
            else
            {
                linkLogin.Visible = true;
                linkRegister.Visible = true;

                LinkLogout.Visible = false;
                litStatus.Visible = false;
            }
        }

        protected void LinkLogout_Click(object sender, EventArgs e)
        {
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();

            Response.Redirect("~/default.aspx");

        }
    }
}