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

        // Bezero bakoitzak jasotako mezu guztiak (bezero ID -> mezuen zerrenda)
        public static Dictionary<int, List<string>> Mezuak { get; } = new();

        // Mezu bat bidaltzen denean jaurtitzen da (bezero ID, mezuaren lerroa)
        public static event Action<int, string>? MezuaBidalita;

        public static void MezuaBidali(int bezeroId, string testua)
        {
            string lerroa = $"[{DateTime.Now:HH:mm}] {testua}";

            if (!Mezuak.ContainsKey(bezeroId))
                Mezuak[bezeroId] = new List<string>();

            Mezuak[bezeroId].Add(lerroa);
            MezuaBidalita?.Invoke(bezeroId, lerroa);
        }

        // Bezero baten mezu guztiak lortzen ditu (hutsik, ez badu)
        public static List<string> LortuMezuak(int bezeroId)
        {
            return Mezuak.TryGetValue(bezeroId, out var zerrenda) ? zerrenda : new List<string>();
        }

    }
}
