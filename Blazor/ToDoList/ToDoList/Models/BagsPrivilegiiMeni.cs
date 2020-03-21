using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class BagsPrivilegiiMeni
    {
        public int BagsPrivilegiiMeniId { get; set; }
        public int BagsGrupaId { get; set; }
        public string MeniId { get; set; }
        public short Vidlivo { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }
    }
}
