using _1430683_ASG.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1430683_ASG.Pages.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();

            userStore.Context.Database.Connection.ConnectionString =
                System.Configuration.ConfigurationManager.ConnectionStrings["db_1430683_co5027_productConnectionString"].ConnectionString;

            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

            //Create new user and try store in db

            IdentityUser user = new IdentityUser();
            user.UserName = txtUserName.Text;

            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                try
                {
                    //Create user object
                    //DB will be created /  expanded autoomatically
                    IdentityResult result = manager.Create(user, txtPassword.Text);

                    if(result.Succeeded)
                    {
                        InformationOfUser info = new InformationOfUser
                        {
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            Address = txtAddress.Text,
                            PostalCode = Convert.ToInt32(txtPostCode.Text),
                            GUID = user.Id


                        };

                        InfoUserModel model = new InfoUserModel();
                        model.InsertInformationOfUser(info);
                          

                        //store in db
                        var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

                        //Set to log in new user by cookie
                        var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                        //Log in the new user and redirect to homepage
                        authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                        Response.Redirect("~/default.aspx");


                    }
                    else
                    {
                        litStatus.Text = result.Errors.FirstOrDefault();
                    }

                }
                catch(Exception ex)
                {
                    litStatus.Text = ex.ToString();
                }
            }
            else
            {
                litStatus.Text = "Password does not match";
            }

        }
    }
}