using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class User {
        private string name;
        private string contactNo;
        private string emailAddress;
        private string userId;

        public User(string n, string c, string e, string id) {
            name = n;
            contactNo = c;
            emailAddress = e;
            userId = id;
        }
    }
}
