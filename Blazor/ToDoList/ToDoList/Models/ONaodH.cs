using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class ONaodH
    {
        public ONaodH()
        {
            ONaodS = new HashSet<ONaodS>();
        }

        public int ONaodHId { get; set; }
        public string NaodBroj { get; set; }
        public DateTime Datum { get; set; }
        public int OPacientId { get; set; }
        public int OUslugaHId { get; set; }
        public short Status { get; set; }
        public int? ZaklucilOVrabotenId { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual OPacient OPacient { get; set; }
        public virtual OUslugaH OUslugaH { get; set; }
        public virtual ICollection<ONaodS> ONaodS { get; set; }
    }
}
