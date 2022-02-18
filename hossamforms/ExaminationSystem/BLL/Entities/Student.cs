using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Student : User
    {
        public int Std_id { get; set; }
        public int Dept_id { get; set; }

    }
}

/*
 	[std_id] [int] NOT NULL,
	[dept_id] [int] NOT NULL,
 */
