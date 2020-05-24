using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.RightsManagement;
using System.Text;

namespace ClubMember
{
    class Person
    {
        private string ID;
        private string password;
        private int daysLeft;
        private string memberType;
        private string fname;
        private string lname;
        private string email;
        private string movie;

        public Person(string ID, string password, int daysLeft, string memberType, string fname, string lname, string email, string movie)
        {
            this.ID = ID;
            this.password = password;
            this.daysLeft = daysLeft;
            this.memberType = memberType;
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.movie = movie;
        }

        public void setID(string ID)
        {
            this.ID = ID;
        }

        public String getID()
        {
            return ID;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public String getPassword()
        {
            return password;
        }

        public void setDaysLeft(int daysLeft)
        {
            this.daysLeft = daysLeft;
        }

        public int getDaysLeft()
        {
            return daysLeft;
        }

        public void addDays(int addDay)
        {
            daysLeft += addDay;
        }

        public void setMemberType(string memberType)
        {
            this.memberType = memberType;
        }

        public string getMemberType()
        {
            return memberType;
        }

        public void setFname(string fname)
        {
            this.fname = fname;
        }

        public string getFname()
        {
            return fname;
        }

        public void setLname(string lname)
        {
            this.lname = lname;
        }

        public string getLname()
        {
            return lname;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return email;
        }

        public void setMovie(string movie)
        {
            this.movie = movie;
        }

        public string getMovie()
        {
            return movie;
        }





    }

    
}
