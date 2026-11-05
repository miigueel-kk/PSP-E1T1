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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            eskaeraTaula.Rows.Clear();
            // Eskaera bakoitza gehituko du errenkada bat gehituz
            foreach (Eskaera eskaera in zerrenda.eskaerak)
            {
                gehituEskaera(eskaera);
            }
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
                    }
                }
            }
            // Errenkada guztiak kentzen dira, lanaldia hasterakoan agertuko dira faltatzen diren eskaerak kudeatzeko
            eskaeraTaula.Rows.Clear();

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
    }
}
