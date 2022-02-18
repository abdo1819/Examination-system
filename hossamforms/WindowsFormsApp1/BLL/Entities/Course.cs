using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Course : EntityBase
    {
        public int Crs_id { get; }
        public string Crs_name { get; set; }
    }
}

/*
 *	[crs_id] [int] IDENTITY(1000,100) NOT NULL,
	[crs_name] [varchar](100) NOT NULL,
 */