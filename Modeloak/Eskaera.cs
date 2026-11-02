using System;
using System.Collections.Generic;
using System.Text;

namespace IdazkaritzaApp.Modeloak
{
    // Eskaera klasea sortzen dugu, eskaera bakoitza kudeatzeko gero List baten barruan
    public class Eskaera
    {
        // Eskaeraren atributuak
        public String eskaera_id { get; set;}
        public int bezero_id { get; set; }
        public String mota { get; set; }
        public String langilea { get; set; }
        public bool amaituta { get; set; }

        // Eskaeraren konstruktorea, amaituta egoera beti izango da false abiaraztean
        public Eskaera(String eskaera_id, int bezero_id, String mota, String langilea) {
            this.eskaera_id = eskaera_id;
            this.bezero_id = bezero_id;
            this.mota = mota;
            this.langilea = langilea;
            this.amaituta = false;
        }

    }
}
