using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MCQ : Question
    {
        public int Q_id { get; set; }
        public string Ch_a { get; set; }
        public string Ch_b { get; set; }
        public string Ch_c { get; set; }
        public string Ch_d { get; set; }
    }
}

/*
 	[q_id] [int] NOT NULL,
	[ch_a] [varchar](300) NOT NULL,
	[ch_b] [varchar](300) NOT NULL,
	[ch_c] [varchar](300) NOT NULL,
	[ch_d] [varchar](300) NOT NULL,
 */
