using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodVoting
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreatePoll_Click(object sender, EventArgs e)
        {
            //Redirect to Create Poll page
            Response.Redirect("CreatePoll.aspx");
        }

        protected void btnViewResults_Click(object sender, EventArgs e)
        {
            //Check if PollId is valid here

            //Redirect to View Results page with querysting from Results tb
            Response.Redirect("ViewResults.aspx?PollId=" + tbResultsId.Text);
        }

        protected void btnVote_Click(object sender, EventArgs e)
        {
            //Check if PollId is valid here

            //Redirect to Vote page with querystring from Vote tb
            Response.Redirect("Vote.aspx?PollId=" + tbVoteId.Text);
        }
    }
}