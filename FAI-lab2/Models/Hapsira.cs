using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAI_lab2.Models
{
    public class Hapsira
    {
        internal string emri;

        public Hapsira() { }

        public int HapsiraID { get; set; }
        public int LLojiID { get; set; }
        public int LlojiID { get; internal set; }
        public string Emri { get; set; }
        public int ObjektiID { get; internal set; }
    }
}