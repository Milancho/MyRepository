using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class RStil
    {
        public RStil()
        {
            OUslugaH = new HashSet<OUslugaH>();
        }

        public int RStilId { get; set; }
        public string Kod { get; set; }
        public string Naziv { get; set; }
        public string StilFont { get; set; }
        public string StilBoja { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual ICollection<OUslugaH> OUslugaH { get; set; }
    }
}
