using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectEAV
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class OP
    {
        public string id { get; set; }
        public string denumire { get; set; }
        public string tip { get; set; }
        public string adresa { get; set; }
        public string cod_postal { get; set; }
        public string mail { get; set; }
    }

    public class OficiiPostale
    {
        public List<OP> OP { get; set; }
    }

    public class Root
    {
        public OficiiPostale oficii_postale { get; set; }
    }


}

