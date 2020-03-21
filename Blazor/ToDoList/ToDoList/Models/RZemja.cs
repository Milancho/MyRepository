using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class RZemja
    {
        public RZemja()
        {
            OPacient = new HashSet<OPacient>();
            ROpstina = new HashSet<ROpstina>();
        }

        public int RZemjaId { get; set; }
        public string Kod { get; set; }
        public string Naziv { get; set; }
        public string Naziv2 { get; set; }
        public byte[] Zname { get; set; }
        public bool? EvropskaUnija { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual ICollection<OPacient> OPacient { get; set; }
        public virtual ICollection<ROpstina> ROpstina { get; set; }
    }
}
