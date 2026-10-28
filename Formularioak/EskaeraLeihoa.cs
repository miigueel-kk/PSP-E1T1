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
    public partial class EskaeraLeihoa : Form

    {
        private readonly EskaeraZerrenda zerrenda;
        public EskaeraLeihoa(EskaeraZerrenda zerrenda)
        {
            InitializeComponent();

            this.zerrenda = zerrenda;
            KonfiguratuTaula();
            zutabeakSortu();
            dataGridView1.Visible = true;
        }
        private void KonfiguratuTaula()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.ReadOnly = false;
            dataGridView1.RowHeadersVisible = false;
        }
        private void zutabeakSortu() {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("bezero_id", "Bezeroa");
            dataGridView1.Columns.Add("mota", "Mota");
            dataGridView1.Columns.Add("langilea", "Langilea");
           
          

            
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();

            checkbox.Name = "amaituta";
            checkbox.HeaderText = "Eginda";
            dataGridView1.Columns.Add(checkbox);

            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Eskaera eskaera in zerrenda.eskaerak) {
                gehituEskaera(eskaera);
            }


        }

        private void gehituEskaera(Eskaera e)
        {
            
             dataGridView1.Rows.Add(
                e.bezero_id,
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
    }
}
