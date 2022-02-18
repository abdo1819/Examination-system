using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Department : EntityBase
    {
        private int dept_id;
        public int Dept_id
        {
            get { return dept_id; }
            set
            {
                if (value != this.dept_id)
                {
                    dept_id = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

        private string dept_name;

        public string Dept_name
        {
            get { return dept_name; }
            set
            {
                if (value != this.dept_name)
                {
                    dept_name = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

        private int mgr_id;
        public int Mgr_id
        {
            get { return mgr_id; }
            set
            {
                if (value != this.mgr_id)
                {
                    mgr_id = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }
    }
}

/*
 *	[dept_id] [int] IDENTITY(100,100) NOT NULL,
	[dept_name] [varchar](100) NOT NULL,
	[mgr_id] [int] NOT NULL,
 */