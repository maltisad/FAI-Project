using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAI_lab2.Models
{
    public class Amortizimi
    {
        public Amortizimi() { }

        public int AmortizimID { get; set; }
        public int ProduktiID { get; set; }
        public decimal AmortizimiVjetor { get; set; }
        public decimal AmortizimiAkumuluar { get; set; }
        public int Viti { get; set; }
        public DateTime DataAmortizimit { get; set; }
    }
}