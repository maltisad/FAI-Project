using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAI_lab2.Models
{
    public class Mirembajtja
    {
        public int MirembajtjaID { get; set; }

        public Nullable<int> ProduktiID { get ; set; }
        public string Pershkrimi { get; set; }

        public DateTime DataMirmbajtjes { get; set; }
        public Nullable<int> PunetoriID { get; set; }
    }

}
