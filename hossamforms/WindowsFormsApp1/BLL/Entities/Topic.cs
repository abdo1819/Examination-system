using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Topic : EntityBase
    {

        private int top_id;
        public int Top_id
        {
            get { return top_id; }
            set
            {
                if (value != this.top_id)
                {
                    top_id = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

        private string top_name;
        public string Top_name
        {
            get { return top_name; }
            set
            {
                if (value != this.top_name)
                {
                    top_name = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

        private  int crs_id;
        public int Crs_id
        {
            get { return crs_id; }
            set
            {
                if (value != this.crs_id)
                {
                    crs_id = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }
    }
}

/*
 	[top_id] [int] IDENTITY(10000,1000) NOT NULL,
	[top_name] [varchar](100) NOT NULL,
	[crs_id] [int] NOT NULL,
 */
