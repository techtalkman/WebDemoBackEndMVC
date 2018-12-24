using System;
using System.Collections.Generic;

namespace WebDemoBackEndMVC.Models
{
    public partial class Myyntikiellot
    {
        public int Id { get; set; }
        public DateTime? JulkaisuPvm { get; set; }
        public string Tuotenimi { get; set; }
        public string Malli { get; set; }
        public string TeknisetArvot { get; set; }
        public string TuotePaaryhmaNimi { get; set; }
        public string Nimike { get; set; }
        public string Viivakoodi { get; set; }
        public string Vaaranlaji { get; set; }
        public string TapausTulos { get; set; }
        public string Tapausnumero { get; set; }
        public string TapauksenKuvat { get; set; }
        public string MuutTiedot { get; set; }
        public string Vastuutaho { get; set; }
        public string Asiakirjat { get; set; }
        public string Puutteet { get; set; }
        public string Paatos { get; set; }
    }
}
