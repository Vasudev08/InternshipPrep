using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace EvernoteClone.Model
{
    public class Notebook
    {
        [PrimaryKey,AutoIncrement]
        public int Id {  get; set; }
        [Indexed]
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}
