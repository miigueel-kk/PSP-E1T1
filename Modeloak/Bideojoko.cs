using System;
using System.Diagnostics;
using System.IO;

namespace IdazkaritzaApp.Modeloak
{
    public class Bideojoko
    {
        //Bideojokoaren prozesua gordetzen du
        private Process? prozesua;

        //Exekutagarriaren bidea gordetzen du
        public string ExeRuta { get; set; }

        //Prozesua martxan dagoen egiaztatzen du
        public bool MartxanDago => prozesua != null && !prozesua.HasExited;

        public Bideojoko()
        {
            //Bideojokoaren exekutagarriaren bidea ezartzen du
            ExeRuta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BideojokoaBuild", "E1T1.exe");
        }

        //Bideojokoa hasteko metodoa
        public bool Hasi(out string mezua)
        {
            //Jada irekita badago abisua ematen du
            if (MartxanDago)
            {
                mezua = "Bideojokoa jada martxan dago.";
                return false;
            }

            //Exekutagarria existitzen den egiaztatzen du
            if (!File.Exists(ExeRuta))
            {
                mezua = "Ez da bideojokoaren exekutagarria aurkitu.";
                return false;
            }

            try
            {
                //Prozesuaren konfigurazioa prestatzen du
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = ExeRuta,
                    WorkingDirectory = Path.GetDirectoryName(ExeRuta) ?? string.Empty,
                    UseShellExecute = true
                };

                //Prozesua abiarazten du
                prozesua = Process.Start(startInfo);
                mezua = "Bideojokoa ondo hasi da.";
                return true;
            }
            catch (Exception)
            {
                mezua = "Errorea bideojokoa hastean.";
                return false;
            }
        }
    }
}