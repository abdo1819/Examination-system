using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Course : EntityBase
    {
        public int Crs_id { get; set; }
        public string Crs_name { get; set; }
    }
}
