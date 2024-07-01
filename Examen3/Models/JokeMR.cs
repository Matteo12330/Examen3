using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra.Models
{
    public class JokeMR
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Joke { get; set; }
    }
}
