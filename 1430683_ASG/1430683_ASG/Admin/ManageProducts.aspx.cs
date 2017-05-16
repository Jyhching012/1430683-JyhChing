using _1430683_ASG.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1430683_ASG.Admin
{
    public partial class ManageProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetImages();

                if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    FillPage(id);
                }

            }
                
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            GpuModel gpuModel = new GpuModel();
            Product product = CreateProduct();
            //will check id parameter
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //if there will edit the row
                int id = Convert.ToInt32(Request.QueryString["id"]);
                lblResult.Text = gpuModel.UpdateProduct(id, product);
            }
            else
            {
                //if id notthere will create a new row
                lblResult.Text = gpuModel.InsertProduct(product);
            }

        }

        private void FillPage(int id)
        {
            GpuModel gpuModel = new GpuModel();
            Product product = gpuModel.GetProduct(id);

            txtDescription.Text = product.Descriptionofgpu;
            txtName.Text = product.GpuName;
            txtPrice.Text = product.GpuId.ToString();

            ddlImage.SelectedValue = product.Image;
            ddlType.SelectedValue = product.GpuId.ToString();

        }

        private void GetImages()
        {
            try
            {
                string[] images = Directory.GetFiles(Server.MapPath("~/Image/Products/"));

                ArrayList imageList = new ArrayList();
                foreach (string image in images)
                {
                    string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                    imageList.Add(imageName);
                }

                ddlImage.DataSource = imageList;
                ddlImage.AppendDataBoundItems = true;
                ddlImage.DataBind();
            }
            catch (Exception e)
            {
                lblResult.Text = e.ToString();
            }
        }
        private Product CreateProduct()
        {Product product = new Product();

            product.GpuName = txtName.Text;
            product.Price = Convert.ToInt32(txtPrice.Text);
            product.GpuId = Convert.ToInt32(ddlType.SelectedValue);
            product.Descriptionofgpu = txtDescription.Text;
            product.Image = ddlImage.SelectedValue;

            return product;


        }

        
    }
}