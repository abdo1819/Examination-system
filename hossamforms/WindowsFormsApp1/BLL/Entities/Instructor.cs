using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Instructor : User
    {
        private int ins_id;
        public int Ins_id
        {
            get { return ins_id; }
            set
            {
                if (value != this.ins_id)
                {
                    ins_id = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

        private decimal? salary;
        public decimal? Salary
        {
            get { return salary; }
            set
            {
                if (value != this.salary)
                {
                    salary = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }

        }

        private string? degree;
        public string? Degree
        {
            get { return degree; }
            set
            {
                if (value != this.degree)
                {
                    degree = value;
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

        private DateTime hire_date;
        public DateTime Hire_date
        {
            get { return hire_date; }
            set
            {
                if (value != this.hire_date)
                {
                    hire_date = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

    }
}

/*
 	[ins_id] [int] NOT NULL,
	[salary] [money] NULL,
	[degree] [varchar](50) NULL,
	[dept_id] [int] NOT NULL,
	[hire_date] [date] NULL,
 */