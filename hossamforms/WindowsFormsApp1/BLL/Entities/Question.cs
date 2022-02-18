using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Question : EntityBase
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

        private string q_type;
        public string Q_type
        {
            get { return q_type; }
            set
            {
                if (value != this.q_type)
                {
                    q_type = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

        private string q_text;
        public string Q_text
        {
            get { return q_text; }
            set
            {
                if (value != this.q_text)
                {
                    q_text = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

        private char corr_answer;
        public char Corr_answer
        {
            get { return corr_answer; }
            set
            {
                if (value != this.corr_answer)
                {
                    corr_answer = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

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

    }
}

/*
 	[q_id] [int] IDENTITY(500,50) NOT NULL,
	[q_type] [varchar](3) NOT NULL,
	[q_text] [varchar](300) NOT NULL,
	[corr_answer] [varchar](1) NOT NULL,
	[top_id] [int] NOT NULL,
 */
