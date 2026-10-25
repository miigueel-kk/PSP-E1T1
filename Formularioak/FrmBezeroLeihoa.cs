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
        //Lehio honen bezeroa gordetzen du
        private readonly Bezeroa bezeroa;

        //Bezeroak eskaera bat egiten duenenan jaurtitzen da, bezeroa eta eskaera mota bidaltzen
        public event Action<Bezeroa, EskaeraMota>? EskaeraEginda;

        //Check-out egiten denean jaurtitzen da
        public event Action<Bezeroa>? CheckOutEginda;

        //Lehioa sortzen denenan bezeroa jasotzen du
        public FrmBezeroLeihoa(Bezeroa bezeroa)
        {
            //Windows forms sortutako osagai guztiak sartzen ditu
            InitializeComponent();

            //BezeroBerria lehiotik jasotako bezeroa gordetzen du
            this.bezeroa = bezeroa;

            //Bezeroaren Izena, ID eta ostatu mota erakusten ditu
            textIzena.Text = bezeroa.Izena;
            textID.Text = bezeroa.Id.ToString();
            cmbOstatua.DataSource = Enum.GetValues(typeof(OstatuMota));
            cmbOstatua.SelectedItem = bezeroa.Ostatua;

            //Ostatu mota ezin da aldatu
            cmbOstatua.Enabled = false;

            //Izena eta id ezin dira aldatu
            textIzena.ReadOnly = true;
            textID.ReadOnly = true;

            //Botoiak bakoitza klikatzean bere metodoa exekutatzen da
            btnEskuoihalak.Click += btnEskuoihalak_Click;
            btnIzarak.Click += btnIzarak_Click;
            btnZaborra.Click += btnZaborra_Click;
            btnJatetxea.Click += btnJatetxea_Click;
            btnCheckOut.Click += btnCheckOut_Click;
            FormClosed += FrmBezeroLehioa_FormClosed;
        }

        private void btnEskuoihalak_Click(object sender, EventArgs e)
        {
            //EskaeraEginda ekitaldia jaurtitzen du, bezeroa eta eskaera mota bidaliz
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Eskuoihalak);
            //Mezua erakusten du
            MessageBox.Show("Zure eskuoihalen eskaera bidali da.");
             
        }

        private void btnIzarak_Click(object sender, EventArgs e)
        {
            //EskaeraEginda ekitaldia jaurtitzen du, bezeroa eta eskaera mota bidaliz
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Izarak);
            //Eskaera bidali dela jakinarazten dio bezeroari
            MessageBox.Show("Zure izarak aldatzeko eskaera bidali da.");
        }

        private void btnZaborra_Click(object sender, EventArgs e)
        {
            //EskaeraEginda ekitaldia jaurtitzen du, bezeroa eskaera mota bidaliz
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Zaborra);
            //Eskaera bidali dela jakinarazten dio bezeroari
            MessageBox.Show("Zure zaborra jasotzeko eskaera bidali da.");
        }

        private void btnJatetxea_Click(object sender, EventArgs e)
        {
            //EskaeraEginda ekitaldia jaurtitzen du, bezeroa eta eskaera mota bidaliz
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Jatetxea);
            //Eskaera bidali dela jakinarazten dio bezeroari
            MessageBox.Show("Zure jatetxe zerbitzuaren eskaera bidali da.");
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //Bezeroa joaten da, leihoa itxi egiten da
            Close();
        }

        private void FrmBezeroLehioa_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Lehioa ixtean bezeroa joan dela jakinarazten du
            CheckOutEginda?.Invoke(bezeroa);
        }

        //Idazkaritzatik bezeroari mezua bidaltzeko 
        public void MezuaErakutsi(string testua)
        {
            MessageBox.Show(this, testua, "Idazkaritzaren mezua");
        }

    }
}
 