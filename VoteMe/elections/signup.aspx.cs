using System;
using System.Web;
using System.Web.UI;
using VoteMe.@class.db;
namespace VoteMe.elections
{
    public partial class signup : System.Web.UI.Page
    {
		
		public void doSignup(object sender, EventArgs args)
		{
            string gender = "other";
            SignUp signUp = new SignUp();
            if(male.Checked==true){
                gender = male.Text.Trim();
			}
			else if (female.Checked == true)
			{
				gender = female.Text.Trim();
			}
            if (signUp.doSignUp(txtUsername.Text.Trim(),txtPasswordEle.Text.Trim(),txtMobile.Text.Trim(),txtfName.Text.Trim(),txtlName.Text.Trim(),gender.Trim(),txtAddr.Text.Trim()))
            {
                Session["user"] = txtUsername.Text.Trim();
                Response.Redirect("eleHome.aspx");
            }
            else{
                msg.Text = "Sorry ! Try Again something wrong (Duplicate Username)..";
            }
		}
    }
}
