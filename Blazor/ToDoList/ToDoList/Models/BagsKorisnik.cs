using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class BagsKorisnik
    {
        public int Id { get; set; }
        public int? BagsGrupaId { get; set; }
        public string Username { get; set; }
        public bool? Dozvolen { get; set; }
        public string Naziv { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }
    }
}
