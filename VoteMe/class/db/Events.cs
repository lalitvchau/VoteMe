using System;
using MySql.Data.MySqlClient;
namespace VoteMe.@class.db
{
    public class Events
    {
        public Events()
        {
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
                        return rdr.GetInt32("total");
					}
					else
					{


						return count;
					}

				}
				else
				{
					return count;
				}
			}
			catch (Exception e)
			{
				string msg = e.Message;
				
				return 0;
			}
		}
	}
    }
