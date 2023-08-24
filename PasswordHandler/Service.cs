using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordHandler
{
    public class Service
    {
        public Int32 ServiceID { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public Service(int serviceID, string title, string username, string address, string description)
        {
            ServiceID = serviceID;
            Title = title;
            Username = username;
            Address = address;
            Description = description;
        }

        public override string? ToString()
        {
            return Title;
        }
    }
}
