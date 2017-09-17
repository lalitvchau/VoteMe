using System;
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
				
				
                Login login = new Login();
                MySqlDataReader rdr =  login.SelectCountry(out con);
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

				//txtCountry.Items.Add("lalit");

			}
		}


		public void addEvent(object sender, EventArgs args)
		{
            Election ele = new Election();
           country = txtCountry.SelectedItem.Text.Trim();
            city = txtCity.SelectedItem.Text.Trim();
           locality = txtLocation.SelectedItem.Text.Trim();
            state = txtState.SelectedItem.Text.Trim();
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
									ele.AddCandidate(eventId, txtcAadhar4.Text.Trim(), txtcName4.Text.Trim(), txtcParty4.Text.Trim());
									if ((txtcName2.Text.Trim() != "") && (txtcParty2.Text.Trim() != "") && (txtcAadhar2.Text.Trim() != ""))
									{
										ele.AddCandidate(eventId, txtcAadhar5.Text.Trim(), txtcName5.Text.Trim(), txtcParty5.Text.Trim());
										if ((txtcName2.Text.Trim() != "") && (txtcParty2.Text.Trim() != "") && (txtcAadhar2.Text.Trim() != ""))
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
