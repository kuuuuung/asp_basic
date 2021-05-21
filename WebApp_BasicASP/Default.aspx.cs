using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

namespace WebApp_BasicASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            HttpCookie ck = Request.Cookies["Hello"];
            String str = "";
            if (ck == null)
            {
                lbl1.Text = "Hello : Guest";
            }
            else
            {
                lbl2.Text = "Hello :" + ck["Name"];
                str += "<br> เข้าชมล่าสุด " + ck["LastVisited"];
                lbl1.Text = str;
            }
            */


        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            //URL และตัวแปรที่จะส่งไป
            String url = "View.aspx?name="+TextBox1.Text+"&lname="+TextBox2.Text;
            Response.RedirectPermanent(url);
        }


        /*
        protected void cmdAdd_Click(object sender, EventArgs e)
        {
            HttpCookie ck = Request.Cookies["Hello"];
            String str = "";
            if (ck == null)
            {
                ck = new HttpCookie("Hello");
            }
            ck["Name"] = txtName.Text;
            ck["LastVisited"] = DateTime.Now.ToString();
            ck.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(ck);
        }*/
    }
}