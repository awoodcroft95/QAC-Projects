using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCModelUserData.Models
{
    public class StudentClass
    {
        private int regNo;

        public int RegNo
        {
            get { return regNo; }
            set { this.regNo = value; }
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { this.name = value; }
        }
        private int marks;

        public int Marks
        {
            get { return marks; }
            set
            {
                if (value < 0 || value > 150)
                {
                    this.marks = 0;
                }
                else
                {
                    this.marks = value;
                }
            }
        }
    }
}