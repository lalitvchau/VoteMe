using System;
using MySql.Data.MySqlClient;
using VoteMe.@class.db;
namespace VoteMe.@class.db
{
    public class Login
    {
        public string[] country = null;
        public string[] state = null;
        public string[] location = null;

        public Login()
        {
        }

		public MySqlDataReader SelectCountry(out MySqlConnection conn)
		{
			MySqlConnection con = new DBConnection().makeConnection();
            conn = con;
			if (con != null)
            {  try
                {
                    MySqlCommand com = new MySqlCommand("select distinct country from peoples order by country;", con);
                    MySqlDataReader rdr = com.ExecuteReader();

                        return rdr;

                   
                } catch(Exception e){
                    string msg = e.Message;
                        con.Close();
                    return null;
                    }
			}
			else
			{
				con.Close();
				return null;
			}

			
		}
		public MySqlDataReader SelectLoc(out MySqlConnection conn)
		{
			MySqlConnection con = new DBConnection().makeConnection();
			conn = con;
			if (con != null)
			{
				try
				{
					MySqlCommand com = new MySqlCommand("select distinct locality from peoples order by locality;", con);
					MySqlDataReader rdr = com.ExecuteReader();

					return rdr;


				}
				catch (Exception e)
				{
					string msg = e.Message;
					con.Close();
					return null;
				}
			}
			else
			{
				con.Close();
				return null;
			}


		}

		public MySqlDataReader SelectCity(out MySqlConnection conn)
		{
			MySqlConnection con = new DBConnection().makeConnection();
			conn = con;
			if (con != null)
			{
				try
				{
					MySqlCommand com = new MySqlCommand("select distinct city from peoples order by city;", con);
					MySqlDataReader rdr = com.ExecuteReader();

					return rdr;


				}
				catch (Exception e)
				{
					string msg = e.Message;
					con.Close();
					return null;
				}
			}
			else
			{
				con.Close();
				return null;
			}


		}

		public MySqlDataReader SelectState(out MySqlConnection conn)
		{
			MySqlConnection con = new DBConnection().makeConnection();
			conn = con;
			if (con != null)
			{
				try
				{
                    MySqlCommand com = new MySqlCommand("select distinct state from peoples order by state;", con);
					MySqlDataReader rdr = com.ExecuteReader();

					return rdr;


				}
				catch (Exception e)
				{
					string msg = e.Message;
					con.Close();
					return null;
				}
			}
			else
			{
				con.Close();
				return null;
			}


		}

        public bool doLogin(string user,string password){
            MySqlConnection con = new DBConnection().makeConnection();
            if (con != null)
            {
                MySqlCommand com = new MySqlCommand("select * from userElection where username like '" + user + "' and password like '" + password + "';", con);
                MySqlDataReader rdr = com.ExecuteReader();
                if (rdr.Read())
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
                con.Close();
                return false;
            }
        }
		public bool doPeopleLogin(string aadhar, string mobile)
		{
			MySqlConnection con = new DBConnection().makeConnection();
			if (con != null)
			{
				MySqlCommand com = new MySqlCommand("select * from peoples where aadhar like '" + aadhar + "' and mobile like '" + mobile + "';", con);
				MySqlDataReader rdr = com.ExecuteReader();
                if (rdr.Read())
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
            else {
                con.Close();
                return false;
            }
		}
    }
}
