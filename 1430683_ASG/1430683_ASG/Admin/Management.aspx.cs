using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1430683_ASG.Admin
{
    public partial class Management : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grdProducts_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //GetRows
            GridViewRow row = grdProducts.Rows[e.NewEditIndex];
            //get id of product
            int rowId = Convert.ToInt32(row.Cells[1].Text);
            //Send user to manageproduct along with  the selected rowid
            Response.Redirect("~/Admin/ManageProducts.aspx?id=" + rowId);

        }
    }
}