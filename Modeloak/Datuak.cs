using System;
using System.Collections.Generic;
using System.Text;

namespace IdazkaritzaApp.Modeloak
{
    public static class Datuak
    {
        // Bezero bakoitzak XML-ko azken ID-aren hurrengoa izateko
        public static int HurrengoId => BezeroXmlKudeatzailea.KalkulatuHurrengoId();

        public static List<Bezeroa> BezeroakList { get; } = new List<Bezeroa>();

        public static Bezeroa BezeroaSortu(string izena, OstatuMota ostatua)
        {
            return BezeroaSortu(
                HurrengoId,
                izena,
                "Zehaztu gabe",
                "",
                "600000000",
                ostatua,
                DateTime.Now.ToString("yyyy-MM-dd"));
        }

        public static Bezeroa BezeroaSortu(
            int id,
            string izena,
            string abizena,
            string emaila,
            string telefonoa,
            OstatuMota ostatua,
            string sortzeEguna)
        {
            var b = new Bezeroa(id, izena, abizena, emaila, telefonoa, ostatua, sortzeEguna);
            BezeroakList.Add(b);
            return b;
        }
    }
}
