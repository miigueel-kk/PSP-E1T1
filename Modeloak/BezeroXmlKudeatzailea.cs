using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace IdazkaritzaApp.Modeloak
{
    /// <summary>
    /// CLEAN CODE (SRP): Klase hau 3PAG2_E1_bezeroak.xml fitxategia irakurtzeaz eta 
    /// bezero berriak bertan idazteaz bakarrik arduratzen da.
    /// </summary>
    public static class BezeroXmlKudeatzailea
    {
        private const string BezeroakXmlIzena = "3PAG2_E1_bezeroak.xml";

        // Fitxategiaren bide osoa lortzen du (bin\Debug\... karpetan)
        private static string LortuXmlIbilbidea()
        {
            return Path.Combine(Application.StartupPath, BezeroakXmlIzena);
        }

        /// <summary>
        /// 3PAG2_E1_bezeroak.xml fitxategiko bezero guztiak irakurri eta zerrenda batean itzultzen ditu.
        /// </summary>
        public static List<Bezeroa> IrakurriBezeroakXmltik()
        {
            List<Bezeroa> bezeroak = new List<Bezeroa>();
            string xmlIbilbidea = LortuXmlIbilbidea();

            if (!File.Exists(xmlIbilbidea))
            {
                return bezeroak;
            }

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlIbilbidea);

                XmlNodeList errenkadak = doc.GetElementsByTagName("row");
                foreach (XmlNode errenkada in errenkadak)
                {
                    int id = 0;
                    int.TryParse(errenkada["id"]?.InnerText.Trim(), out id);

                    string izena = errenkada["izena"]?.InnerText.Trim() ?? "";
                    string abizena = errenkada["abizena"]?.InnerText.Trim() ?? "";
                    string emaila = errenkada["emaila"]?.InnerText.Trim() ?? "";
                    string telefonoa = errenkada["telefonoa"]?.InnerText.Trim() ?? "";
                    string ostatuStr = errenkada["ostatu_mota"]?.InnerText.Trim() ?? "denda";
                    string sortzeEguna = errenkada["sortzeEguna"]?.InnerText.Trim() ?? "";

                    OstatuMota ostatua = ParseOstatuMota(ostatuStr);

                    bezeroak.Add(new Bezeroa(id, izena, abizena, emaila, telefonoa, ostatua, sortzeEguna));
                }
            }
            catch (Exception)
            {
                // Errore bat gertatuz gero, ordura arte irakurritako zerrenda itzuli
            }

            return bezeroak;
        }

        /// <summary>
        /// XML fitxategia irakurtzen du, azken bezeroaren ID-a bilatzen du eta +1 egiten dio.
        /// </summary>
        public static int KalkulatuHurrengoId()
        {
            string xmlIbilbidea = LortuXmlIbilbidea();

            // Fitxategia ez bada existitzen, lehenengo ID-a 1 izango da
            if (!File.Exists(xmlIbilbidea))
            {
                return 1;
            }

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlIbilbidea);

                XmlNodeList idNodoak = doc.GetElementsByTagName("id");
                int gehienezkoId = 0;

                // <id> etiketa guztiak aztertzen ditugu zenbakirik handiena aurkitzeko
                foreach (XmlNode nodoa in idNodoak)
                {
                    if (int.TryParse(nodoa.InnerText.Trim(), out int unekoId))
                    {
                        if (unekoId > gehienezkoId)
                        {
                            gehienezkoId = unekoId;
                        }
                    }
                }

                // Azken ID-ari 1 gehitzen diogu bezero berriarentzat (adib. 15 -> 16)
                return gehienezkoId + 1;
            }
            catch (Exception)
            {
                // Errore bat gertatuz gero, 1 itzuli aplikazioa ez apurtzeko
                return 1;
            }
        }

        /// <summary>
        /// Bezero objektu bat zuzenean 3PAG2_E1_bezeroak.xml fitxategian gehitzen du.
        /// </summary>
        public static void GehituBezeroaXmlan(Bezeroa bezeroa)
        {
            GehituBezeroaXmlan(
                bezeroa.Id,
                bezeroa.Izena,
                bezeroa.Ostatua.ToString(),
                bezeroa.Abizena,
                bezeroa.Emaila,
                bezeroa.Telefonoa,
                bezeroa.SortzeEguna);
        }

        /// <summary>
        /// Bezero berria 3PAG2_E1_bezeroak.xml fitxategian gehitzen du, Java-ko Inportazioa.java 
        /// klaseak espero duen egitura zehatza errespetatuz.
        /// </summary>
        public static void GehituBezeroaXmlan(
            int id,
            string izena,
            string ostatuMota,
            string abizena = "Zehaztu gabe",
            string emaila = "",
            string telefonoa = "600000000",
            string sortzeEguna = "")
        {
            string xmlIbilbidea = LortuXmlIbilbidea();
            XmlDocument doc = new XmlDocument();

            // 1. XML fitxategia kargatu (edo erroa sortu ez bada existitzen)
            if (File.Exists(xmlIbilbidea))
            {
                doc.Load(xmlIbilbidea);
            }
            else
            {
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(dec);
                XmlElement erroBerria = doc.CreateElement("rows");
                doc.AppendChild(erroBerria);
            }

            XmlNode? erroa = doc.DocumentElement;
            if (erroa == null) return;

            // 2. <row num="X"> nodo berria sortu
            XmlElement errenkadaBerria = doc.CreateElement("row");
            errenkadaBerria.SetAttribute("num", id.ToString());

            // 3. Kontuz! Java-ko Inportazioa.java klaseak 7 etiketa hauek DERRIGORREZ irakurtzen ditu.
            if (string.IsNullOrWhiteSpace(emaila))
            {
                string izenGarbia = izena.Trim().ToLower().Replace(" ", ".");
                emaila = $"{izenGarbia}{id}@email.com";
            }

            // Ostatu mota minuskulaz eta XML-ak erabiltzen dituen balioetara egokitu ("bungalow", "denda", "autoka")
            string ostatuGarbia = EgokituOstatuMota(ostatuMota);
            string dataGarbia = string.IsNullOrWhiteSpace(sortzeEguna)
                ? DateTime.Now.ToString("yyyy-MM-dd")
                : sortzeEguna.Trim();

            // 4. Seme-etiketak gehitu metodo laguntzaile garbi baten bidez (DRY printzipioa)
            GehituEtiketa(doc, errenkadaBerria, "id", id.ToString());
            GehituEtiketa(doc, errenkadaBerria, "izena", izena.Trim());
            GehituEtiketa(doc, errenkadaBerria, "abizena", abizena.Trim());
            GehituEtiketa(doc, errenkadaBerria, "emaila", emaila.Trim());
            GehituEtiketa(doc, errenkadaBerria, "telefonoa", telefonoa.Trim());
            GehituEtiketa(doc, errenkadaBerria, "ostatu_mota", ostatuGarbia);
            GehituEtiketa(doc, errenkadaBerria, "sortzeEguna", dataGarbia);

            // 5. Errenkada <rows> erroaren bukaeran itsatsi eta diskoan gorde
            erroa.AppendChild(errenkadaBerria);
            doc.Save(xmlIbilbidea);
        }

        /// <summary>
        /// DRY (Don't Repeat Yourself): Etiketa bat sortu eta gurasoari lotzen dion metodo laguntzailea.
        /// </summary>
        private static void GehituEtiketa(XmlDocument doc, XmlElement gurasoa, string izena, string balioa)
        {
            XmlElement elementua = doc.CreateElement(izena);
            elementua.InnerText = balioa;
            gurasoa.AppendChild(elementua);
        }

        /// <summary>
        /// ComboBox-eko balioa XML-ak eta Oracle datu-baseak onartzen duten formatura pasatzen du.
        /// </summary>
        private static string EgokituOstatuMota(string balioa)
        {
            if (string.IsNullOrWhiteSpace(balioa)) return "denda";

            string garbia = balioa.Trim().ToLower();
            if (garbia.Contains("autokarabana") || garbia.Contains("autoka"))
                return "autoka";
            if (garbia.Contains("bungalow"))
                return "bungalow";

            return "denda";
        }

        public static OstatuMota ParseOstatuMota(string balioa)
        {
            string egokitua = EgokituOstatuMota(balioa);
            if (Enum.TryParse<OstatuMota>(egokitua, true, out OstatuMota emaitza))
            {
                return emaitza;
            }
            return OstatuMota.denda;
        }
    }
}
