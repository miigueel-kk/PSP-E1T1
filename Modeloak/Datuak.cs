using System;
using System.Collections.Generic;
using System.Text;

namespace IdazkaritzaApp.Modeloak
{
    public static class Datuak
    {
        //Bezero bakoitzak id desberdin bat izateko kontagailua
        public static int HurrengoId { get; private set; } = 1;

        public static List<Bezeroa> BezeroakList { get; } = new List<Bezeroa>();

        public static Bezeroa BezeroaSortu(String izena, OstatuMota ostatua)
        {
            var b = new Bezeroa(HurrengoId++, izena, ostatua);
            BezeroakList.Add(b);
            return b;
        }


    }
}
