using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Instructor : User
    {
        public int Ins_id { get; set; }
        public decimal? Salary { get; set; }
        public string? Degree { get; set; }
        public int Dept_id { get; set; }
        public DateTime Hire_date { get; set; }

    }
}

/*
 	[ins_id] [int] NOT NULL,
	[salary] [money] NULL,
	[degree] [varchar](50) NULL,
	[dept_id] [int] NOT NULL,
	[hire_date] [date] NULL,
 */