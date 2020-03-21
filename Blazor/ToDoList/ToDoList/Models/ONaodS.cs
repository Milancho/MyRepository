using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class ONaodS
    {
        public int ONaodSId { get; set; }
        public int ONaodHId { get; set; }
        public int OUslugaSId { get; set; }
        public string Informacija { get; set; }
        public string Zabeleska { get; set; }
        public string SysUsr { get; set; }
        public DateTime SysDt { get; set; }

        public virtual ONaodH ONaodH { get; set; }
        public virtual OUslugaS OUslugaS { get; set; }
    }
}
