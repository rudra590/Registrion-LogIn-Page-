using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Otp : System.Web.UI.Page

{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
      

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            string sentotp = Request.QueryString["otp"];
            string userid = Request.QueryString["userid"];
            string enterotp = TextBox1.Text+ "" + TextBox2.Text + "" + TextBox3.Text + "" + TextBox4.Text;
            if (sentotp==enterotp)
            {
                Response.Write("<script>alert('verfied successfully')</script>");
                Response.Redirect("forgotps.aspx?userid=" + userid);
            }
            else
            {

                Response.Write("<script>alert('please check the otp ')</script>");

            }
        }
    }
}