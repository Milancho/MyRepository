using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class OUplata
    {
        public int OUplataId { get; set; }
        public int OSmetkaHId { get; set; }
        public int OUplataTipId { get; set; }
        public DateTime Datum { get; set; }
        public decimal Iznos { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual OSmetkaH OSmetkaH { get; set; }
        public virtual OUplataTip OUplataTip { get; set; }
    }
}
