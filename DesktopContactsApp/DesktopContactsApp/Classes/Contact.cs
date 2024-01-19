using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DesktopContactsApp.Classes
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } // Setting As the Primary Key
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
