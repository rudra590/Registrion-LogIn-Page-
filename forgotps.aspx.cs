using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class forgotps : System.Web.UI.Page
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
    protected void senps2_Click(object sender, EventArgs e)
    {
        //if (IsPostBack)
        //{
        //    string email = Request.QueryString["email"];
        //    string secques = Request.QueryString["secques"];
        //    string secans = Request.QueryString["secand"];
        //}
        if (IsPostBack)
        {
            string userps = Request.QueryString["userid"];
            mycon();
            cmd = new SqlCommand("update registrion set pasword=@ps,confirmps=@conps where regid = @userid", con);
            cmd.Parameters.AddWithValue("@ps", fognewps.Text);
            cmd.Parameters.AddWithValue("@conps", fognewcon.Text);
            cmd.Parameters.AddWithValue("@userid", userps);
            cmd.ExecuteNonQuery();
         
            con.Close();
            Response.Write("<script>alert('successfully change pasword')</script>");
            Response.Redirect("reg.aspx");
        }
     
        
    }
}