using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_BasicASP
{
    public partial class Received : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var firstname = Request.QueryString["txtFirstname"];
            var lastname = Request.QueryString["txtLasttname"];

            if (string.IsNullOrEmpty(firstname))
            {
                Response.RedirectPermanent("Default.aspx");
            }
            if (string.IsNullOrEmpty(lastname))
            {
                Response.RedirectPermanent("Default.aspx");
            }
            Response.Write("ชื่อ - นามสกุล : " + firstname + " " + lastname);

        }
    }
}