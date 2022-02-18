using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Student : User
    {
        private int std_id;
        public int Std_id
        {
            get { return std_id; }
            set
            {
                if (value != this.std_id)
                {
                    std_id = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

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

    }
}

/*
 	[std_id] [int] NOT NULL,
	[dept_id] [int] NOT NULL,
 */
