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

        // Beste lehioek jakin dezaten lehio hau zein bezerorena den
        public int BezeroId => bezeroa.Id;

        // Eskaera zerrenda abiarazten dugu
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

            //Bezeroaren datu guztiak erakusten ditu
            textID.Text = bezeroa.Id.ToString();
            textIzena.Text = bezeroa.Izena;
            textAbizena.Text = bezeroa.Abizena;
            textEmaila.Text = bezeroa.Emaila;
            textTelefonoa.Text = bezeroa.Telefonoa;
            cmbOstatua.DataSource = Enum.GetValues(typeof(OstatuMota));
            cmbOstatua.SelectedItem = bezeroa.Ostatua;
            textSortzeEguna.Text = bezeroa.SortzeEguna;

            //Ostatu mota ezin da aldatu
            cmbOstatua.Enabled = false;

            //Datuak ezin dira aldatu
            textID.ReadOnly = true;
            textIzena.ReadOnly = true;
            textAbizena.ReadOnly = true;
            textEmaila.ReadOnly = true;
            textTelefonoa.ReadOnly = true;
            textSortzeEguna.ReadOnly = true;

            // Idazkaritzaren mezu guztiak erakutsi (badaude)
            textMezua.Lines = Datuak.LortuMezuak(bezeroa.Id).ToArray();
            textMezua.ReadOnly = true;
            Datuak.MezuaBidalita += MezuaJaso;

            //Botoiak bakoitza klikatzean bere metodoa exekutatzen da
            btnEskuoihalak.Click += btnEskuoihalak_Click;
            btnIzarak.Click += btnIzarak_Click;
            btnZaborra.Click += btnZaborra_Click;
            btnJatetxea.Click += btnJatetxea_Click;
            btnCheckOut.Click += btnCheckOut_Click;
            FormClosed += FrmBezeroLehioa_FormClosed;
        }

        private async void btnEskuoihalak_Click(object? sender, EventArgs e)
        {
            //EskaeraEginda ekitaldia jaurtitzen du, bezeroa eta eskaera mota bidaliz
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Eskuoihalak);
            // Eskaera sortzen du, eskuoihala motakoa dela adieraziz
            await SortuEskaeraAsync(EskaeraMota.Eskuoihalak.ToString());
            //Mezua erakusten du
            MessageBox.Show("Zure eskuoihalen eskaera bidali da.");

        }

        private async void btnIzarak_Click(object? sender, EventArgs e)
        {
            //EskaeraEginda ekitaldia jaurtitzen du, bezeroa eta eskaera mota bidaliz
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Izarak);
            // Eskaera sortzen du, izara mota dela adieraziz
            await SortuEskaeraAsync(EskaeraMota.Izarak.ToString());
            //Eskaera bidali dela jakinarazten dio bezeroari
            MessageBox.Show("Zure izarak aldatzeko eskaera bidali da.");
        }

        private async void btnZaborra_Click(object? sender, EventArgs e)
        {
            //EskaeraEginda ekitaldia jaurtitzen du, bezeroa eskaera mota bidaliz
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Zaborra);
            // Eskaera sortzen du, zaborra motakoa dela adieraziz
            await SortuEskaeraAsync(EskaeraMota.Zaborra.ToString());
            //Eskaera bidali dela jakinarazten dio bezeroari
            MessageBox.Show("Zure zaborra jasotzeko eskaera bidali da.");
        }

        private async void btnJatetxea_Click(object? sender, EventArgs e)
        {
            //EskaeraEginda ekitaldia jaurtitzen du, bezeroa eta eskaera mota bidaliz
            EskaeraEginda?.Invoke(bezeroa, EskaeraMota.Jatetxea);
            // Eskaera sortzen du, jatetxe erreserba dela adieraziz
            await SortuEskaeraAsync(EskaeraMota.Jatetxea.ToString());
            //Eskaera bidali dela jakinarazten dio bezeroari
            MessageBox.Show("Zure jatetxe zerbitzuaren eskaera bidali da.");
        }

        private void btnCheckOut_Click(object? sender, EventArgs e)
        {
            //Bezeroa joaten da, leihoa itxi egiten da
            Close();
        }

        private void FrmBezeroLehioa_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Datuak.MezuaBidalita -= MezuaJaso;

            //Lehioa ixtean bezeroa joan dela jakinarazten du
            CheckOutEginda?.Invoke(bezeroa);
        }

        //Idazkaritzak mezu bat bidaltzen duenean, bezero honena bada, azken lerroan gehitu
        private void MezuaJaso(int bezeroId, string lerroa)
        {
            if (bezeroId != bezeroa.Id) return;

            if (textMezua.TextLength > 0)
                textMezua.AppendText(Environment.NewLine);

            textMezua.AppendText(lerroa);
        }

        private void textIzena_TextChanged(object? sender, EventArgs e)
        {

        }

        private String sortuEskaeraID()
        {
            // Eskaera ID-a ausazkoa izatea aukeratu dugu, identifikatzeko hobeto eskaera bakoitza
            // Random metodoa deitzen dugu
            Random random = new Random();
            // Lehenengo zenbakia atera behar dugu, 1-tik 99-ra joango dela esaten diogu
            int zenbakia = random.Next(0, 100);
            // Gero letra, A-tik Z-ra arte, Z barne.
            char letra = (char)random.Next('A', 'Z' + 1);

            return $"{zenbakia:D2}{letra}";

        }

        private async Task SortuEskaeraAsync(String mota)
        {
            // Motaren arabera, eskaera sortzeko denbora bat egongo da.
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
                case "Jatetxea":
                    await Task.Delay(1000);
                    break;
            }
            String id_eskaera;
            // Gure eskaera sortzeko metodo deitzen dugu, eta ez da geldituko eskaera id hori errepikatuta ez dagoen arte.
            do
            {
                id_eskaera = sortuEskaeraID();
            } while (zerrenda.eskaerak.Any(e => e.eskaera_id == id_eskaera));

            // Gure langileen artean ausazko bat aterako da
            Random random = new Random();
            LangileakKudeatzen langile = (LangileakKudeatzen)random.Next(0, 4);

            // Azkenik, eskaeraren atributuak pasatzen dira, eta zerrerandara gehitzen da
            Eskaera e = new Eskaera(
                id_eskaera,
                bezeroa.Id,
                bezeroa.Izena,
                mota,
                langile.ToString()
                );

            zerrenda.eskaerak.Add(e);



        }
    }
}
