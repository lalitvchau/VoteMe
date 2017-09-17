using System;
using System.Web;
using System.Web.UI;
using VoteMe.@class.db;
using MySql.Data.MySqlClient;
namespace VoteMe.elections
{
    public partial class eleHome : System.Web.UI.Page
    {
        string seesionId = null;
		protected void Page_Load(object sender, EventArgs e)
		{

			seesionId = (String)this.Session["user"];
			if (seesionId == null || seesionId == "")
			{
				Session.RemoveAll();
				Response.Redirect("../../Default.aspx");
			}
            else{
                Officer officer = new Officer();
                if(officer.doGetDetails(seesionId)){
                    nameUserName.Text = officer.FName + " " + officer.LName + " (" + officer.Username + ")";
                    mobile.Text = officer.Mobile;
                    addr.Text = officer.Addr;
                    gender.Text = officer.Gender;
                }
            }
		}
		public void doSignOut(object sender, EventArgs args)
		{
            this.Session.RemoveAll();
            Response.Redirect("../../Default.aspx");

      }
		public void AddNewEvent(object sender, EventArgs args)
		{
			
			Response.Redirect("AddNewEvent.aspx");

		}
		public void EditNewEvent(object sender, EventArgs args)
		{

			Response.Redirect("EditNewEvent.aspx");

		}
        public void displayCurrentEvents(){
            Events events = new @class.db.Events();
            //  string eventName = "My Vote", eventDate="12/12/12";
            try
            {
                int eventNum = 0;
                MySqlConnection con;
                MySqlDataReader rdr = events.doGetEvents(seesionId, out con);
                //xxxs int i = 0;
                do
                {

                    Response.Write(@"<div class='card text-white bg-info border-info mb-3' style='max-width: 50rem;'><div class='card-header'>");
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


						if((rdr1.GetString("name") !=null&&rdr1.GetString("name") !="")&&(rdr1.GetString("party") != null && rdr1.GetString("party") != "")){
                            aadharCandidate = rdr1.GetString("aadharCandidate");
                            Response.Write("<h5>"+@rdr1.GetString("name") +" </h5>("+rdr1.GetString("party") +")<h3 class='bg-danger 'style='color:darkgray;'> Total Vote = "+events.countVotes(eventNum,aadharCandidate)+"</h3>");
                        }
                        else{
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
            catch(Exception e){
                string msg = e.Message;
            }
		}


	}
}
