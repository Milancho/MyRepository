using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class OSmetkaH
    {
        public OSmetkaH()
        {
            OSmetkaS = new HashSet<OSmetkaS>();
            OUplata = new HashSet<OUplata>();
        }

        public int OSmetkaHId { get; set; }
        public string SmetkaBroj { get; set; }
        public DateTime Datum { get; set; }
        public int OPacientId { get; set; }
        public decimal Popust { get; set; }
        public bool FPecateno { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual OPacient OPacient { get; set; }
        public virtual ICollection<OSmetkaS> OSmetkaS { get; set; }
        public virtual ICollection<OUplata> OUplata { get; set; }
    }
}
