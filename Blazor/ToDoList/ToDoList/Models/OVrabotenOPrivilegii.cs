using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class OVrabotenOPrivilegii
    {
        public int OVrabotenOPrivilegiiId { get; set; }
        public int OVrabotenId { get; set; }
        public int OPrivilegiiId { get; set; }
        public short Vrednost { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual OPrivilegii OPrivilegii { get; set; }
        public virtual OVraboten OVraboten { get; set; }
    }
}
