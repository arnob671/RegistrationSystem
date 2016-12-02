using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class log : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!IsPostBack)
            {
              
                if (Request.Cookies["username"] != null)
                    TextBox4.Text = Request.Cookies["username"].Value;
                if (Request.Cookies["password"] != null)
                    TextBox5.Attributes.Add("value", Request.Cookies["password"].Value);
                if (Request.Cookies["username"] != null && Request.Cookies["password"] != null)
                    CheckBox1.Checked = true;
            }

           
           

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            

            string CS = "Data source=.; database =project; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            con.Open();

            string sql = "Select * from admin where admin_name='" + TextBox4.Text + "' and password ='" + TextBox5.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable ds = new DataTable();

            adapter.Fill(ds);
            
            if (ds.Rows.Count > 0)
            {
                if (CheckBox1.Checked == true)
                {
                    Session["username"] = TextBox4.Text;
                    Session["password"] = TextBox5;
                    //Response.Redirect("~/user.aspx");
                    Response.Cookies["username"].Value = TextBox4.Text;
                    Response.Cookies["password"].Value = TextBox5.Text;
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(15);
                    Response.Cookies["password"].Expires = DateTime.Now.AddDays(15);
                }
                else
                {
                    Session["username"] = TextBox4.Text;
                    Session["password"] = TextBox5.Text;
                   
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["password"].Expires = DateTime.Now.AddDays(-1);
                }

                Response.Redirect("~/user.aspx");
            }

            else
            {
               
                Label7.Text = "Wrong User Name or Password";
               // Response.Redirect("log.aspx");
            }
        }

        

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }

        
    }
}