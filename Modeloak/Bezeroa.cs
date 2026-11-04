using System;
using System.Collections.Generic;
using System.Text;

namespace IdazkaritzaApp.Modeloak
{
    public class Bezeroa
    {
        public int Id { get; set; }
        public string Izena { get; set; } = "";
        public string Abizena { get; set; } = "";
        public string Emaila { get; set; } = "";
        public string Telefonoa { get; set; } = "";
        public OstatuMota Ostatua { get; set; }
        public string SortzeEguna { get; set; } = "";

        public Bezeroa(int id, string izena, OstatuMota ostatua)
            : this(id, izena, "", "", "", ostatua, DateTime.Now.ToString("yyyy-MM-dd"))
        {
        }

        public Bezeroa(int id, string izena, string abizena, string emaila, string telefonoa, OstatuMota ostatua, string sortzeEguna)
        {
            Id = id;
            Izena = izena;
            Abizena = abizena;
            Emaila = emaila;
            Telefonoa = telefonoa;
            Ostatua = ostatua;
            SortzeEguna = sortzeEguna;
        }

        public override string ToString() => $"{Id} - {Izena} {Abizena}".Trim();
    }
}
