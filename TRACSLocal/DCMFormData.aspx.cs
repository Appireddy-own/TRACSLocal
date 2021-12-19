using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TRACSLocal
{
    public partial class DCMFormData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<DCMFormDataModel> dCMFormDataModels = new List<DCMFormDataModel>();

            if (!IsPostBack)
            {
                DCMFormDataModel dCMFormDataModel1 = new DCMFormDataModel();
                dCMFormDataModel1.IssuerName = "Issuer 1";
                dCMFormDataModel1.ProjectName = "Project 1";
                dCMFormDataModel1.SizeofDistribution = "21";
                dCMFormDataModel1.DealTeam = "DealTeam 1";

                DCMFormDataModel dCMFormDataModel2 = new DCMFormDataModel();
                dCMFormDataModel2.IssuerName = "Issuer 2";
                dCMFormDataModel2.ProjectName = "Project 2";
                dCMFormDataModel2.SizeofDistribution = "29";
                dCMFormDataModel2.DealTeam = "DealTeam 2";

                dCMFormDataModels.Add(dCMFormDataModel1);
                dCMFormDataModels.Add(dCMFormDataModel2);
            }
            DCMFormDataModel dCMFormDataModel3 = new DCMFormDataModel();
            dCMFormDataModel3 = (DCMFormDataModel)Session["DCMFormData"];
            dCMFormDataModels.Add(dCMFormDataModel3);

            DCMGridData.DataSource = dCMFormDataModels;
            DCMGridData.DataBind();
        }
        protected void btnRedirectFormDataEntry_Click(object sender, EventArgs e)
        {
            Response.Redirect("DCMForm.aspx", false);
        }
    }
}