using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TRACSLocal
{
    public partial class DCMForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void FormSubmit_Click(object sender, EventArgs e)
        {
            DCMFormDataModel dCMFormDataModel = new DCMFormDataModel();
            dCMFormDataModel.IssuerName = txtissuerName.Text;
            dCMFormDataModel.ProjectName = txtProjectName.Text;
            dCMFormDataModel.DealTeam = txtDealTeam.Text;
            dCMFormDataModel.SizeofDistribution = txtSizeofDistribution.Text;
            Session["DCMFormData"] = dCMFormDataModel;
            Response.Redirect("DCMFormData.aspx",false);
        }

        protected void btnRedirectToList_Click(object sender,EventArgs e)
        {
            Response.Redirect("DCMFormData.aspx", false);
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("TRACSHome.aspx", false);
        }
    }
}