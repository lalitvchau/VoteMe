using System;
using MySql.Data.MySqlClient;
namespace VoteMe.@class.db
{
    public class DBConnection
    {
		MySqlConnection connection = null;
        public DBConnection()
        {
        }
        public MySqlConnection makeConnection(){
			try
			{
				connection = new MySqlConnection(@"SERVER = localhost; DATABASE=votedb;UID=voteme;PASSWORD=voteme;");
				connection.Open();
                return connection;
			}
			catch (Exception e)
			{
				Console.Write(e);
				return null;
			}

            //return null;
        }
        public void closeConnection(MySqlConnection con){
            try
            {
                con.Close();
            }
            catch (Exception e) { string msg = e.Message; }
        }

    }
}
