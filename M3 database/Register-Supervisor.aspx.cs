using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M3_database
{
    public partial class Register_Supervisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signupclick(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Hazoum"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand sign = new SqlCommand("supervisorRegister", conn);
            sign.CommandType = CommandType.StoredProcedure;
            string firstname1 = firstname.Text;
            string lastname1 = lastname.Text;
            string password1 = password.Text;
            string faculty1 = faculty.Text;
            string email1 = email.Text;
            sign.Parameters.Add(new SqlParameter("@first_name", firstname1));
            sign.Parameters.Add(new SqlParameter("@last_name", lastname1));
            sign.Parameters.Add(new SqlParameter("@password", password1));
            sign.Parameters.Add(new SqlParameter("@faculty", faculty1));
            sign.Parameters.Add(new SqlParameter("@email", email1));
            conn.Open();
            sign.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("login.aspx");
        }
    }
}