using System;
using VoteMe.@class.db;
using MySql.Data.MySqlClient;
namespace VoteMe.@class.db
{
    public class Election
    {
        
        public Election()
        {
        }

        public bool AddEvent(string eventName,string eventDate,string country,string state,string city,string location,string username){
            MySqlConnection con=null;
            try
			{
            con= new DBConnection().makeConnection();
			if (con != null)
			{
				
				
                    MySqlCommand com = new MySqlCommand(@"insert into events(eventName,eventDate,country,state,city,location,username) values('" + eventName .Trim()+ "','" + eventDate.Trim() + "','" + country.Trim() + "','" + state.Trim() + "','" + city.Trim() + "','" + location.Trim() +"','" + username.Trim() + "')", con);
				
					if (com.ExecuteNonQuery() > 0)
					{
						con.Close();
						return true;
					}
					else
					{
						con.Close();
						return false;
					}
				
			}
			else
			{

				return false;
			}
			}
			catch (Exception e)
			{
				string err = e.Message;
				return false;
			}
			finally
			{
				con.Close();

			}
		
        }


		public bool AddCandidate(int eventId, string aadharCandidate, string name, string party)
		{
            MySqlConnection con=null;
			try
			{
			con = new DBConnection().makeConnection();
			if (con != null)
			{


                MySqlCommand com = new MySqlCommand(@"insert into candidates(eventId,aadharCandidate,name,party) values('" + eventId + "','" + aadharCandidate.Trim() + "','" + name.Trim() + "','" + party.Trim() +  "')", con);
				
					if (com.ExecuteNonQuery() > 0)
					{
						con.Close();
						return true;
					}
					else
					{
						con.Close();
						return false;
					}
				
			}
			else
			{

				return false;
			}
			}
			catch (Exception e)
			{
				string err = e.Message;

				return false;
			}
            finally{
                con.Close();
            }
			
		}
		public bool AddVoters(int eventId, string aadhar)
		{
            MySqlConnection con = null;

			try
			{
                con= new DBConnection().makeConnection();
			if (con != null)
			{


				MySqlCommand com = new MySqlCommand(@"insert into voters(eventId,aadhar) values('" + eventId + "','" + aadhar.Trim() + "')", con);
				
					if (com.ExecuteNonQuery() > 0)
					{
						con.Close();
						return true;
					}
					else
					{
						con.Close();
						return false;
					}
				
			}
			else
			{

				return false;
			}
			}
			catch (Exception e)
			{
				string err = e.Message;
				return false;
			}
			finally
			{
				con.Close();

			}
		}
		public bool makeVoting(int eventId, string aadhar, string aadharCandidate)
		{
            MySqlConnection con = null;

			try
			{
				con = new DBConnection().makeConnection();
			if (con != null)
			{


                MySqlCommand com = new MySqlCommand(@"insert into voting(eventId,aadhar,aadharCandidate) values('" + eventId + "','" + aadhar.Trim() + "'"+aadharCandidate+"');", con);
				
					if (com.ExecuteNonQuery() > 0)
					{
						con.Close();
						return true;
					}
					else
					{
						con.Close();
						return false;
					}
				
			}
			else
			{

				return false;
			}
			}
			catch (Exception e)
			{
				string err = e.Message;
				return false;
			}
			finally
			{
				con.Close();

			}

		}

		public int findEventId()
		{
			try
			{
			MySqlConnection con = new DBConnection().makeConnection();
			if (con != null)
			{
                int eventId = 0;
				MySqlCommand com = new MySqlCommand("select * from events", con);
              
                    MySqlDataReader rdr = com.ExecuteReader();
                    while (rdr.Read())
                    {
                       eventId= rdr.GetInt32("eventid");
                    }
                    return eventId;
                
			}
			else
			{
				con.Close();
				return 0;
			}
			}
			catch (Exception e)
			{
				string msg = e.Message;
				return 0;
			}
		}
        public MySqlDataReader findVoter(string qry,out MySqlConnection con)
		{
            try
            {
                con = new DBConnection().makeConnection();
                if (con != null)
                {
                    MySqlCommand com = new MySqlCommand(qry, con);

                    MySqlDataReader rdr = com.ExecuteReader();
                    if (rdr.Read())
                    {
                        return rdr;
                    }
                    return null;
                }


                else
                {
                    con.Close();
                    return null;
                }
            }
			 catch (Exception e)
			{
				string msg = e.Message;
                con = null;
				return null;
			}
			
		}
       

	}
}
