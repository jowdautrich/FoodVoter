using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodVoting
{
    public partial class CreatePoll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreatePoll_Click(object sender, EventArgs e)
        {

            //Create Poll ID
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            String pollID = new String(stringChars);



            //Add new into DB with given items
            string connectionString = "Data Source=198.71.226.2;Initial Catalog=FoodVoting;User ID=Josiah;Password=admin1234";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sqlQuery = "INSERT INTO FoodVoter.Poll_Options VALUES";
            Boolean emptyQuery = true;

            if(!tbOption1.Text.Equals(""))
            {
                sqlQuery += "('" + pollID + "', '" + tbOption1.Text + "')";
                emptyQuery = false;
            }
            if(!tbOption2.Text.Equals(""))
            {
                sqlQuery += ", ('" + pollID + "', '" + tbOption2.Text + "')";
                emptyQuery = false;
            }
            if (!tbOption3.Text.Equals(""))
            {
                sqlQuery += ", ('" + pollID + "', '" + tbOption3.Text + "')";
                emptyQuery = false;
            }
            if (!tbOption4.Text.Equals(""))
            {
                sqlQuery += ", ('" + pollID + "', '" + tbOption4.Text + "')";
                emptyQuery = false;
            }
            if (!tbOption5.Text.Equals(""))
            {
                sqlQuery += ", ('" + pollID + "', '" + tbOption5.Text + "')";
                emptyQuery = false;
            }

            if(!emptyQuery)
            {
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                conn.Close();
            }

            //Go to the view results page
            Response.Redirect("ViewResults.aspx?PollId=" + pollID);


        }
    }
}