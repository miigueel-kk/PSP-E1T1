using System;
using System.Collections.Generic;
using System.Text;

namespace IdazkaritzaApp.Formularioak
{
    public class EskaeraZerrenda
    {
        public List<Eskaera> eskaerak { get; set; }

        public EskaeraZerrenda() {
            eskaerak = new List<Eskaera>();
        }
    }
}
