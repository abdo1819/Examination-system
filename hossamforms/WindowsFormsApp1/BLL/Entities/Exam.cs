using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Exam : EntityBase
    {

        private int ex_id;
        public int Ex_id
        {
            get { return ex_id; }
            set
            {
                if (value != this.ex_id)
                {
                    ex_id = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }


        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (value != this.date)
                {
                    date = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

        private int crs_id;
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
    [ex_id] [int] IDENTITY(10,10) NOT NULL,
	[date] [date] NOT NULL,
	[crs_id] [int] NOT NULL,
 */