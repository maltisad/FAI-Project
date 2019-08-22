using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAI_lab2.Models
{
    public class Punetori
    {
        public int PunetoriID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Gjinia { get; set; }
        public Nullable<int> RoliID { get; set; }
        public long NumriPersonal { get; set; }
    }

}
