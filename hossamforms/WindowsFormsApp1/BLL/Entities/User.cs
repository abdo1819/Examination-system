using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class User : EntityBase
    {
		public int Usr_id { get; set; }
		public string User_type { get; set; }
		public string F_name { get; set; }
		public string L_name { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public string Hashed_password { get; set; }

	}
}

/*
 	[usr_id] [int] IDENTITY(1,1) NOT NULL,
	[user_type] [varchar](1) NOT NULL,
	[f_name] [varchar](50) NOT NULL,
	[l_name] [varchar](50) NOT NULL,
	[address] [varchar](150) NULL,
	[email] [varchar](90) NOT NULL,
	[hashed_password] [varchar](255) NOT NULL,
 */