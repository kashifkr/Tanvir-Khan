using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FbLoginDemo.BLL;
using System.Web.Security;

namespace FbLoginDemo.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }

        protected void LoginUser_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = UserName.Text;
            var user = new UserRepository().Get(UserName.Text, Password.Text);
            if (user != null)
            {

                Session["UserID"] = user.uid;
                FormsAuthentication.RedirectFromLoginPage(user.username, RememberMe.Checked);
            }
            else
            {
                FailureText.Text = "Username or password is incorrect";
            }
        }
    }
}
