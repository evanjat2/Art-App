using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class member
    {
        public string username { get; set; }
        public string password { get; set; }
        public member(string name, string password)
        {
            this.username = name;
            this.password = password;
        }
    }
}
