using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace project
{
    public partial class user : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Label9.Text = Session["username"].ToString();
            
            string CS = "Data source=.; database =project; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmds = new SqlCommand(@"select * from emp", con);
            con.Open();
            GridView1.DataSource = cmds.ExecuteReader();
            GridView1.DataBind();

            con.Close();




           

              if (!IsPostBack)
            {
                if (Cache["DATASET"] == null)
                {
                    this.LoadDataFromDatabase();
                }
                
                else
                {
                    this.LoadDataFromCache();
                }
            }
        }
        private void LoadDataFromCache()
        {
            DataSet ds = (DataSet)Cache["DATASET"];
            GridView1.DataSource = ds.Tables["emp"];
            GridView1.DataBind();
        }

        private void LoadDataFromDatabase()
        {
            string CS = "Data source=.; database =project; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            con.Open();

            string sql = "SELECT * FROM emp";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "emp");
            Cache["DATASET"] = ds;
            Cache["ADAPTER"] = adapter;
       
            GridView1.DataSource = ds.Tables["emp"];
            GridView1.DataBind();
        }
        


           
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = "Data source=.; database =project; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);     
            string sqlCommandForUserID = "Select * from emp where user_id='" + TextBox3.Text + "'";
            
            con.Open();
            
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommandForUserID, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable ds = new DataTable();

            adapter.Fill(ds);
            if (ds.Rows.Count > 0)
            {
               LabelAddUserErrorBox.Text="User Adready Exists"; 
            }

            else
            {
                SqlCommand cmds = new SqlCommand( @"insert into emp(user_id,user_name,user_role,emp_name,status) values('"+TextBox3.Text+"','" + TextBox1.Text + "','" + DropDownList3.SelectedItem + "','" + TextBox2.Text + "','" + DropDownList4.SelectedItem + "')",con);    
                cmds.ExecuteNonQuery();
                con.Close();
                SqlCommand cmd = new SqlCommand(@"select * from emp", con);

                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                con.Close();
                Response.Write("added");
            }
        }

         
        

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/user.aspx"); 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string CS = "Data source=.; database =project; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand(@"DELETE   from emp where user_id= '"+TextBox3.Text+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            SqlCommand cmds = new SqlCommand(@"select * from emp", con);
            con.Open();
            GridView1.DataSource = cmds.ExecuteReader();
            GridView1.DataBind();

            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            string CS = "Data source=.; database =project; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand(@"select * from emp where user_id like '"+TextBox3.Text+"' or user_name like '" + TextBox1.Text + "%'", con);
            con.Open();

            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            
            con.Close();
            Response.Write("Deleted");

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/job.aspx");
        }

       

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {
            Session.Remove("username");

            Response.Redirect("~/log.aspx");
        }

       

        

       

     
       
       

       
    }
}