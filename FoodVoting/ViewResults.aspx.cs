using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace FoodVoting
{
    public partial class ViewResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String pollID = Request.QueryString["PollID"];

            DisplayResults();

            lblShareLink.Text = "groupvoter.com/Vote.aspx?PollID=" + pollID;
        }


        protected void DisplayResults()
        {
            String pollID = Request.QueryString["PollID"];


            //Put all Poll Option into String array

            List<string> options = new List<string>();

            string connectionString = "Data Source=198.71.226.2;Initial Catalog=FoodVoting;User ID=Josiah;Password=admin1234";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sqlQuery = "SELECT DISTINCT Poll_Option FROM FoodVoter.Poll_Options WHERE Poll_ID = '" + pollID + "'";

            SqlCommand command = new SqlCommand(sqlQuery, conn);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                options.Add((string)reader["Poll_Option"]);
            }

            conn.Close();

            
            //Show all answers and the vote amounts

            foreach(String option in options)
            {
                //create the labels

                Label optionLabel = new Label();
                optionLabel.ID = "lbl" + option;
                optionLabel.Text = option;
                pnlResults.Controls.Add(optionLabel);
                //I HATE CSS!!!!!!!!!!! ELVES FORMAT THIS FOR ME!!!!!!


                //get the number of votes for this option
                sqlQuery = "SELECT SUM(Vote_Value) AS 'Sum' FROM FoodVoter.Votes WHERE Poll_ID = @PollID AND Poll_Option = @PollOption";

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.Add("@PollID", SqlDbType.VarChar);
                cmd.Parameters.Add("@PollOption", SqlDbType.VarChar);
                cmd.Parameters["@PollID"].Value = pollID;
                cmd.Parameters["@PollOption"].Value = option;
                
                try
                {
                    conn.Open();
                    int sum = (Int32)cmd.ExecuteScalar();
                    Label sumLabel = new Label();
                    sumLabel.ID = "lbl" + option + "Sum";
                    sumLabel.Text = sum.ToString();
                    pnlResults.Controls.Add(sumLabel);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }




            }


        }



    }
}