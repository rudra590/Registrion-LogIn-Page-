using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class changepas : System.Web.UI.Page
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
    protected void senps1_Click(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            if (Session["registrion"] != null)
            {


                string changepasword = Session["registrion"].ToString();
                mycon();
                cmd = new SqlCommand("select * from registrion where regid=@regid and pasword=@ps ", con);
                cmd.Parameters.AddWithValue("@ps", oldPas1.Text);
                cmd.Parameters.AddWithValue("@regid", changepasword);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    mycon();
                    cmd = new SqlCommand("update registrion set pasword=@ps,confirmps=@conps where regid=@regid", con);
                    cmd.Parameters.AddWithValue("@ps", chnpsnew1.Text);
                    cmd.Parameters.AddWithValue("@conps", chncomps1.Text);
                    cmd.Parameters.AddWithValue("@regid", changepasword);
                    cmd.ExecuteNonQuery();

                    Response.Write("<script>alert('pasword successfully changed')</script>");
                    con.Close();
                }
                else
                {
                    Response.Write("<script>alert('please check old pasword changed')</script>");

                }


                con.Close();
            }

        }


    }

}
