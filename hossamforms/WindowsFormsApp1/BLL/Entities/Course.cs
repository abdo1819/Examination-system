using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Course : EntityBase
    {
        private int crs_id;
        public int Crs_id 
        { 
            get { return crs_id; }
            set {
                if (value != this.crs_id)
                {
                    crs_id = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        
        }
        
        private string crs_name;
        public string Crs_name
        {
            get { return crs_name; }
            set
            {
                if (value != this.crs_name)
                {
                    crs_name = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }
    }
}
