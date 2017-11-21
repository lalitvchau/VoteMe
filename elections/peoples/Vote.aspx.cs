using System;
using System.Web;
using System.Web.UI;
using  MySql.Data.MySqlClient;
using VoteMe.@class.db;
namespace VoteMe.elections.peoples
{
    
    public partial class Vote : System.Web.UI.Page
    {
        int eventNum = 0;
        string seesionId="";
        string eventId="";
		string candidateAadhar1 = "";
		string candidateName1 = "";
		string candidateAadhar2 = "";
		string candidateName2 = "";
		string candidateAadhar3 = "";
		string candidateName3 = "";
		string candidateAadhar4 = "";
		string candidateName4 = "";
		string candidateAadhar5 = "";
		string candidateName5 = "";
        string partyName1 = "";
        string partyName2 = "";
        string partyName3 = "";
        string partyName4 = "";
        string partyName5 = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            seesionId = (String)this.Session["people"];
            eventId= (String)this.Session["eventId"];
            if (seesionId == null || seesionId == "")
            {
                Session.RemoveAll();
                Response.Redirect("../../Default.aspx");
            }
            else if(eventId==null||eventId=="")
            {
                Session.RemoveAll();
				Response.Redirect("../../Default.aspx");
            }
            else if ((eventId == null || eventId == "")&&(seesionId == null || seesionId == ""))
			{
				Session.RemoveAll();
				Response.Redirect("../../Default.aspx");
			}
            else{
                Events ev= new Events();
               

                try{
                    eventNum = int.Parse(Request["eventId"]);
                    candidateAadhar1 = Request["candidateAadhar1"];
					 candidateName1 = Request["candidateName1"];
					 candidateAadhar2 = Request["candidateAadhar2"];
					 candidateName2 =Request["candidateName2"];
					 candidateAadhar3 = Request["candidateAadhar3"];
					 candidateName3 = Request["candidateName3"];
					 candidateAadhar4 = Request["candidateAadhar4"];
					 candidateName4 = Request["candidateName4"];
					 candidateAadhar5 = Request["candidateAadhar5"];
					 candidateName5 = Request["candidateName5"];
                    partyName1 = Request["candidateParty1"];
                    partyName2 = Request["candidateParty2"];
                    partyName3 = Request["candidateParty3"];
                    partyName4 = Request["candidateParty4"];
                    partyName5 = Request["candidateParty5"];
                    if(candidateAadhar1!="" && candidateName1!=""){
						
						name1.Enabled = true;
						name1.Visible = true;
                        candidate1.Text = candidateAadhar1;
                        name1.Text = " ( "+candidateName1+" )";
                        btnSubmit.Visible = true;
                        btnSubmit.Enabled=true;
                        party1.Text = partyName1;
                        party1.Visible = true;
                        party1.Enabled = true;
                    }
					if (candidateAadhar2 != "" && candidateName2 != "")
					{
						
						name2.Enabled = true;
						name2.Visible = true;
						candidate2.Text = candidateAadhar2;
						name2.Text = " ( " + candidateName2 + " )";
                        party2.Text = partyName2;
                        party2.Visible = true;
                        party2.Enabled = true;

					}
					if (candidateAadhar3 != "" && candidateName3 != "")
					{
						
						name3.Enabled = true;
						name3.Visible = true;
						candidate3.Text = candidateAadhar3;
						name3.Text = " ( " + candidateName3 + " )";
                        party3.Text = partyName3;
                        party3.Visible = true;
                        party3.Enabled = true;

					}
					if (candidateAadhar5 != "" && candidateName5 != "")
					{
						
						name5.Enabled = true;
						name5.Visible = true;
						candidate5.Text = candidateAadhar5;
						name5.Text = " ( " + candidateName5 + " )";
						party5.Text = partyName5;
						party5.Visible = true;
						party5.Enabled = true;

					}
					if (candidateAadhar4 != "" && candidateName4 != "")
					{
						
						name4.Enabled = true;
						name4.Visible = true;
						candidate4.Text = candidateAadhar4;
						name4.Text = " ( " + candidateName4 + " )";
						party4.Text = partyName4;
						party4.Visible = true;
						party4.Enabled = true;

					}
                    
                }catch(Exception en){
                    string eMsg = en.Message;
					Session.RemoveAll();
					Response.Redirect("../../Default.aspx");
                }

                if(ev.isVoted(eventNum,seesionId)){
                    
                    
                }else{
					Session.RemoveAll();
					Response.Redirect("../../Default.aspx");
                    
                }
                
            }

        }
        protected void voteMe(object sender, EventArgs e)
        {
			if ((eventId == null || eventId == "") && (seesionId == null || seesionId == ""))
			{
				Session.RemoveAll();
				Response.Redirect("../../Default.aspx");
			}
            else{
                Events en = new Events();
                string candidateAadhar="";
                if(party1.Checked){
                    candidateAadhar = candidate1.Text;
                }
                else if(party2.Checked){
                    candidateAadhar = candidate2.Text;
                }
				else if (party3.Checked)
				{
					candidateAadhar = candidate3.Text;
				}
                else if (party4.Checked)
				{
					candidateAadhar = candidate4.Text;
				}
                else if (party5.Checked)
				{
					candidateAadhar = candidate5.Text;
				}
                en.doVote(eventNum,seesionId,candidateAadhar); 

                //voting code
                Session.RemoveAll();
                Response.Redirect("home.aspx");
            }
        }

    }
}
