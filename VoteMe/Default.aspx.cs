using System;
using System.Web;
using System.Web.UI;
using MyFirstWeb.@class.db;

namespace VoteMe
{

    public partial class Default : System.Web.UI.Page
    {
		public void doLogin(object sender, EventArgs args)
		{

            if (new Login().doLogin(txtUserNameEle.Text.Trim(), txtPasswordEle.Text.Trim()))
			{
                Session["user"] = txtUserNameEle.Text.Trim();
				Response.Redirect("elections/eleHome.aspx");
			}
			else
			{
                msg.Text= "Password or login id Wrong !";
			}
		}
		public void doLoginPeople(object sender, EventArgs args)
		{

			if (new Login().doPeopleLogin(txtAdhar.Text.Trim(), txtPass.Text.Trim()))
			{
				Session["people"] = txtAdhar.Text.Trim();
				Response.Redirect("elections/peoples/home.aspx");
			}
			else
			{
				msg1.Text = "Mobile Number or Aadhar Wrong !";
			}
		}
    }
}
