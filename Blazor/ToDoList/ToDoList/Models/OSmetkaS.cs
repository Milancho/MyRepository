using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class OSmetkaS
    {
        public int OSmetkaSId { get; set; }
        public int OSmetkaHId { get; set; }
        public int? ONaodHId { get; set; }
        public int OUslugaHId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cena { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual OSmetkaH OSmetkaH { get; set; }
    }
}
