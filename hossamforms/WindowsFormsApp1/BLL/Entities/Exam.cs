using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Exam : EntityBase
    {
        public int Ex_id { get; }
        public DateTime Date { get; set; }
        public int Crs_id { get; set; }
    }
}

/*
    [ex_id] [int] IDENTITY(10,10) NOT NULL,
	[date] [date] NOT NULL,
	[crs_id] [int] NOT NULL,
 */