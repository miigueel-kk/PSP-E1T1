using IdazkaritzaApp.Modeloak;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace IdazkaritzaApp.Formularioak
{
    public partial class FrmBezeroLeihoa : Form
    {
        //Lehio honen bezeroa gordetzen du
        private readonly Bezeroa bezeroa;

        private readonly EskaeraZerrenda zerrenda;


        //Bezeroak eskaera bat egiten duenenan jaurtitzen da, bezeroa eta eskaera mota bidaltzen
        public event Action<Bezeroa, EskaeraMota>? EskaeraEginda;

        //Check-out egiten denean jaurtitzen da
        public event Action<Bezeroa>? CheckOutEginda;

        //Lehioa sortzen denenan bezeroa jasotzen du
        public FrmBezeroLeihoa(Bezeroa bezeroa, EskaeraZerrenda zerrenda)
        {
            //Windows forms sortutako osagai guztiak sartzen ditu
            InitializeComponent();

            //BezeroBerria lehiotik jasotako bezeroa gordetzen du
            this.bezeroa = bezeroa;

            this.zerrenda = zerrenda;

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

        private async void btnEskuoihalak_Click(object sender, EventArgs e)
        {
            //EskaeraEginda ekitaldia jaurtitzen du, bezeroa eta eskaera mota bidaliz
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Eskuoihalak);
            await SortuEskaeraAsync(EskaeraMota.Eskuoihalak.ToString());
            //Mezua erakusten du
            MessageBox.Show("Zure eskuoihalen eskaera bidali da.");

        }

        private async void btnIzarak_Click(object sender, EventArgs e)
        {
            //EskaeraEginda ekitaldia jaurtitzen du, bezeroa eta eskaera mota bidaliz
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Izarak);
            await SortuEskaeraAsync(EskaeraMota.Izarak.ToString());
            //Eskaera bidali dela jakinarazten dio bezeroari
            MessageBox.Show("Zure izarak aldatzeko eskaera bidali da.");
        }

        private async void btnZaborra_Click(object sender, EventArgs e)
        {
            //EskaeraEginda ekitaldia jaurtitzen du, bezeroa eskaera mota bidaliz
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Zaborra);
            await SortuEskaeraAsync(EskaeraMota.Zaborra.ToString());
            //Eskaera bidali dela jakinarazten dio bezeroari
            MessageBox.Show("Zure zaborra jasotzeko eskaera bidali da.");
        }

        private async void btnJatetxea_Click(object sender, EventArgs e)
        {
            //EskaeraEginda ekitaldia jaurtitzen du, bezeroa eta eskaera mota bidaliz
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Jatetxea);
            await SortuEskaeraAsync(EskaeraMota.Jatetxea.ToString());

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

   

        private void textIzena_TextChanged(object sender, EventArgs e)
        {

        }

        private String sortuEskaeraID() { 
            Random random = new Random();

            int zenbakia = random.Next(0,100);
            char letra = (char)random.Next('A', 'Z' + 1);

            return $"{zenbakia:D2}{letra}";

        }

        private async Task SortuEskaeraAsync(String mota)
        {


            switch (mota)
            {
                case "Eskuoihalak":
                    await Task.Delay(2000);
                    break;
                case "Izarak":
                    await Task.Delay(3000);
                    break;
                case "Zaborra":
                    await Task.Delay(1000);
                    break;
                case "Jatetxe":
                    await Task.Delay(1000);
                    break;
            }
            String id_eskaera;

            do
            {
                id_eskaera = sortuEskaeraID();
            } while (zerrenda.eskaerak.Any(e => e.eskaera_id == id_eskaera));


            Random random = new Random();
            LangileakKudeatzen langile = (LangileakKudeatzen)random.Next(0, 4);

            Eskaera e = new Eskaera(
                id_eskaera,
                int.Parse(bezeroa.Id.ToString()),
                mota,
                langile.ToString()
                );

            zerrenda.eskaerak.Add(e);

            // Erakutsi eskatutako eskaera
            System.Diagnostics.Debug.WriteLine("=== ESKAERAK ===");

            foreach (Eskaera eskaera in zerrenda.eskaerak)
            {
                MessageBox.Show(
                    $"ID: {eskaera.eskaera_id} | " +
                    $"Bezeroa: {eskaera.bezero_id} | " +
                    $"Mota: {eskaera.mota} | " +
                    $"Langilea: {eskaera.langilea} | " +
                    $"Amaituta: {eskaera.amaituta}"
                );

            }
            
        }
    }
}
 