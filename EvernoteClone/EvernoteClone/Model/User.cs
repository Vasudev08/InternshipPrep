﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace EvernoteClone.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [ MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
