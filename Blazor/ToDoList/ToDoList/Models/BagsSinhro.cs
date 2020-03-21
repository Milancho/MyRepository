using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class BagsSinhro
    {
        public int BagsSinhroId { get; set; }
        public string Tip { get; set; }
        public int? BagsGrupaId { get; set; }
        public int? BagsKorisnikId { get; set; }
        public long? Verzija { get; set; }
        public string Opis { get; set; }
        public string SysUsr { get; set; }
        public DateTime? SysDt { get; set; }
    }
}
