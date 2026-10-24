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
    public partial class FrmBezeroLeihoa : Form
    {

        private readonly Bezeroa bezeroa;

        //Bezeroak eskaera bat egiten duenenan jaurtitzen da
        public event Action<Bezeroa, EskaeraMota>? EskaeraEginda;

        //Check-out egiten denean (lehioa itxi) jaurtitzen da
        public event Action<Bezeroa>? CheckOutEginda;

        public FrmBezeroLeihoa(Bezeroa bezeroa)
        {
            InitializeComponent();
            this.bezeroa = bezeroa;

            //Bezeroaren datuak erakutsi
            textIzena.Text = bezeroa.Izena;
            textID.Text = bezeroa.Id.ToString();
            cmbOstatua.DataSource = Enum.GetValues(typeof(OstatuMota));
            cmbOstatua.SelectedItem = bezeroa.Ostatua;

            //Ostatu mota ezin da aldatu
            cmbOstatua.Enabled = false;

            //Botoiak lotu
            btnEskuoihalak.Click += btnEskuoihalak_Click;
            btnIzarak.Click += btnIzarak_Click;
            btnZaborra.Click += btnZaborra_Click;
            btnJatetxea.Click += btnJatetxea_Click;
            btnCheckOut.Click += btnCheckOut_Click;
            FormClosed += FrmBezeroLehioa_FormClosed;
        }

        private void btnEskuoihalak_Click(object sender, EventArgs e)
        {
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Eskuoihalak);
        }

        private void btnIzarak_Click(object sender, EventArgs e)
        {
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Izarak);
        }

        private void btnZaborra_Click(object sender, EventArgs e)
        {
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Zaborra);
        }

        private void btnJatetxea_Click(object sender, EventArgs e)
        {
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Jatetxea);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmBezeroLehioa_FormClosed(object sender, FormClosedEventArgs e)
        {
            CheckOutEginda?.Invoke(bezeroa);
        }

        public void MezuaErakutsi(string testua)
        {
            if (IsDisposed) return;

            if(InvokeRequired)
            {
                BeginInvoke(() => MezuaErakutsi(testua));
                return;
            }

            MessageBox.Show(this, testua, "Idazkaritzatren mezua");
        }

    }
}
