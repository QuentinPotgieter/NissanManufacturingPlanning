using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    public class User
    {
        private string fname, sname, pw, role;

        public User(string fname, string sname, string pw, string role)
        {
            setUser(fname, sname, pw, role);
        }

        private void setUser(string fname, string sname, string pw, string role)
        {
            this.fname = fname;
            this.sname = sname;
            this.pw = pw;
            this.role = role;
        }

        public string getFName()
        {
            return fname;
        }

        public string getSName()
        {
            return sname;
        }

        public string getPw()
        {
            return pw;
        }

        public string getRole()
        {
            return role;
        }
    }
}
