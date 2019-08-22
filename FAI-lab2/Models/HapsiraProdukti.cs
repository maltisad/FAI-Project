using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAI_lab2.Models
{
    public class HapsiraProdukti
    {
        public int PdID { get; set; }
        public Nullable<int> ProduktiID { get ; set; }
      
        public Nullable<int> HapsiraID { get; set; }
        public DateTime DataPH { get; set; }
    }

}
