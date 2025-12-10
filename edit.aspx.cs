using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class edit : System.Web.UI.Page
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
        if (!IsPostBack)
        {
            
        if (Session["registrion"] != null)
        {
            string edituser = Session["registrion"].ToString();
            mycon();
            cmd = new SqlCommand("select * from registrion where regid=@regid", con);
            cmd.Parameters.AddWithValue("@regid", edituser);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

               txtregname.Text = ds.Tables[0].Rows[0]["name"].ToString();
               regemail.Text = ds.Tables[0].Rows[0]["email"].ToString();
               regmob.Text = ds.Tables[0].Rows[0]["mob"].ToString();
               string[] dob = ds.Tables[0].Rows[0]["dob"].ToString().Split('/');
               regdate.Text = dob[0];
               regmonth.Text = dob[1];
               regyear.Text = dob[2];
               Image1.ImageUrl= ds.Tables[0].Rows[0]["img"].ToString();
               RadioButtonList1.Text = ds.Tables[0].Rows[0]["gen"].ToString();

               Paneledit.Visible = true;

            }
            con.Close();
        }

        }
       
    }
    protected void up_Click(object sender, EventArgs e)
    {
        if (Session["registrion"] != null)
        { 
            string regupdate = Session["registrion"].ToString();
            mycon();
            string path = "";
            cmd = new SqlCommand("update registrion set name=@nm,email=@em,mob=@mob,dob=@dob,img=@img,gen=@gen where regid=@regid", con);
            cmd.Parameters.AddWithValue("@nm", txtregname.Text);
            cmd.Parameters.AddWithValue("@em", regemail.Text);
            cmd.Parameters.AddWithValue("@mob", regmob.Text);
            cmd.Parameters.AddWithValue("@dob", regdate.Text + "/" + regmonth.Text + "/" + regyear.Text);
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/img/" + FileUpload1.FileName));
                path = "~/img/" + FileUpload1.FileName;
            }
            else
            {
                path = Image1.ImageUrl;
            }
            cmd.Parameters.AddWithValue("@img", path);
            cmd.Parameters.AddWithValue("@gen", RadioButtonList1.Text);
             cmd.Parameters.AddWithValue("@regid", regupdate);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('successfully update your data')</script>");

            Response.Redirect("reg.aspx");
        }
       
    }
}
