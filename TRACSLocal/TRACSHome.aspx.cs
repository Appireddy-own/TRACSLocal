using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TRACSLocal
{
    public partial class TRACSHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnMVCPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ABSForm/CreateABSForm/", false);
        }
        protected void btnASPXPage_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("DCMForm.aspx", false);

        }
    }
}