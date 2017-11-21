using System;
using MySql.Data.MySqlClient;

namespace VoteMe.@class.db
{
    public class UserInfo
    {
        public UserInfo()
        {
        }
		private string adhar;
		private string fName, lName, gender, addr, mobile, password;
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

		public string Aadhar
		{
			get
			{
				return adhar;
			}
			set
			{
				adhar = value;
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

		public bool doGetDetails(string user)
		{
			try
			{
            MySqlConnection con = new DBConnection().makeConnection();
			if (con != null)
			{
                MySqlCommand com = new MySqlCommand("select * from peoples where aadhar like '" + user.Trim() + "';", con);
				
					MySqlDataReader rdr = com.ExecuteReader();
					if (rdr.Read())
					{
						this.adhar = rdr.GetString("aadhar");
						this.FName = rdr.GetString("firstname");
						this.LName = rdr.GetString("lastname");
						this.Gender = rdr.GetString("gender");
						this.Addr = rdr.GetString("locality");
                        this.addr += ", " + rdr.GetString("city");
                        this.addr += ", " + rdr.GetString("state");
                        this.addr += ", " + rdr.GetString("country");
						this.Mobile = rdr.GetString("mobile");
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
			catch (Exception e)
			{
				string msg = e.Message;
				//con.Close();
				return false;
			}
		}

    }
}
