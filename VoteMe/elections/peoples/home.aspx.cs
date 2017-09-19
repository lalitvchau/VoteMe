using System;
using System.Web;
using System.Web.UI;
using MySql.Data.MySqlClient;
using VoteMe.@class.db;

namespace VoteMe.elections.peoples
{
    public partial class home : System.Web.UI.Page
    {
        string seesionId;
		protected void Page_Load(object sender, EventArgs e)
		{

			 seesionId = (String)this.Session["people"];
			if (seesionId == null || seesionId == "")
			{
				Session.RemoveAll();
				Response.Redirect("../../Default.aspx");
			}
            else{
                UserInfo loginUser = new UserInfo();
                if (loginUser.doGetDetails(seesionId))
				{
                    nameUserName.Text = loginUser.FName + " " + loginUser.LName + " (" + loginUser.Aadhar + ")";
					mobile.Text = loginUser.Mobile;
					addr.Text = loginUser.Addr;
					gender.Text = loginUser.Gender;
				}
            }
		}
		public void doSignOut(object sender, EventArgs args)
		{
			this.Session.RemoveAll();
			Response.Redirect("../../Default.aspx");

		}
		public void displayCurrentEvents()
		{
			Events events = new @class.db.Events();
			//  string eventName = "My Vote", eventDate="12/12/12";
			try
			{
				int eventNum = 0;
				MySqlConnection con;
				MySqlDataReader rdr = events.doGetCurrentEventsForUser(seesionId, out con);
				//xxxs int i = 0;
				do
				{

					Response.Write(@"<div class='card text-white bg-info border-info mb-3' style='max-width: 50rem;'><div class='card-header'>");
					eventNum = rdr.GetInt32("eventid");
                    Session["eventId"]= eventNum.ToString();
					Response.Write(rdr.GetString("eventname") + "<br/>Address = " + rdr.GetString("location") + ",  " + rdr.GetString("city") + ",  "
								  + rdr.GetString("state") + ",  " + rdr.GetString("country"));
					Response.Write(@" </div>
                              <div class='card-body bg-dark border-info'><h6 class='card-title'>
                              ");
					Response.Write(rdr.GetString("eventdate"));
					Response.Write(@" </h6>
                              <p class='card-text'>
                              ");
                    string[] aadharCandidate = new string[5];
                    string[] nameCandidate = new string[5];
                    string[] partyCandidate = new string[5];
                    int i = 0;
					MySqlConnection con1;
					MySqlDataReader rdr1 = events.doGetCandidates(eventNum, out con1);
					do
					{
						


						if ((rdr1.GetString("name") != null && rdr1.GetString("name") != "") && (rdr1.GetString("party") != null && rdr1.GetString("party") != ""))
						{
							aadharCandidate[i] = rdr1.GetString("aadharCandidate");
                            nameCandidate[i] = rdr1.GetString("name");
                            partyCandidate[i] = rdr1.GetString("party");
                            Response.Write("<h5>" + nameCandidate[i] + " </h5>(" + partyCandidate[i] + ")<h3 class='bg-success 'style='color:darkgray;'> Total Vote = " + events.countVotes(eventNum, aadharCandidate[i]) + "</h3>");
						    i++;
                        }
						else
						{
							Response.Write(@"<h4>Vchau</h4>(Other)<h3>Total Vote =0</h3>");
                            nameCandidate[i] = "Vchau";
							aadharCandidate[i] = "0";
                            i++;
						}

					} while (rdr1.Read());
					con1.Close();
                   
                    if(events.isVoted(eventNum,seesionId)){
                        string url = "?eventId=" + eventNum;
                        url+="&candidateAadhar1="+aadharCandidate[0];
                        url += "&candidateName1=" + nameCandidate[0];
                        url += "&candidateParty1=" + partyCandidate[0];
						url += "&candidateAadhar2=" + aadharCandidate[1];
						url += "&candidateName2=" + nameCandidate[1];
                        url += "&candidateParty2=" + partyCandidate[1];
						url += "&candidateAadhar3=" + aadharCandidate[2];
						url += "&candidateName3=" + nameCandidate[2];
                        url += "&candidateParty3=" + partyCandidate[2];
						url += "&candidateAadhar4=" + aadharCandidate[3];
						url += "&candidateName4=" + nameCandidate[3];
                        url += "&candidateParty4=" + partyCandidate[3];
						url += "&candidateAadhar5=" + aadharCandidate[4];
						url += "&candidateName5=" + nameCandidate[4];
                        url += "&candidateParty5=" + partyCandidate[4];
						
                        Response.Write("<a class=\"btn btn-dark border-info\" style= \"width:50%;\" href=\"Vote.aspx"+url+"\" Width=\"100%\">Please Vote</a>");
                    }

					Response.Write(@" </p>
                              </div>
                         
                         </div>
                              ");


				} while (rdr.Read());
				rdr.Close();
			}
			catch (Exception e)
			{
				string msg = e.Message;
			}
		}
		public void displayEvents()
		{
			Events events = new @class.db.Events();
			//  string eventName = "My Vote", eventDate="12/12/12";
			try
			{
				int eventNum = 0;
				MySqlConnection con;
				MySqlDataReader rdr = events.doGetEventsForUser(seesionId, out con);
				//xxxs int i = 0;
				do
				{

					Response.Write(@"<div class='card text-white bg-danger border-danger mb-3' style='max-width: 50rem;'><div class='card-header'>");
					eventNum = rdr.GetInt32("eventid");
					Response.Write(rdr.GetString("eventname") + "<br/>Address = " + rdr.GetString("location") + ",  " + rdr.GetString("city") + ",  "
								  + rdr.GetString("state") + ",  " + rdr.GetString("country"));
					Response.Write(@" </div>
                              <div class='card-body bg-dark border-primary'><h6 class='card-title'>
                              ");
					Response.Write(rdr.GetString("eventdate"));
					Response.Write(@" </h6>
                              <p class='card-text'>
                              ");
					MySqlConnection con1;
					MySqlDataReader rdr1 = events.doGetCandidates(eventNum, out con1);
					do
					{
						string aadharCandidate = "0";


						if ((rdr1.GetString("name") != null && rdr1.GetString("name") != "") && (rdr1.GetString("party") != null && rdr1.GetString("party") != ""))
						{
							aadharCandidate = rdr1.GetString("aadharCandidate");
							Response.Write("<h5>" + @rdr1.GetString("name") + " </h5>(" + rdr1.GetString("party") + ")<h3 class='bg-secondry 'style='color:darkgray;'> Total Vote = " + events.countVotes(eventNum, aadharCandidate) + "</h3>");
						}
						else
						{
							Response.Write(@"<h4>Vchau</h4>(Other)<h3>Total Vote =0</h3>");
							aadharCandidate = "0";
						}

					} while (rdr1.Read());
					con1.Close();


					Response.Write(@" </p>
                              </div>
                         
                         </div>
                              ");


				} while (rdr.Read());
				rdr.Close();
			}
			catch (Exception e)
			{
				string msg = e.Message;
			}
		}

	}
}
