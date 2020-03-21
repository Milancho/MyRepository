using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class OPacient
    {
        public OPacient()
        {
            ONaodH = new HashSet<ONaodH>();
            OPacientOVraboten = new HashSet<OPacientOVraboten>();
            OSmetkaH = new HashSet<OSmetkaH>();
            OZakazuvanje = new HashSet<OZakazuvanje>();
        }

        public int OPacientId { get; set; }
        public string KartonBroj { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string TatkovoIme { get; set; }
        public DateTime? RadjanjeDatum { get; set; }
        public string MaticenBroj { get; set; }
        public string ZdravstvenBroj { get; set; }
        public string KniskaBroj { get; set; }
        public short? Pol { get; set; }
        public short? KategorijaZo { get; set; }
        public int? RZemjaId { get; set; }
        public int? ROpstinaId { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string PasosBroj { get; set; }
        public string Profesija { get; set; }
        public string Sport { get; set; }
        public string SportskiKlub { get; set; }
        public string Zabeleska { get; set; }
        public short? Status { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual ROpstina ROpstina { get; set; }
        public virtual RZemja RZemja { get; set; }
        public virtual ICollection<ONaodH> ONaodH { get; set; }
        public virtual ICollection<OPacientOVraboten> OPacientOVraboten { get; set; }
        public virtual ICollection<OSmetkaH> OSmetkaH { get; set; }
        public virtual ICollection<OZakazuvanje> OZakazuvanje { get; set; }
    }
}
