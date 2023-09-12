using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w13_2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("CookieLogin");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            string nome = Nome.Text;
            string password = Password.Text;

           ConfigurationManager.AppSettings["Nome"] = nome;
           ConfigurationManager.AppSettings["Password"] = password;
            if (ConfigurationManager.AppSettings["Nome"] == nome && ConfigurationManager.AppSettings["Password"]== password)
            {
            HttpCookie cookie = new HttpCookie("CookieLogin");
            cookie.Value = Nome.Text;
            cookie.Value = Password.Text;
            cookie.Expires= DateTime.Now.AddDays(10);
            Response.Cookies.Add(cookie);

              Response.Redirect("Cinema.aspx");

            }

       
        }
    }


}