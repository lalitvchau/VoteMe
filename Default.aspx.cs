using System;
using System.Web;
using System.Web.UI;
using MyFirstWeb.@class.db;
using VoteMe.@class.db;
using System.Text.RegularExpressions;
namespace VoteMe
{

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


                Session.RemoveAll();
             
        }
		public void doLogin(object sender, EventArgs args)
		{
            if (txtUserNameEle.Text.Trim().Length <= 0 || txtPasswordEle.Text.Trim().Length <= 0)
			{
				msg.Text = "Username or Password should not empty ";
                txtUserNameEle.Focus();
				return;
			}

            if (!Regex.IsMatch(txtUserNameEle.Text.Trim(), @"^[a-zA-Z0-9@_.]*$"))
			{
				msg.Text = "Username Invaild !";
                txtUserNameEle.Focus();
				return;
			}
 

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

            if(txtAdhar.Text.Trim().Length<=0|| txtPass.Text.Trim().Length <= 0){
				msg1.Text = "Mobile Number or Aadhar should not empty ";
                txtAdhar.Focus();
				return;
            }

            if (!Regex.IsMatch(txtAdhar.Text.Trim(), @"^[0-9]*$"))
			{
				msg1.Text = "Aadhar should be Numeric ";
                txtAdhar.Focus();
				return;
			}
			if (!Regex.IsMatch(txtPass.Text.Trim(), @"^[0-9]*$"))
			{
				msg1.Text = "Mobile Number should be Nuneric ";
                txtPass.Focus();
				return;
			}
			


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
