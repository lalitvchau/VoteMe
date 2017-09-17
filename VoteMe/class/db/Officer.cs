using System;
using MySql.Data.MySqlClient;
namespace VoteMe.@class.db
{
    public class Officer
    {
        private string username;
        private string fName,lName,gender,addr,mobile,password;
		public string Password
		{
			get
			{
				return password;
			}
			set
			{
				password = value;
			}
		}

		public string Mobile
		{
			get
			{
				return mobile;
			}
			set
			{
				mobile = value;
			}
		}

		public string Addr
		{
			get
			{
				return addr;
			}
			set
			{
				addr = value;
			}
		}

		public string Gender
		{
			get
			{
				return gender;
			}
			set
			{
				gender = value;
			}
		}

		public string LName
		{
			get
			{
				return lName;
			}
			set
			{
				lName = value;
			}
		}

		public string Username{
            get{
                return username;
            }
            set{
                username = value;
            }
        }
        public string FName
		{
			get
			{
                return fName;
			}
			set
			{
                fName = value;
			}
		}





		public Officer()
        {
        }
		public bool doGetDetails(string user)
		{
			MySqlConnection con = new DBConnection().makeConnection();
			if (con != null)
			{
				MySqlCommand com = new MySqlCommand("select * from userElection where username like '" + user + "';", con);
                try
                {
                    MySqlDataReader rdr = com.ExecuteReader();
                    if (rdr.Read())
                    {
                        this.Username = rdr.GetString("username");
                        this.FName = rdr.GetString("firstname");
                        this.LName = rdr.GetString("lastname");
                        this.Gender = rdr.GetString("gender");
                        this.Addr = rdr.GetString("addr");
                        this.Mobile = rdr.GetString("mobile");
                        con.Close();
                        return true;
                    }
                    else
                    {

                        con.Close();
                        return false;
                    }
                }  catch(Exception e){
                    string msg = e.Message;
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
    }
}
