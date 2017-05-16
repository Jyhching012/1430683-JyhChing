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
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<GVGCart> gvgcarts = (List<GVGCart>)Session[User.Identity.GetUserId()];

            CartModel model = new CartModel();
            model.MarkOrdersAsPaid(gvgcarts);

            Session[User.Identity.GetUserId()] = null;
        }
    }
}