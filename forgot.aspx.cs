using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class forgot : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    void mycon()
    {
        con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\crudregistrion.mdf;Integrated Security=True");
        con.Open();
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void sendps1_Click(object sender, EventArgs e)
    {

        mycon();
        cmd = new SqlCommand("select * from registrion where email=@em and secques=@seqq and secans=@secans", con);
        cmd.Parameters.AddWithValue("@em", fogem.Text);
        cmd.Parameters.AddWithValue("@seqq", fogsec1.Text);
        cmd.Parameters.AddWithValue("@secans", fogsecans1.Text);

        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);

        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {

            Response.Write("<script>alert('Verified successfully. Redirecting to OTP.')</script>");
            string userid= ds.Tables[0].Rows[0]["regid"].ToString();

            Random otpvalue = new Random();
        string otp = otpvalue.Next(1000,9999).ToString();
        Response.Write("<script>alert('"+otp+"')</script>");
        Response.Redirect("otp.aspx?otp="+otp+"&userid="+userid);
        }
        else
        {

            Response.Write("<script>alert('Incorrect details. Please try again.')</script>");


        }
       
        

        con.Close();


    }
}
