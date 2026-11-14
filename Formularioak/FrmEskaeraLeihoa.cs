using IdazkaritzaApp.Modeloak;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IdazkaritzaApp.Formularioak
{
    public partial class FrmEskaeraLeihoa : Form

    {
        private readonly EskaeraZerrenda zerrenda;

        // Lanaldia kudeatzeko haria
        private Thread? haria;

        // Lanaldia gelditzeko seinalea
        private readonly ManualResetEvent gelditzekoSeinalea = new ManualResetEvent(false);
        public FrmEskaeraLeihoa(EskaeraZerrenda zerrenda)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Zerrenda kargatu haren atributuak sartzeko taulan
            this.zerrenda = zerrenda;
            // Taularen konfigurazioa eta baimenak ezarri
            KonfiguratuTaula();
            // Zutabe bakoitza izango dituen tituluak ezarri
            zutabeakSortu();
            eskaeraTaula.CellContentClick += eskaeraTaula_CellContentClick;
            // Ikusgarria izatea
            eskaeraTaula.Visible = true;
        }
        private void KonfiguratuTaula()
        {
            // Ezin dute errenkadak gehitu edo ezabatu
            eskaeraTaula.AllowUserToAddRows = false;
            eskaeraTaula.AllowUserToDeleteRows = false;
            // Tamaina ezarri
            eskaeraTaula.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            // Checkbox eguneratzeko false izan behar da.
            eskaeraTaula.ReadOnly = false;
            eskaeraTaula.RowHeadersVisible = false;
        }
        private void zutabeakSortu()
        {
            eskaeraTaula.Columns.Clear();

            // Eskaera_id ez da egongo ikusgarria, baina elementuak ezabatzeko beharrezkoa da.
            eskaeraTaula.Columns.Add("eskaera_id", "Eskaera_id");
            eskaeraTaula.Columns["eskaera_id"].Visible = false;

            // Beste zutabeak 
            eskaeraTaula.Columns.Add("bezero_id", "Bezero_ID");
            eskaeraTaula.Columns.Add("izena", "Bezeroa");
            eskaeraTaula.Columns.Add("mota", "Mota");
            eskaeraTaula.Columns.Add("langilea", "Langilea");
            
            // Checkbox-a gehitu
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();

            checkbox.Name = "amaituta";
            checkbox.HeaderText = "Eginda";
            eskaeraTaula.Columns.Add(checkbox);

            // Mezua bidaltzeko botoia (errenkada bakoitzean)
            DataGridViewButtonColumn mezuaZutabea = new DataGridViewButtonColumn();
            mezuaZutabea.Name = "mezua";
            mezuaZutabea.HeaderText = "Mezua";
            mezuaZutabea.Text = "Mezua";
            mezuaZutabea.UseColumnTextForButtonValue = true;   // errenkada guztietan "Mezua" agertzen da
            eskaeraTaula.Columns.Add(mezuaZutabea);

            eskaeraTaula.Rows.Clear();
            // Eskaera bakoitza gehituko du errenkada bat gehituz
            foreach (Eskaera eskaera in zerrenda.eskaerak)
            {
                gehituEskaera(eskaera);
            }
        }

        // Mezua botoia klikatzerakoan egiten dena
        private void eskaeraTaula_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Goiburua edo beste zutabe bat bada, ez egin ezer
            if (e.RowIndex < 0) return;
            if (eskaeraTaula.Columns[e.ColumnIndex].Name != "mezua") return;

            DataGridViewRow errenkada = eskaeraTaula.Rows[e.RowIndex];

            if (!int.TryParse(Convert.ToString(errenkada.Cells["bezero_id"].Value), out int bezeroId))
                return;

            string bezeroIzena = Convert.ToString(errenkada.Cells["izena"].Value) ?? "";

            // Mezua idatzi (utzi sakatzen bada edo hutsik badago, ez da ezer bidaltzen)
            string? testua = GaldetuMezua(bezeroIzena);
            if (string.IsNullOrWhiteSpace(testua)) return;

            // Mezua gorde eta bezeroaren leihoari jakinarazi
            Datuak.MezuaBidali(bezeroId, testua.Trim());

            MessageBox.Show($"Mezua bidali da: {bezeroIzena}", "Mezua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Haria martxan badago, ez hasi berriro
            if (haria != null && haria.IsAlive)
                return;

            // Gelditzeko seinalea berrezarri
            gelditzekoSeinalea.Reset();

            // Botoia desaktibatu
            lanaHasiBotoia.Enabled = false;

            // Haria sortu
            haria = new Thread(() => hariaLanaldia());
            

            // Haria bigarren mailako hari gisa konfiguratu
            haria.IsBackground = true;

            // Haria abiarazi
            haria.Start();
        }

        private void hariaLanaldia() {
            // Eskaera guztiak zeharkatu
            for (int i = 0; i < eskaeraTaula.Rows.Count; i++)
            {
                // Lanaldia bukatzeko seinalea jaso arte itxaron
                if (gelditzekoSeinalea.WaitOne(10000))
                    break;

                // Eskaera eginda dagoela markatu
                this.Invoke((MethodInvoker)delegate
                {
                    if (i < eskaeraTaula.Rows.Count)
                    {
                        eskaeraTaula.Rows[i].Cells["amaituta"].Value = true;
                    }
                });
            }

            // Prozesua amaitutakoan
            this.Invoke((MethodInvoker)delegate
            {
                lanaHasiBotoia.Enabled = true;
            });
        }

        private void gehituEskaera(Eskaera e)
        {
            // Eskaera pasatzen da, eta haren atributuak sartzen ditu errenkadan
            eskaeraTaula.Rows.Add(
               e.eskaera_id,
               e.bezero_id,
               e.izena,
               e.mota,
               e.langilea,
               e.amaituta
               );
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LanaBukatuBotoia_Click(object sender, EventArgs e)
        {
            // Lanaldia gelditu
            gelditzekoSeinalea.Set();

            eskaeraTaula.EndEdit();      

            // Errenkada bakoitza zeharkatuko du
            foreach (DataGridViewRow errenkada in eskaeraTaula.Rows)
            {
                // Errenkada nulua ez bada eta Checkbox-a markatuta badago orduan jarraituko du
                if (errenkada.Cells["amaituta"].Value != null && Convert.ToBoolean(errenkada.Cells["amaituta"].Value))
                {

                    // Eskaera_id ateratzen dugu, gero ezabatzeko
                    String eskaera_id = Convert.ToString(errenkada.Cells["eskaera_id"].Value);
                    // Eskaera izango da, aurkitzen duen eskaera id horrekin
                    Eskaera eskaera = zerrenda.eskaerak.Find(e => e.eskaera_id == eskaera_id);
                    // Ezabatzen dugu eskaera zerrendatik
                    if (eskaera != null)
                    {
                        zerrenda.eskaerak.Remove(eskaera);
                        eskaeraTaula.Rows.Remove(errenkada);
                    }
                }
            }

        }

        private void btnInportatuEsportatu_Click(object sender, EventArgs e)
        {
            // CLEAN CODE: 'using' erabiliz ziurtatzen dugu leihoa ixten denean 
            // memoria RAM-etik askatasunez ezabatuko dela (Memory Leak ekiditeko).
            using (FormEsportatu esportatuLeihoa = new FormEsportatu())
            {
                // ShowDialog() erabiliz, bezero/langile leihoa blokeatuta geratuko da 
                // esportazio-leihoarekin lanean ari garen bitartean (Modal leihoa).
                esportatuLeihoa.ShowDialog();
            }
        }

        // Mezua idazteko leiho txikia (kodetik sortua, ez du diseinurik behar)
        private static string? GaldetuMezua(string bezeroIzena)
        {
            using Form dialogoa = new Form
            {
                Text = $"Mezua - {bezeroIzena}",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = new Size(400, 130)
            };

            Label lblTestua = new Label
            {
                Text = "Idatzi bezeroari bidaliko zaion mezua:",
                Location = new Point(15, 15),
                AutoSize = true
            };
            TextBox txtMezua = new TextBox
            {
                Location = new Point(15, 45),
                Size = new Size(370, 27)
            };
            Button btnBidali = new Button
            {
                Text = "Bidali",
                Location = new Point(215, 85),
                Size = new Size(80, 30),
                DialogResult = DialogResult.OK
            };
            Button btnUtzi = new Button
            {
                Text = "Utzi",
                Location = new Point(305, 85),
                Size = new Size(80, 30),
                DialogResult = DialogResult.Cancel
            };

            dialogoa.Controls.AddRange(new Control[] { lblTestua, txtMezua, btnBidali, btnUtzi });
            dialogoa.AcceptButton = btnBidali;
            dialogoa.CancelButton = btnUtzi;

            return dialogoa.ShowDialog() == DialogResult.OK ? txtMezua.Text : null;
        }
    }
}
