using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class BagsGrupa
    {
        public int BagsGrupaId { get; set; }
        public string Kod { get; set; }
        public string Naziv { get; set; }
        public string SysUsr { get; set; }
        public DateTime? SysDt { get; set; }
    }
}
