using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAI_lab2.Models
{
    public class PunetoriProdukti
    {
        public int PPID { get; set; }
        public Nullable<int> PunetoriID { get ; set; }
      
        public Nullable<int> ProduktiID { get; set; }
        public DateTime DataPP { get; set; }
    }

}
