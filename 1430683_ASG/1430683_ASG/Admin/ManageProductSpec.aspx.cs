using _1430683_ASG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1430683_ASG.Admin
{
    public partial class ManageProductSpec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            GpuSpecsModel model = new GpuSpecsModel();
            ProductSpec pt = createProductSpec();

            lblResult.Text = model.Insertproductspec(pt);
        }
        private ProductSpec createProductSpec()
        {
            ProductSpec p = new ProductSpec();
            p.GpuName = txtName.Text;

            return p;
        }
    }
}