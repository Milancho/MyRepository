using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class OVrabotenOUslugaH
    {
        public int OVrabotenOUslugaHId { get; set; }
        public int OVrabotenId { get; set; }
        public int OUslugaHId { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual OVraboten OVraboten { get; set; }
    }
}
