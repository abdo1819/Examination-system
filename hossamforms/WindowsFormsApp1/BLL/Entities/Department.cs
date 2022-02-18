using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Department : EntityBase
    {
        public int Dept_id { get; set; }
        public string Dept_name { get; set; }
        public int Mgr_id { get; set; }
    }
}

/*
 *	[dept_id] [int] IDENTITY(100,100) NOT NULL,
	[dept_name] [varchar](100) NOT NULL,
	[mgr_id] [int] NOT NULL,
 */