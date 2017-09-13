using System;
using MySql.Data.MySqlClient;
using MyFirstWeb.@class.db;
namespace MyFirstWeb.@class.db
{
    public class Login
    {
        public Login()
        {
        }
        public bool doLogin(string user,string password){
            MySqlConnection con = new DBConnection().makeConnection();
            if (con != null)
            {
                MySqlCommand com = new MySqlCommand("select * from userElection where username like '"+user+"' and password like '"+password+"';",con);
                MySqlDataReader rdr = com.ExecuteReader();
                if (rdr.Read()) return true;
                else return false;
            }
            else return false;
        }
		public bool doPeopleLogin(string aadhar, string mobile)
		{
			MySqlConnection con = new DBConnection().makeConnection();
			if (con != null)
			{
				MySqlCommand com = new MySqlCommand("select * from peoples where aadhar like '" + aadhar + "' and mobile like '" + mobile + "';", con);
				MySqlDataReader rdr = com.ExecuteReader();
				if (rdr.Read()) return true;
				else return false;
			}
			else return false;
		}
    }
}
