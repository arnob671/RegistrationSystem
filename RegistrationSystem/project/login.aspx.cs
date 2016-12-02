using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace project
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Session["username"] = TextBox1.Text;
            string CS = "Data source=.; database =project; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text!="" && TextBox2.Text!="" && TextBox3.Text!="" && TextBox2.Text==TextBox3.Text)
            {
                string CS = "Data source=.; database =project; integrated security=SSPI";
                SqlConnection con = new SqlConnection(CS);
                SqlCommand cmd = new SqlCommand(@"insert into admin(admin_name,password,confirm_password) 
                values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("Successfully added");
                //Label4.Text = "Successfully Added";

                SqlCommand cmds = new SqlCommand(@"select * from admin", con);
                con.Open();

                Response.Redirect("~/log.aspx");
                con.Close();

               

            }
            else
            {
                Label4.Text="Invalid";
            }

        }

       

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/log.aspx");
        }

        

        

       
       
                

      }
               
                
               
                
            
            
        
           
            

            
}

        
    
