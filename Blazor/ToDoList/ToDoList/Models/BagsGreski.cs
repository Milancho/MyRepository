using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class BagsGreski
    {
        public int BagsGreskiId { get; set; }
        public string Tip { get; set; }
        public string Procedura { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public DateTime SysDt { get; set; }
        public string SysUsr { get; set; }
    }
}
