using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAI_lab2.Models
{
    public class Klienti
    {
        public int KlientiID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }

        public int NumriTelefonit { get; set; }

        public string Email { get; set; }
    }
}
