using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsPro
{
    public partial class ContactList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSelectAddCust.Text = "Select" + Environment.NewLine + "Additional" + Environment.NewLine + "Customers";
            if (!IsPostBack)
            {
                CustomerList objCustList = (CustomerList)Session["CustomerList"];

                if (objCustList.Count() > 0)
                {
                    loadContactList(objCustList);
                }
            }            
        }

        private void loadContactList(CustomerList objCustList)
        {
            for (int i = 0; i < objCustList.Count(); i++)
            {
                lstBxContact.Items.Add(objCustList[i].Name + ":\t" + objCustList[i].Phone + ";\t" + objCustList[i].Email);
            }
        }

        protected void btnSelectAddCust_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customers.aspx");
        }

        protected void btnRemoveContact_Click(object sender, EventArgs e)
        {
            if (lstBxContact.SelectedIndex >= 0)
            {
                CustomerList objCustList = (CustomerList)Session["CustomerList"];

                if (objCustList.Count() > 0)
                {
                    objCustList.RemoveAt(lstBxContact.SelectedIndex);

                    Session["CustomerList"] = objCustList;
                }

                lstBxContact.Items.RemoveAt(lstBxContact.SelectedIndex);
            }
        }

        protected void btnEmptyList_Click(object sender, EventArgs e)
        {
            CustomerList objCustList = (CustomerList)Session["CustomerList"];

            if (objCustList.Count() > 0)
            {
                objCustList.Clear();

                Session["CustomerList"] = objCustList;
            }

            lstBxContact.Items.Clear();
        }
    }
}