using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class OZakazuvanje
    {
        public int OZakazuvanjeId { get; set; }
        public int OPacientId { get; set; }
        public DateTime Datum { get; set; }
        public int OUslugaHId { get; set; }
        public int? OVrabotenId { get; set; }
        public string Zabeleska { get; set; }
        public string Dijagnoza { get; set; }
        public short Status { get; set; }
        public string Kluc { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual OPacient OPacient { get; set; }
        public virtual OVraboten OVraboten { get; set; }
    }
}
