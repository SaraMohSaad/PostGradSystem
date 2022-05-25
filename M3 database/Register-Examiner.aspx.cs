using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M3_database
{
    public partial class Register_Examiner : System.Web.UI.Page
    {
        static int bit;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void national_CheckedChanged(object sender, EventArgs e)
        {
            bit = 1;
        }

        protected void international_CheckedChanged(object sender, EventArgs e)
        {
            bit = 0;
        }
        protected void signupclick(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string name1 = name.Text;
            string fieldoofwork1 = fieldOfWork.Text;
            string password1 = password.Text;
            string email1 = email.Text;

            SqlCommand insert = new SqlCommand("INSERT INTO PostGradUser values ('" + email1 + "','" + password1 + "')", conn);
            conn.Open();

            insert.ExecuteNonQuery();
            conn.Close();

            SqlCommand id = new SqlCommand("SELECT id from PostGradUser where email = '" + email1 + "'", conn);

            conn.Open();

            id.ExecuteNonQuery();
            int resultt = (int) id.ExecuteScalar();
            conn.Close();

            conn.Open();

            if (bit == 1)
            {
                SqlCommand insertexaminer = new SqlCommand("INSERT INTO Examiner Values ('" + resultt + "' , '" + name1 + "' , '" + fieldoofwork1 + "', 1 )", conn);

                insertexaminer.ExecuteNonQuery();
            }
            else if (bit == 0)
            {
                SqlCommand insertexaminer = new SqlCommand("INSERT INTO Examiner Values ('" + resultt + "','" + name1 + "' , '" + fieldoofwork1 + "', 0 )", conn);
                insertexaminer.ExecuteNonQuery();

            }
            conn.Close();

            Session["ExaminerID"] = resultt;

            Response.Redirect("login.aspx");
        }

}
}