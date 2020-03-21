using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class OUplataTip
    {
        public OUplataTip()
        {
            OUplata = new HashSet<OUplata>();
        }

        public int OUplataTipId { get; set; }
        public string Naziv { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual ICollection<OUplata> OUplata { get; set; }
    }
}
