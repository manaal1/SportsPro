using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsPro
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = DBManagement.getAllCustomers();

                if (ds != null)
                {
                    ddlCustomerList.DataSource = ds.Tables[0].DefaultView;
                    ddlCustomerList.DataTextField = "Name";
                    ddlCustomerList.DataValueField = "CustomerID";
                    ddlCustomerList.DataBind();

                    ddlCustomerList.SelectedIndex = 0;

                    int custId = Convert.ToInt32(ddlCustomerList.SelectedValue);
                    loadCustomerDetails(custId);
                }                
            }
        }

        private void loadCustomerDetails(int custId)
        {
            Customer objcust = DBManagement.getCustomerByID(custId);
            lblAddress1.Text = objcust.Address;
            lblAddress2.Text = objcust.City + ", " + objcust.State + " " + objcust.ZipCode;
            lblPhone.Text = objcust.Phone;
            lblEmail.Text = objcust.Email;
        }

        protected void ddlCustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int custId = Convert.ToInt32(ddlCustomerList.SelectedValue);
            loadCustomerDetails(custId);
        }

        protected void btnAddCList_Click(object sender, EventArgs e)
        {
            int custId = Convert.ToInt32(ddlCustomerList.SelectedValue);
            Customer objcust = DBManagement.getCustomerByID(custId);

            CustomerList objCustList = (CustomerList)Session["CustomerList"];
            objCustList.AddItem(objcust);

            Session["CustomerList"] = objCustList;
        }

        protected void btnDisplayCList_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactList.aspx");
        }
    }
}