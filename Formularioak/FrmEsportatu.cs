using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace IdazkaritzaApp.Formularioak
{
    public partial class FormEsportatu : Form
    {
        // Probintzia bakoitzaren herriak gordetzeko hiztegia (Cache-a)
        private Dictionary<string, HashSet<string>> probintziaHerriak = new Dictionary<string, HashSet<string>>();
        private string lanKarpeta = Application.StartupPath;

        public FormEsportatu()
        {
            InitializeComponent();
        }

        // 1. LEIHOA KARGATZEAN
        private void FormEsportatu_Load(object sender, EventArgs e)
        {
            rbCSV.Checked = true; // Lehenetsita CSV markatuta
            kargatuDesplegableak();
        }

        // 2. BOTOIA: INPORTATU DATUAK
        private void btnInportatu_Click(object sender, EventArgs e)
        {
            aldatuEgoera(false); // Botoiak blokeatu prozesua amaitu arte

            bool ondo = ExekutatuJava("inportatu", out string mezua);

            aldatuEgoera(true);

            if (ondo)
            {
                MessageBox.Show("Euskal Autonomi Erkidegoko kanpin eta bezeroen datuak ondo inportatu dira!",
                                "Inportazioa burututa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kargatuDesplegableak();
                berrezarriAukerak(); // Hasierako egoerara bueltatu
            }
            else
            {
                MessageBox.Show("Errorea datuak inportatzean:\n" + mezua,
                                "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. BOTOIA: ESPORTATU DATUAK
        private void btnEsportatu_Click(object sender, EventArgs e)
        {
            string formatua = rbCSV.Checked ? "CSV" : "XML";
            string probintzia = cmbProbintzia.SelectedItem != null ? cmbProbintzia.SelectedItem.ToString() : "Guztiak";
            string herria = cmbHerria.SelectedItem != null ? cmbHerria.SelectedItem.ToString() : "Guztiak";

            // CSV eta XML karpetak sortu existitzen ez badira esportazioak ondo antolatzeko
            Directory.CreateDirectory(Path.Combine(lanKarpeta, "CSV"));
            Directory.CreateDirectory(Path.Combine(lanKarpeta, "XML"));

            // Komatxo artean pasatzen ditugu espazioak dituzten herriak ez apurtzeko
            string argumentuak = $"esportatu \"{formatua}\" \"{probintzia}\" \"{herria}\"";

            aldatuEgoera(false);

            bool ondo = ExekutatuJava(argumentuak, out string mezua);

            aldatuEgoera(true);

            if (ondo)
            {
                // Fitxategia erroan sortu bada, dagokion karpetara (CSV edo XML) mugitu
                mugituFitxategiaKarpetara(formatua, probintzia, herria);

                MessageBox.Show($"Kanpinen datuak ondo esportatu dira {formatua} karpetan!",
                                "Esportazioa burututa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Esportazioa egin ondoren, Guztiak/Guztiak eta CSV berrezarri
                berrezarriAukerak();
            }
            else
            {
                MessageBox.Show("Errorea datuak esportatzean:\n" + mezua,
                                "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. DESPLEGABLEAK (COMBOBOX) KARGATU ETA IRAGAZI
        private void kargatuDesplegableak()
        {
            string xmlIbilbidea = Path.Combine(lanKarpeta, "3PAG2_E1_kanpinak.xml");
            if (!File.Exists(xmlIbilbidea)) return;

            probintziaHerriak.Clear();
            cmbProbintzia.Items.Clear();
            cmbProbintzia.Items.Add("Guztiak");

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlIbilbidea);
            XmlNodeList errenkadak = doc.GetElementsByTagName("row");

            foreach (XmlNode errenkada in errenkadak)
            {
                string probintzia = errenkada["territory"]?.InnerText.Trim();
                string herria = errenkada["municipality"]?.InnerText.Trim();

                if (!string.IsNullOrEmpty(probintzia) && !string.IsNullOrEmpty(herria))
                {
                    if (!probintziaHerriak.ContainsKey(probintzia))
                    {
                        probintziaHerriak[probintzia] = new HashSet<string>();
                        cmbProbintzia.Items.Add(probintzia);
                    }
                    probintziaHerriak[probintzia].Add(herria);
                }
            }

            cmbProbintzia.SelectedIndex = 0; // "Guztiak" aukeratu
        }

        // Probintzia aldatzean, probintzia horretako herriak bakarrik erakutsi
        private void cmbProbintzia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHerria.Items.Clear();
            cmbHerria.Items.Add("Guztiak");

            string aukeratutakoProbintzia = cmbProbintzia.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(aukeratutakoProbintzia) && probintziaHerriak.ContainsKey(aukeratutakoProbintzia))
            {
                foreach (string herria in probintziaHerriak[aukeratutakoProbintzia])
                {
                    cmbHerria.Items.Add(herria);
                }
            }
            else if (aukeratutakoProbintzia == "Guztiak")
            {
                foreach (HashSet<string> herriZerrenda in probintziaHerriak.Values)
                {
                    foreach (string herria in herriZerrenda)
                    {
                        if (!cmbHerria.Items.Contains(herria))
                            cmbHerria.Items.Add(herria);
                    }
                }
            }

            cmbHerria.SelectedIndex = 0;
        }

        // Metodo laguntzailea: Esportatu ondoren CSV eta Guztiak/Guztiak berrezartzen ditu
        private void berrezarriAukerak()
        {
            rbCSV.Checked = true;
            rbXML.Checked = false;

            if (cmbProbintzia.Items.Count > 0)
                cmbProbintzia.SelectedIndex = 0;

            if (cmbHerria.Items.Count > 0)
                cmbHerria.SelectedIndex = 0;
        }

        // Metodo laguntzailea: Sortutako fitxategia CSV edo XML karpetan gordetzen dela ziurtatzen du
        private void mugituFitxategiaKarpetara(string formatua, string probintzia, string herria)
        {
            string probGarbia = probintzia.Replace("/", "_").Replace("\\", "_");
            string herriGarbia = herria.Replace("/", "_").Replace("\\", "_");
            string izena1 = $"3PAG2_E1_{probGarbia}_{herriGarbia}_export.{formatua.ToLower()}";
            string izena2 = $"3PAG2_E1_{probGarbia.Replace(" ", "")}_{herriGarbia.Replace(" ", "")}_export.{formatua.ToLower()}";

            foreach (string fitxIzena in new[] { izena1, izena2 })
            {
                string jatorria = Path.Combine(lanKarpeta, fitxIzena);
                string helburua = Path.Combine(lanKarpeta, formatua.ToUpper(), fitxIzena);

                if (File.Exists(jatorria))
                {
                    if (File.Exists(helburua)) File.Delete(helburua);
                    File.Move(jatorria, helburua);
                }
            }
        }

        // Metodo laguntzailea: Interfazea blokeatu/desblokeatu prozesua exekutatzen den bitartean
        private void aldatuEgoera(bool aktibo)
        {
            btnInportatu.Enabled = aktibo;
            btnEsportatu.Enabled = aktibo;
            Cursor = aktibo ? Cursors.Default : Cursors.WaitCursor;
        }

        // Funtzio honek DatuKudeaketa.jar exekutatzen du atzeko planoan zure Eclipse-ko URL-arekin
        private bool ExekutatuJava(string argumentuak, out string mezua)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = @"C:\Users\Ikasle\Downloads\eclipse-java-2026-09-R-win32-x86_64\eclipse\plugins\org.eclipse.justj.openjdk.hotspot.jre.full.win32.x86_64_25.0.4.v20260826-0822\jre\bin\java.exe",
                    Arguments = $"-jar \"DatuKudeaketa.jar\" {argumentuak}",
                    WorkingDirectory = lanKarpeta,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process p = Process.Start(psi))
                {
                    string irteera = p.StandardOutput.ReadToEnd();
                    mezua = p.StandardError.ReadToEnd();
                    p.WaitForExit();
                    return p.ExitCode == 0;
                }
            }
            catch (Exception ex)
            {
                mezua = ex.Message;
                return false;
            }
        }
    }
}