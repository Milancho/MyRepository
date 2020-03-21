using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class BagsRecnik
    {
        public long Id { get; set; }
        public string Source { get; set; }
        public string Key { get; set; }
        public string Mak { get; set; }
        public string Eng { get; set; }
        public string Shq { get; set; }
        public string Gre { get; set; }
        public string SysUsr { get; set; }
        public DateTime? SysDt { get; set; }
    }
}
