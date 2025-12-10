using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class welcome : System.Web.UI.Page
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
    void fillgrid()
{
    mycon();
    {
        cmd = new SqlCommand("select * from registrion");
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        con.Close();



    }
}
    protected void Page_Load(object sender, EventArgs e)
    {
        //fillgrid();
        //mycon();
        //{
        //    cmd = new SqlCommand("select * from registrion where regid=@reg)", con);
        //    da = new SqlDataAdapter(cmd);
        //    ds = new DataSet();
        //    da.Fill(ds);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        Image1.ImageUrl = ds.Tables[0].Rows[0]["img"].ToString();

        //    }
        //}

        if (Session["registrion"]!=null)
        {
            //int Diya = Session["registrion"].T
        }


    }
    protected void logoutbtn1_Click(object sender, EventArgs e)
    {

    }
}