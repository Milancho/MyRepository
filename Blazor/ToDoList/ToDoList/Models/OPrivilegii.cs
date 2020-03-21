using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class OPrivilegii
    {
        public OPrivilegii()
        {
            OVrabotenOPrivilegii = new HashSet<OVrabotenOPrivilegii>();
        }

        public int OPrivilegiiId { get; set; }
        public string Kluc { get; set; }
        public string Opis { get; set; }
        public short Tip { get; set; }
        public string Grupa { get; set; }
        public int? StavkaBr { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual ICollection<OVrabotenOPrivilegii> OVrabotenOPrivilegii { get; set; }
    }
}
