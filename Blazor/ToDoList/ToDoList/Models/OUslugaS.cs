using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class OUslugaS
    {
        public OUslugaS()
        {
            ONaodS = new HashSet<ONaodS>();
        }

        public int OUslugaSId { get; set; }
        public int OUslugaHId { get; set; }
        public string Kod { get; set; }
        public string Naziv { get; set; }
        public int StavkaBr { get; set; }
        public int? OUslugaHzId { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual OUslugaH OUslugaH { get; set; }
        public virtual ICollection<ONaodS> ONaodS { get; set; }
    }
}
