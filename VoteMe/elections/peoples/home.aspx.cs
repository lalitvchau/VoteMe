using System;
using System.Web;
using System.Web.UI;
namespace VoteMe.elections.peoples
{
    public partial class home : System.Web.UI.Page
    {
		protected void Page_Load(object sender, EventArgs e)
		{

			string seesionId = (String)this.Session["people"];
			if (seesionId == null || seesionId == "")
			{
				Session.RemoveAll();
				Response.Redirect("../../Default.aspx");
			}
		}
    }
}
