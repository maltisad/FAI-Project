using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAI_lab2.Models
{
    public class Zhvlersimi
    {
        public Zhvlersimi() { }

        public int ZhvlersimiID { get; set; }
        public int ProduktiID { get; set; }
        public decimal Cmimi { get; set; }
        public decimal CmimiZh { get; set; }
        public int Viti { get; set; }
        public DateTime DataZhvlersimit { get; set; }
    }
}