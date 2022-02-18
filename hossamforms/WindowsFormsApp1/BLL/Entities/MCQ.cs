using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MCQ : Question
    {
        private int q_id;
        public int Q_id

        {
            get { return q_id; }
            set
            {
                if (value != this.q_id)
                {
                    q_id = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

        private string ch_a;
        public string Ch_a
        {
            get { return ch_a; }
            set
            {
                if (value != this.ch_a)
                {
                    ch_a = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }
        private string ch_b;
        public string Ch_b
        {
            get { return ch_b; }
            set
            {
                if (value != this.ch_b)
                {
                    ch_b = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }
        private string ch_c;
        public string Ch_c
        {
            get { return ch_c; }
            set
            {
                if (value != this.ch_c)
                {
                    ch_c = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }
        private string ch_d;
        public string Ch_d
        {
            get { return ch_d; }
            set
            {
                if (value != this.ch_d)
                {
                    ch_d = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

    }
}

/*
 	[q_id] [int] NOT NULL,
	[ch_a] [varchar](300) NOT NULL,
	[ch_b] [varchar](300) NOT NULL,
	[ch_c] [varchar](300) NOT NULL,
	[ch_d] [varchar](300) NOT NULL,
 */
