using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class OVraboten
    {
        public OVraboten()
        {
            OPacientOVraboten = new HashSet<OPacientOVraboten>();
            OVrabotenOPrivilegii = new HashSet<OVrabotenOPrivilegii>();
            OVrabotenOUslugaH = new HashSet<OVrabotenOUslugaH>();
            OZakazuvanje = new HashSet<OZakazuvanje>();
        }

        public int OVrabotenId { get; set; }
        public string Kod { get; set; }
        public string Zvanje { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int BagsKorisnikId { get; set; }
        public string Username { get; set; }
        public bool? Dozvolen { get; set; }
        public int? BagsGrupaId { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual ICollection<OPacientOVraboten> OPacientOVraboten { get; set; }
        public virtual ICollection<OVrabotenOPrivilegii> OVrabotenOPrivilegii { get; set; }
        public virtual ICollection<OVrabotenOUslugaH> OVrabotenOUslugaH { get; set; }
        public virtual ICollection<OZakazuvanje> OZakazuvanje { get; set; }
    }
}
