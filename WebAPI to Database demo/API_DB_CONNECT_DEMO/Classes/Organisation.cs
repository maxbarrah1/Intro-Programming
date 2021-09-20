using System;
using System.Collections.Generic;

namespace API_DB_CONNECT_DEMO
{
    public class Organisation
    {
        public string OrgName { get; set; }
        
        public string Notes { get; set; }

        public List<Contact> Contacts {get; set;}

    }
}