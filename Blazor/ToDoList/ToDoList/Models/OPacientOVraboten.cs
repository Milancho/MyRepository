using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class OPacientOVraboten
    {
        public int OPacientOVrabotenId { get; set; }
        public int OPacientId { get; set; }
        public int OVrabotenId { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual OPacient OPacient { get; set; }
        public virtual OVraboten OVraboten { get; set; }
    }
}
