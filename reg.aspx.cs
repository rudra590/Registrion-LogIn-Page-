using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// crudmdf ke sath connection karane ke liye
using System.Data;
using System.Data.SqlClient;
public partial class reg : System.Web.UI.Page
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
            cmd = new SqlCommand("select * from registrion", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        fillgrid();


    }
    protected void reg1_Click(object sender, EventArgs e)
    {
        mycon();

        cmd = new SqlCommand("select * from registrion where email=@em  or mob=@mob", con);
        cmd.Parameters.AddWithValue("@em", regemail.Text);
        cmd.Parameters.AddWithValue("@mob", regmob.Text);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Response.Write("<script>alert('thsi email or mobile allredy exixt')</script>");
        }
        else
        {
            string path = "";

            cmd = new SqlCommand("Insert into registrion values(@nm,@em,@mob,@ps,@conps,@dob,@img,@gen,@seqq,@secans)", con);
            cmd.Parameters.AddWithValue("@nm", regname.Text);
            cmd.Parameters.AddWithValue("@em", regemail.Text);
            cmd.Parameters.AddWithValue("@mob", regmob.Text);
            cmd.Parameters.AddWithValue("@ps", regpas.Text);
            cmd.Parameters.AddWithValue("@conps", regcomps.Text);
            cmd.Parameters.AddWithValue("@dob", regdate.Text + "/" + regmonth.Text + "/" + regyear.Text);
              if (FileUpload1.HasFiles)
               {
                   FileUpload1.SaveAs(Server.MapPath("~/img/" + FileUpload1.FileName));
                   path = "~/img/" + FileUpload1.FileName;
               }
            cmd.Parameters.AddWithValue("@img", path);
            cmd.Parameters.AddWithValue("@gen", RadioButtonList1.Text);
            cmd.Parameters.AddWithValue("@seqq", regq.Text);
            cmd.Parameters.AddWithValue("@secans", regsec.Text);

            cmd.ExecuteNonQuery();

            

            con.Close();
            Response.Write("<script>alert('Congratulation You Are Successfully Log In')</script>");
            regname.Text = "";
            regemail.Text = "";
            regmob.Text = "";
            regcomps.Text = "";
            regdate.SelectedIndex = 0;
            regmonth.SelectedIndex = 0;
            regyear.SelectedIndex = 0;
            RadioButtonList1.SelectedIndex = -1;
            regq.SelectedIndex = 0;
            regsec.Text = "";
            fillgrid();

        }



        con.Close();

     

    }
    protected void regmob_TextChanged(object sender, EventArgs e)
    {

    }
}
