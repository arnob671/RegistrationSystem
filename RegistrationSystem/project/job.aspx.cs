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
    public partial class job : System.Web.UI.Page
    {  
        
           

        
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "Data source=.; database =project; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            con.Open();

            SqlCommand cmds = new SqlCommand(@"select * from job", con);
           // con.Open();
            GridView2.DataSource = cmds.ExecuteReader();
            GridView2.DataBind();

            con.Close();
            Label11.Text = Session["username"].ToString();

            /*string CS = "Data source=.; database =project; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            SqlCommand cmds = new SqlCommand(@"select job_titles from job", con);

            GridView2.DataSource = cmds.ExecuteReader();
            GridView2.DataBind();

            con.Close();*/

            


           /* if (!IsPostBack)
            {
                if (Cache["DATASET"] == null)
                {
                    Label10.Text = "Load from Database";
                    this.LoadDataFromDatabase();
                }

                else
                {
                    Label10.Text = "Load from cache";
                    this.LoadDataFromCache();
                }
            }*/
        }
        /*private void LoadDataFromDatabase()
        {
            string CS = "Data source=.; database =project; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            con.Open();

            SqlCommand cmds = new SqlCommand(@"select * from job", con);
             con.Open();
            GridView2.DataSource = cmds.ExecuteReader();
            GridView2.DataBind();

           /* string CS = "Data source=.; database =project; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            con.Open();

            string sql = "SELECT * FROM job";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "job");
            Cache["DATASET"] = ds;
            Cache["ADAPTER"] = adapter;

            GridView2.DataSource = ds.Tables["emp"];
            GridView2.DataBind();

       } 
        
        private void LoadDataFromCache()
        {
            DataSet ds = (DataSet)Cache["DATASET"];
            GridView2.DataSource = ds.Tables["job"];
            GridView2.DataBind();
        }*/

        

    
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = "Data source=.; database =project; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand(@"insert into job(job_titles) values('" + TextBox4.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            SqlCommand cmds = new SqlCommand(@"select * from job", con);
            con.Open();
            GridView2.DataSource = cmds.ExecuteReader();
            GridView2.DataBind();

            con.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string CS = "Data source=.; database =project; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand(@"DELETE  from job where job_titles= '" + TextBox4.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            SqlCommand cmds = new SqlCommand(@"select * from job", con);
            con.Open();
            GridView2.DataSource = cmds.ExecuteReader();
            GridView2.DataBind();

            con.Close();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/user.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            
            Session.Remove("username");
            Response.Redirect("~/login.aspx");
        }
    

        
    }
}