using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class OUslugaH
    {
        public OUslugaH()
        {
            ONaodH = new HashSet<ONaodH>();
            OUslugaS = new HashSet<OUslugaS>();
        }

        public int OUslugaHId { get; set; }
        public string Kod { get; set; }
        public string Naziv { get; set; }
        public string DostapnostOd { get; set; }
        public string DostapnostDo { get; set; }
        public int Vremetraenje { get; set; }
        public string DostapniDenovi { get; set; }
        public decimal Cena { get; set; }
        public int? RStilId { get; set; }
        public short? Tip { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual RStil RStil { get; set; }
        public virtual ICollection<ONaodH> ONaodH { get; set; }
        public virtual ICollection<OUslugaS> OUslugaS { get; set; }
    }
}
