using System;
using System.Web;
using System.Web.UI;
using VoteMe.@class.db;
using System.Text.RegularExpressions;
namespace VoteMe.elections
{
    public partial class signup : System.Web.UI.Page
    {
		 
		public void doSignup(object sender, EventArgs args)
		{
			

            if(txtAddr.Text.Trim()==""||txtfName.Text.Trim()==""||txtlName.Text.Trim()==""||txtMobile.Text.Trim()==""||txtConform.Text.Trim()==""||txtPasswordEle.Text.Trim()==""||txtUsername.Text.Trim()=="")
            {
                msg.Text = "All field should not be eampty !";
                txtUsername.Focus();
                return;
            }
			if (txtPasswordEle.Text.Trim().Length < 6)
			{
				msg.Text = "Password should be more than 7 characters long !";
                txtPasswordEle.Focus();
				return;
			}


           
			if (txtUsername.Text.Trim().Length < 5)
			{
				msg.Text = "Username should me more than 4 characters long !";
                txtUsername.Focus();
				return;
			}
			
			if (txtMobile.Text.Trim().Length < 10)
			{
				msg.Text = "InValid Mobile Number !";
                txtMobile.Focus();
				return;
			}
			if (txtConform.Text.Trim().Equals(txtPasswordEle.Text.Trim()))
			{

			}
			else
			{
				msg.Text = "Password and Conform are not matching  !";
                txtPasswordEle.Focus();
				return;
			}
			if (!Regex.IsMatch(txtUsername.Text.Trim(), @"^[a-zA-Z0-9@_.]*$"))
			{
				msg.Text = "Username should have only alphanumeric and @ . _ characters !";
                txtUsername.Focus();
				return;
			}
            if (!Regex.IsMatch(txtMobile.Text.Trim(), @"^[0-9]*$"))
			{
				msg.Text = "Mobile Number invailed ";
                txtMobile.Focus();
				return;
			}


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
