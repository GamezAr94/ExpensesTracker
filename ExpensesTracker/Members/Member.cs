using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker
{
    public class Member
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Profile { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public int ID { get; set; }
        public override string ToString()
        {
            return "Name: " + Name +" , LastName: " + LastName + " , Email: " + Email + " , Profile: " + Profile + " , Password: " + Password + " , Phone: , Type: " + Type + " , ID: " + ID;
        }
    }
}
