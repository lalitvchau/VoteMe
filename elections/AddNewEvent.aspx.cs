using System;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;

using MySql.Data.MySqlClient;
using VoteMe.@class.db;
namespace VoteMe.elections
{
    public partial class AddNewEvent : System.Web.UI.Page
    {
		static string country = null, city = null, state = null, locality = null;
        MySqlConnection con;
        string seesionId = null;
		protected void Page_Load(object sender, EventArgs e)
		{

			seesionId = (String)this.Session["user"];
			if (seesionId == null || seesionId == "")
			{
				Session.RemoveAll();
				Response.Redirect("../../Default.aspx");
			}
			else
			{

                if (txtCountry.Items.Count==0)
                {
                    Login login = new Login();
                    MySqlDataReader rdr = login.SelectCountry(out con);
                    txtCountry.Items.Clear();
                    while (rdr.Read())
                    {
                        string str = rdr.GetString("country");
                        txtCountry.Items.Add(str);
                    }
                    con.Close();
                    rdr = login.SelectState(out con);
                    txtState.Items.Clear();
                    txtState.Items.Add("None");
                    while (rdr.Read())
                    {
                        string str = rdr.GetString("state");
                        txtState.Items.Add(str);
                    }
                    con.Close();
                    rdr = login.SelectCity(out con);
                    txtCity.Items.Clear();
                    txtCity.Items.Add("None");
                    while (rdr.Read())
                    {
                        string str = rdr.GetString("city");
                        txtCity.Items.Add(str);
                    }
                    con.Close();
                    rdr = login.SelectLoc(out con);
                    txtLocation.Items.Clear();
                    txtLocation.Items.Add("None");
                    while (rdr.Read())
                    {
                        string str = rdr.GetString("locality");
                        txtLocation.Items.Add(str);
                    }
                    con.Close();
                }
				//txtCountry.Items.Add("lalit");

			}
		}


		public void addEvent(object sender, EventArgs args)
		{
            //vailidations statements

            if(txtEventName.Text.Trim().Length<=0){
                msg.Text = "Event Name should not have Eampty";
                txtEventName.Focus();
                return;
            }

            if (txtEventDate.SelectedDate.Year==1)
			{
				msg.Text = "Events Date should be selected";
                txtEventDate.Focus();
                return;
			}
            if(txtEventDate.SelectedDate<=System.DateTime.Today){
				msg.Text = "Events Date is should not be today and Past dates,It should be future date";
				txtEventDate.Focus();
				return;
            }
			if (txtcName1.Text.Trim().Length <= 0 || txtcParty1.Text.Trim().Length <= 0 || txtcAadhar1.Text.Trim().Length != 12)
			{
				msg.Text = "Atleast First and Second Candidates should be there";
				txtcName1.Focus();
                if(txtcName1.Text.Trim().Length <= 0){
                    msg.Text =msg.Text+ "<br/>Candidate 1 Name Should Not Empty !";
                }
                if (txtcParty1.Text.Trim().Length <= 0)
                {
                    msg.Text = msg.Text + "<br/>Candidate 1 Party Should Not Empty !";
                }
                if (txtcAadhar1.Text.Trim().Length != 12)
                {
                    msg.Text = msg.Text + "<br/>Candidate 1 Aadhar should be 12 digit long !";
                }
				return;
			}
            if (txtcName2.Text.Trim().Length <= 0 || txtcParty2.Text.Trim().Length <= 0 || txtcAadhar2.Text.Trim().Length != 12)
            {
                msg.Text = "Atleast  First and Second Candidates should be there";
                if (txtcName2.Text.Trim().Length <= 0)
                {
                    msg.Text = msg.Text + "<br/>Candidate 2 Name Should Not Empty !";
                }
                if (txtcParty2.Text.Trim().Length <= 0)
                {
                    msg.Text = msg.Text + "<br/>Candidate 2 Party Should Not Empty !";
                }
                if (txtcAadhar2.Text.Trim().Length != 12)
                {
                    msg.Text = msg.Text + "<br/>Candidate 2 Aadhar should be 12 digit long !";
                }
                txtcName2.Focus();
                return;
            }
            if (txtcName3.Text.Trim().Length > 0)
            {
                if (txtcParty3.Text.Trim().Length <= 0 || txtcAadhar3.Text.Trim().Length != 12)
                {
                    msg.Text = "Candidate 3rd all field should not be empty !";
                    txtcName3.Focus();
                    return;
                }
                if (!Regex.IsMatch(txtcAadhar3.Text.Trim(), @"^[0-9]*$"))
                {
                    msg.Text = "<br/>Aadhar should be Numeric ";
                    txtcAadhar3.Focus();
                    return;
                }
            }
            if (txtcName4.Text.Trim().Length > 0)
            {
                if (txtcParty4.Text.Trim().Length <= 0 || txtcAadhar4.Text.Trim().Length != 12)
                {
                    msg.Text = "Candidate 4th all field should not be empty !";
                    txtcName4.Focus();
                    return;
                }
                if (txtcName3.Text.Trim().Length <= 0 || txtcParty3.Text.Trim().Length <= 0 || txtcAadhar3.Text.Trim().Length != 12){
                    msg.Text = "<br/>Candidate 3rd  all field should not be empty !";
                    txtcName3.Focus();
                    return;
                }
                if (!Regex.IsMatch(txtcAadhar4.Text.Trim(), @"^[0-9]*$"))
                {
                    msg.Text = "<br/>Aadhar should be Numeric ";
                    txtcAadhar4.Focus();
                    return;
                }
            }
            if (txtcName5.Text.Trim().Length > 0)
            {
                if (txtcParty5.Text.Trim().Length <= 0 || txtcAadhar5.Text.Trim().Length != 12)
                {
                    msg.Text = "<br/>Candidate 3rd all field should not be empty !";
                    txtcName5.Focus();
                    return;
                }
                if (txtcName3.Text.Trim().Length <= 0 || txtcParty3.Text.Trim().Length <= 0 || txtcAadhar3.Text.Trim().Length != 12)
                {
                    msg.Text = "<br/>Candidate 3rd all field should not be empty !";
                    txtcName3.Focus();
                    return;
                }
                if (txtcName4.Text.Trim().Length <= 0 || txtcParty4.Text.Trim().Length <= 0 || txtcAadhar4.Text.Trim().Length != 12)
                {
                    msg.Text = "<br/>Candidate 4th all field should not be empty !";
                    txtcName4.Focus();
                    return;
                }
                if (!Regex.IsMatch(txtcAadhar5.Text.Trim(), @"^[0-9]*$"))
                {
                    msg.Text = "Aadhar should be Numeric ";
                    txtcAadhar5.Focus();
                    return;
                }
            }
			if (txtEventName.Text.Trim().Length < 5)
			{
				msg.Text = "Event Name should be more than 4 character long";
				txtEventName.Focus();
				return;
			}
			if (txtcAadhar1.Text.Trim().Length !=12)
			{
				msg.Text = "Atleast AdharNumber should be 12 character long";
                txtcAadhar1.Focus();
				return;
			}
            if (!Regex.IsMatch(txtcAadhar1.Text.Trim(), @"^[0-9]*$"))
			{
				msg.Text = "Aadhar should be Numeric ";
				txtcAadhar1.Focus();
				return;
			}
            if (!Regex.IsMatch(txtcAadhar2.Text.Trim(), @"^[0-9]*$"))
            {
                msg.Text = "Aadhar should be Numeric ";
                txtcAadhar2.Focus();
                return;
            }
			if (txtcName1.Text.Trim().Length < 5 || txtcParty1.Text.Trim().Length < 5 )
			{
				msg.Text = "Atleast One Candidates name and party name should be more the 4 character long";
				txtcName1.Focus();
				return;
			}

            //over

            Election ele = new Election();
            country = txtCountry.SelectedItem.ToString().Trim();
            city = txtCity.SelectedItem.ToString().Trim();
            locality = txtLocation.SelectedItem.ToString().Trim();
            state = txtState.SelectedItem.ToString().Trim();
            MySqlDataReader rdr = null;
            if(state.Equals("None")){
                state = "All States";
                city = "All Cities";
                locality = "All Localities";
                rdr = ele.findVoter("select distinct aadhar from peoples where country like '" + country.Trim() + "';", out con);
            }
            else if (city.Equals("None")){
				city = "All Cities";
				locality = "All Localities";
                rdr = ele.findVoter("select distinct aadhar from peoples where country like '" + country.Trim() + "'and state like '"+state.Trim()+"';", out con);
			}
            else if (locality.Equals("None"))
			{
				locality = "All Localities";
                rdr = ele.findVoter("select distinct aadhar from peoples where country like '" + country.Trim() + "'and state like '" + state.Trim() + "' and city like '"+city.Trim()+"';", out con);
            }else{
            rdr = ele.findVoter("select distinct aadhar from peoples where country like '" + country.Trim() + "'and state like '" + state.Trim() + "' and city like '" + city.Trim() + "' and locality like '"+locality.Trim()+"';", out con);
            }
            //con.Close();
            int day = txtEventDate.SelectedDate.Day;
            int year = txtEventDate.SelectedDate.Year;
            int month = txtEventDate.SelectedDate.Month;
            string time = year + "-"+month+"-"+day;
            if (txtEventDate.TodaysDate<=txtEventDate.SelectedDate)
            {
                if (ele.AddEvent(txtEventName.Text.Trim(),time.Trim(),country.Trim(),state.Trim(),city.Trim(),locality.Trim(),seesionId.Trim())){
                    int eventId = ele.findEventId();
                    if(eventId>0){
                        if((txtcName1.Text.Trim()!="")&&(txtcParty1.Text.Trim() != "" )&&(txtcAadhar1.Text.Trim() != "" )){
                            ele.AddCandidate(eventId,txtcAadhar1.Text.Trim(),txtcName1.Text.Trim(),txtcParty1.Text.Trim());
							if ((txtcName2.Text.Trim() != "") && (txtcParty2.Text.Trim() != "") && (txtcAadhar2.Text.Trim() != ""))
							{
								ele.AddCandidate(eventId, txtcAadhar2.Text.Trim(), txtcName2.Text.Trim(), txtcParty2.Text.Trim());
								if ((txtcName3.Text.Trim() != "") && (txtcParty3.Text.Trim() != "") && (txtcAadhar3.Text.Trim() != ""))
								{
									ele.AddCandidate(eventId, txtcAadhar3.Text.Trim(), txtcName3.Text.Trim(), txtcParty3.Text.Trim());
									if ((txtcName4.Text.Trim() != "") && (txtcParty4.Text.Trim() != "") && (txtcAadhar4.Text.Trim() != ""))
									{
										ele.AddCandidate(eventId, txtcAadhar4.Text.Trim(), txtcName4.Text.Trim(), txtcParty4.Text.Trim());
										if ((txtcName5.Text.Trim() != "") && (txtcParty5.Text.Trim() != "") && (txtcAadhar5.Text.Trim() != ""))
										{
											ele.AddCandidate(eventId, txtcAadhar5.Text.Trim(), txtcName5.Text.Trim(), txtcParty5.Text.Trim());
										}//5
									}//4
									
								}//3
								
							}//2
							
						}//1
                        do
                        {
                            ele.AddVoters(eventId, rdr.GetString("aadhar"));
                               } while (rdr.Read());
                        Response.Redirect("eleHome.aspx");
                                        
                    }
                }
            }else{
                msg.Text = null;
                msg.Text = "Event Date should be today or upcoming date !";
                }
		}
    }
}
