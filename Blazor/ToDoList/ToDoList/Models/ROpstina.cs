using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class ROpstina
    {
        public ROpstina()
        {
            OPacient = new HashSet<OPacient>();
        }

        public int ROpstinaId { get; set; }
        public string Kod { get; set; }
        public string Naziv { get; set; }
        public string Naziv2 { get; set; }
        public int RZemjaId { get; set; }
        public byte[] Zname { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual RZemja RZemja { get; set; }
        public virtual ICollection<OPacient> OPacient { get; set; }
    }
}
