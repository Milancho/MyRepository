using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class BagsPrevod
    {
        public long BagsPrevodId { get; set; }
        public string Form { get; set; }
        public string Grid { get; set; }
        public string Table { get; set; }
        public string Cmng { get; set; }
        public string Type { get; set; }
        public string ObjectName { get; set; }
        public string Text { get; set; }
        public string Mak { get; set; }
        public string Eng { get; set; }
        public string Shq { get; set; }
        public DateTime? Dt { get; set; }
        public bool? Ok { get; set; }
    }
}
