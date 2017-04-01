using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsPro
{
    public partial class SurveyComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bool contact = false;
                contact = Convert.ToBoolean(Session["Contact"]);

                if (contact)
                {
                    lblMessage.Text = "A customer service representative will contact you within 24 hours.";
                }
            }
        }

        protected void btnReturnServey_Click(object sender, EventArgs e)
        {
            Response.Redirect("Surveys.aspx");
        }
    }
}