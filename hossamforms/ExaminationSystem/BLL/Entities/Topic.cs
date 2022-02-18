using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Topic : EntityBase
    {
        public int Top_id { get; set; }
        public string Top_name { get; set; }
        public int Crs_id { get; set; }
    }
}

/*
 	[top_id] [int] IDENTITY(10000,1000) NOT NULL,
	[top_name] [varchar](100) NOT NULL,
	[crs_id] [int] NOT NULL,
 */
