using System;
using MySql.Data.MySqlClient;
namespace VoteMe.@class.db
{
    public class Events
    {
        public Events()
        {
        }
		public MySqlDataReader doGetEventsForUser(string user, out MySqlConnection con)
		{
			try
			{
				con = new DBConnection().makeConnection();
				if (con != null)
				{
                    MySqlCommand com = new MySqlCommand("select * from events a, voters b where a.eventid=b.eventid and b.aadhar like '" + user + "' and not a.eventdate = current_date() order by eventDate desc;", con);

					MySqlDataReader rdr = com.ExecuteReader();
					if (rdr.Read())
					{
						return rdr;
					}
					else
					{


						return rdr;
					}

				}
				else
				{
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

		public MySqlDataReader doGetCurrentEventsForUser(string user, out MySqlConnection con)
		{
			try
			{
				con = new DBConnection().makeConnection();
				if (con != null)
				{
					MySqlCommand com = new MySqlCommand("select * from events a, voters b where a.eventid=b.eventid and b.aadhar like '" + user + "' and  a.eventdate = current_date() order by eventDate desc;", con);

					MySqlDataReader rdr = com.ExecuteReader();
					if (rdr.Read())
					{
						return rdr;
					}
					else
					{


						return rdr;
					}

				}
				else
				{
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


		public MySqlDataReader doGetEvents(string user,out MySqlConnection con)
		{
			try
			{
			 con = new DBConnection().makeConnection();
			if (con != null)
			{
				MySqlCommand com = new MySqlCommand("select * from events where username like '" + user + "' order by eventDate desc;", con);

					MySqlDataReader rdr = com.ExecuteReader();
					if (rdr.Read())
					{
                           return rdr;
					}
					else
					{

						
						return rdr;
					}
	
			}
			else
			{
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

		public MySqlDataReader doGetCandidates(int  eventid, out MySqlConnection con)
		{
			try
			{
				con = new DBConnection().makeConnection();
				if (con != null)
				{
                    MySqlCommand com = new MySqlCommand("select * from candidates where eventid = " + eventid + " order by party;", con);

					MySqlDataReader rdr = com.ExecuteReader();
					if (rdr.Read())
					{
						return rdr;
					}
					else
					{


						return rdr;
					}

				}
				else
				{
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
        public int countVotes(int eventid, string candidateAadhar)
		{
			try
			{
                int count = 0;
                MySqlConnection con = new DBConnection().makeConnection();
				if (con != null)
				{
                    MySqlCommand com = new MySqlCommand("select count(*) as total from voting where eventid = " + eventid + " and aadharCandidate like '"+candidateAadhar+"';", con);

					MySqlDataReader rdr = com.ExecuteReader();
					if (rdr.Read())
					{
                        count=rdr.GetInt32("total");
                        con.Close();
                        return count;
					}
					else
					{
                        con.Close();

						return count;
					}

				}
				else
				{
                    con.Close();
					return count;
				}
			}
			catch (Exception e)
			{
				string msg = e.Message;
				
				return 0;
			}
		}
		public bool isVoted(int eventid, string aadhar)
		{
			try
			{
				
				MySqlConnection con = new DBConnection().makeConnection();
				if (con != null)
				{
                    MySqlCommand com = new MySqlCommand("select count(*) as tot from voting where eventid = " + eventid + " and aadhar like '" + aadhar + "';", con);

					MySqlDataReader rdr = com.ExecuteReader();
					if (rdr.Read())
					{
                        if (rdr.GetInt32("tot") == 0)
                        {
                            con.Close();
                            return true;
                        }
                        else{
							con.Close();
							return false;
                        } 
					}
					else
					{


						con.Close();
						return false;
					}

				}
				else
				{
					con.Close();
					return false;
				}
			}
			catch (Exception e)
			{
				string msg = e.Message;

                return false;
			}
		}


		public bool doVote(int eventId, string aadhar, string aadharCandidate)
		{
			MySqlConnection con = new DBConnection().makeConnection();
			if (con != null)
			{
                MySqlCommand com = new MySqlCommand(@"insert into voting(eventid,aadhar,aadharCandidate) values('" + eventId + "','" + aadhar + "','" + aadharCandidate + "');", con);
				try
				{
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
			else
			{

				return false;
			}
		}

	}
    }
