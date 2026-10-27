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
    public partial class FrmBezeroBerria : Form
    {
        private readonly EskaeraZerrenda zerrenda;
        public FrmBezeroBerria(EskaeraZerrenda zerrenda)
        {
            InitializeComponent();
            //ComboBox osatu
            cmbOstatua.DataSource = Enum.GetValues(typeof(OstatuMota));
            //Id osatu
            txtId.Text = Datuak.HurrengoId.ToString();

            this.zerrenda = zerrenda;
        }

        private void btnSortu_Click(object sender, EventArgs e)
        {
            //Izena ziurtatu
            string testuIzena = txtIzena.Text;
            
            if (string.IsNullOrWhiteSpace(testuIzena))
            {
                MessageBox.Show("Izena idatzi behar duzu.", "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Ostatu mota ziurtatu
            if (cmbOstatua.SelectedItem is not OstatuMota ostatua)
            {
                MessageBox.Show("Ostatu mota aukeratu behar duzu.");
                return;
            }

            //Bezeroa gorde
            Bezeroa bezeroa = Datuak.BezeroaSortu(txtIzena.Text.Trim(), ostatua);


            MessageBox.Show($"Bezeroa erregistratua: {bezeroa.Izena} (ID {bezeroa.Id})");

            //Bezero leihoa erakutsi
            new FrmBezeroLeihoa(bezeroa,zerrenda ).Show();

            //Hurrengo bezerorako prestatu
            txtIzena.Clear();
            txtId.Text = Datuak.HurrengoId.ToString();
        }
    }
}
