using System;

using MySql.Data.MySqlClient;
namespace VoteMe.@class.db
{
    public class SignUp
    {
        public SignUp()
        {
        }
		public bool doSignUp(string user, string password, string mobile, string firstName,string lastName,string gender,string addr)
		{
			MySqlConnection con = new DBConnection().makeConnection();
            if (con != null)
            {
                MySqlCommand com = new MySqlCommand(@"insert into userElection(username,password,mobile,firstName,lastName,gender,addr) values('" + user + "','" + password + "','" + mobile + "','" + firstName + "','" + lastName + "','" + gender + "','" + addr + "')",con);
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
                }catch(Exception e){
                    string err = e.Message;
                    return false;
                }
                finally{
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
