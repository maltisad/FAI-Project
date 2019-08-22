using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAI_lab2.Models
{
    public class Produkti
    {
        public Produkti() { }

        public int ProduktiID { get; set; }
        public string Emri { get; set; }
        public string Pershkrimi { get; set; }
        public string Prodhuesi { get; set; }
        public string Modeli { get; set; }
        public int Jetegjatesia { get; set; }
        public string Lloji { get; set; }
        public int GrupiID { get; set; }
        public bool Statusi { get; set; }
        public string NrSerik { get; set; }
        public decimal salvageValue { get; set; }
        public decimal Cmimi { get; set; }
        public DateTime Data1 { get; set; }

    }
}
