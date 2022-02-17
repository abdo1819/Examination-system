using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Question : EntityBase
    {
        public int Q_id { get; }
        public string Q_type { get; set; }
        public string Q_text { get; set; }
        public string Corr_answer { get; set; }
        public int Top_id { get; set; }

    }
}

/*
 	[q_id] [int] IDENTITY(500,50) NOT NULL,
	[q_type] [varchar](3) NOT NULL,
	[q_text] [varchar](300) NOT NULL,
	[corr_answer] [varchar](1) NOT NULL,
	[top_id] [int] NOT NULL,
 */
