using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmHome
{
    public class CourseMCQ
    {

        public int q_id { get; set; }

        public string crs_name { get; set; }

        public string top_name { get; set; }

        public string q_text { get; set; }

        public string ch_a { get; set; }
        public string ch_b { get; set; }
        public string ch_c { get; set; }
        public string ch_d { get; set; }

        public char corr_answer { get; set; }


    }
}
