using System;
using System.Collections.Generic;
using System.Text;

namespace IdazkaritzaApp.Modeloak
{
    public class Bezeroa
    {
        public int Id { get; set; }
        public string Izena { get; set; } = ""; 

        public OstatuMota Ostatua { get; set; }

        public Bezeroa(int id, string izena, OstatuMota ostatua)
        {
            Id = id;
            Izena = izena;
            Ostatua = ostatua;
        }

        public override string ToString() => $"{Id} - {Izena}";

    }
}
