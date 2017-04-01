using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsPro
{
    public partial class Surveys : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                disabledControls();
            }
        }

        private void disabledControls()
        {
            lblAddinfo.ForeColor = System.Drawing.Color.LightGray;
            lblProbRes.ForeColor = System.Drawing.Color.LightGray;
            lblRateIncident.ForeColor = System.Drawing.Color.LightGray;
            lblResTime.ForeColor = System.Drawing.Color.LightGray;
            lblTechEff.ForeColor = System.Drawing.Color.LightGray;
                        
            rblProbRes.ForeColor = System.Drawing.Color.LightGray;
            rblResponseTime.ForeColor = System.Drawing.Color.LightGray;
            rblTechEff.ForeColor = System.Drawing.Color.LightGray;

            chBxHasContacted.ForeColor = System.Drawing.Color.LightGray;

            lstBxIncidents.Enabled = false;            
            rblProbRes.Enabled = false;
            rblResponseTime.Enabled = false;
            rblTechEff.Enabled = false;
            txtAdditionalInfo.Enabled = false;
            chBxHasContacted.Enabled = false;
            btnSubmit.Enabled = false;

            lstBxIncidents.Items.Clear();

            rblContactby.ForeColor = System.Drawing.Color.LightGray;
            rblContactby.Enabled = false;

            txtCustomerId.Focus();
        }

        private void enabledControls()
        {
            lblMessage.Text = "";
            lblAddinfo.ForeColor = System.Drawing.Color.Black;
            lblProbRes.ForeColor = System.Drawing.Color.Black;
            lblRateIncident.ForeColor = System.Drawing.Color.Black;
            lblResTime.ForeColor = System.Drawing.Color.Black;
            lblTechEff.ForeColor = System.Drawing.Color.Black;
                        
            rblProbRes.ForeColor = System.Drawing.Color.Black;
            rblResponseTime.ForeColor = System.Drawing.Color.Black;
            rblTechEff.ForeColor = System.Drawing.Color.Black;

            chBxHasContacted.ForeColor = System.Drawing.Color.Black;

            lstBxIncidents.Enabled = true;            
            rblProbRes.Enabled = true;
            rblResponseTime.Enabled = true;
            rblTechEff.Enabled = true;
            txtAdditionalInfo.Enabled = true;
            chBxHasContacted.Enabled = true;
            btnSubmit.Enabled = true;

            lstBxIncidents.Items.Clear();
        }

        protected void btnGetIncidents_Click(object sender, EventArgs e)
        {
            List<Incident> objIncidentList = DBManagement.getIncidentByCustID(Convert.ToInt32(txtCustomerId.Text.Trim()));

            if (objIncidentList.Count > 0)
            {                
                enabledControls();
                ListItem item = new ListItem("--Select an incident--", "None");
                lstBxIncidents.Items.Add(item);
                foreach (Incident i in objIncidentList)
                {
                    item = new ListItem(i.CustomerIncidentDisplay(), i.IncidentID.ToString());
                    lstBxIncidents.Items.Add(item);
                }

                lstBxIncidents.Focus();
            }
            else
            {
                disabledControls();
                lblMessage.Text = "No closed incident found with given CustomerID.";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (lstBxIncidents.SelectedIndex > 0)
            {
                Survey objSurvey = new Survey();

                objSurvey.CustomerID = Convert.ToInt32(txtCustomerId.Text.Trim());
                objSurvey.IncidentID = Convert.ToInt32(lstBxIncidents.SelectedValue);
                objSurvey.ResponseTime = Convert.ToInt32(rblResponseTime.SelectedValue);
                objSurvey.TechEfficiency = Convert.ToInt32(rblTechEff.SelectedValue);
                objSurvey.Resolution = Convert.ToInt32(rblProbRes.SelectedValue);
                objSurvey.Comments = txtAdditionalInfo.Text;
                objSurvey.Contact = chBxHasContacted.Checked;
                objSurvey.ContactBy = rblContactby.SelectedValue;

                Session["Contact"] = chBxHasContacted.Checked;

                Response.Redirect("SurveyComplete.aspx");
            }
            else
            {
                lblMessage.Text = "Please select an incident to submit.";
            }
        }

        protected void chBxHasContacted_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxHasContacted.Checked)
            {
                rblContactby.ForeColor = System.Drawing.Color.Black;
                rblContactby.Enabled = true;
            }
            else
            {
                rblContactby.ForeColor = System.Drawing.Color.LightGray;
                rblContactby.Enabled = false;
            }
        }        
    }
}