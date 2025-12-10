using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
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



        if (Session["registrion"] != null)
        {
            string registrionid = Session["registrion"].ToString();
            mycon();
            cmd = new SqlCommand("select * from registrion where regid=@regid", con);
            cmd.Parameters.AddWithValue("@regid", registrionid);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                panellogin.Visible = false;
                panelwelcome.Visible = true;
                Image1.ImageUrl = ds.Tables[0].Rows[0]["img"].ToString();
                Label1.Text =  ds.Tables[0].Rows[0]["name"].ToString();
                Image1.ImageUrl = ds.Tables[0].Rows[0]["img"].ToString();

            }

           con.Close();
            

        }
        
        

    }
    protected void homesum_Click(object sender, EventArgs e)
    {
        mycon();
        {
            cmd = new SqlCommand("select regid from registrion where email=@em and pasword=@ps",con);
            cmd.Parameters.AddWithValue("@em",homeem.Text);
            cmd.Parameters.AddWithValue("@ps", homeps.Text);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)

            {
                Session["registrion"] = ds.Tables[0].Rows[0]["regid"].ToString();
                Response.Write("<script>alert('Success full login')</script>");
                homeem.Text = "";
                homeem.Text = "";
               
                Response.Redirect("reg.aspx"); 
               
         
            }
            else
            {
                Response.Write("<script>alert('please check pasword or emai is allready exixet')</script>");

            }
            cmd.ExecuteNonQuery();
            con.Close();
            homeem.Text = "";
            homeem.Text = "";

        }

    }
  
    //protected void Editbtn(object sender, EventArgs e)
    //{
    //    mycon();
    //    {
    //        cmd = new SqlCommand("select * from registrion where regid=@rid", con);

    //        da = new SqlDataAdapter(cmd);
    //        ds = new DataSet();
    //        da.Fill(ds);
    //        if (ds.Tables[0].Rows.Count > 0)
    //        {

    //            regname.Text = ds.Tables[0].Rows[0]["name"].ToString();
    //        }
    //        con.Close();

    //    }
    //}
    
    protected void btnlogOut_Click1(object sender, EventArgs e)
    {
        Session.Clear();
        panelwelcome.Visible = false;
        panellogin.Visible = true;
    }
}
