using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class BagsPrivilegiiForm
    {
        public int BagsPrivilegiiFormId { get; set; }
        public int BagsGrupaId { get; set; }
        public string AssemblyFile { get; set; }
        public string Class { get; set; }
        public bool Citanje { get; set; }
        public bool Dodavanje { get; set; }
        public bool Izmenuvanje { get; set; }
        public bool Brisenje { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }
    }
}
