using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CURD_Application
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadrecord();
            }
        }
        SqlConnection con = new SqlConnection("Data Source=CHENHPZQD;Initial Catalog=curddb;Integrated Security=True");
        protected void Button1_Click(object sender, EventArgs e)//insert
        {
            
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into curddb_table values('"+int.Parse(TextBox1.Text)+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+double.Parse(TextBox4.Text)+"','"+TextBox5.Text+"')",con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            loadrecord();

        }
        void loadrecord()
        {
            SqlCommand comm = new SqlCommand("select * from curddb_table", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)//update
        {
            con.Open();
            SqlCommand comm = new SqlCommand("update curddb_table set sname='"+TextBox2.Text+"',address='"+TextBox3.Text+"',age='"+TextBox4.Text+"',contact='"+TextBox5.Text+"' where sid ='"+int.Parse(TextBox1.Text)+"'",con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            loadrecord();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("delete from curddb_table where sid ='" + int.Parse(TextBox1.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
            loadrecord();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("select * from curddb_table where sid ='" + int.Parse(TextBox1.Text) + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("select * from curddb_table where sid ='" + int.Parse(TextBox1.Text) + "'", con);
            SqlDataReader r = comm.ExecuteReader();
            while (r.Read())
            {
                TextBox2.Text = r.GetValue(1).ToString();
                TextBox3.Text = r.GetValue(2).ToString();
                TextBox4.Text = r.GetValue(3).ToString();
                TextBox5.Text = r.GetValue(4).ToString();
            }
        }
    }
}