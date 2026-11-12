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
            this.zerrenda = zerrenda;

            // ComboBox osatu
            cmbOstatua.DataSource = Enum.GetValues(typeof(OstatuMota));

            // Ezkerreko taula konfiguratu eta XML-ko bezeroak kargatu
            KonfiguratuTaula();
            KargatuBezeroakTaulan();

            // Eskuineko formularioa prestatu (XML-ko azken ID-aren hurrengoa eta gaurko data)
            PrestatuFormularioBerria();
        }

        private void KonfiguratuTaula()
        {
            dgvBezeroak.Columns.Clear();
            dgvBezeroak.Columns.Add("izena", "Izena");
            dgvBezeroak.Columns.Add("abizena", "Abizena");
            dgvBezeroak.Columns.Add("ostatu_mota", "Ostatu mota");
        }

        private void KargatuBezeroakTaulan()
        {
            dgvBezeroak.Rows.Clear();
            Datuak.BezeroakList.Clear();

            List<Bezeroa> xmlBezeroak = BezeroXmlKudeatzailea.IrakurriBezeroakXmltik();
            foreach (Bezeroa b in xmlBezeroak)
            {
                Datuak.BezeroakList.Add(b);
                GehituErrenkadaTaulan(b);
            }

            dgvBezeroak.ClearSelection();
        }

        private void GehituErrenkadaTaulan(Bezeroa b)
        {
            int rowIndex = dgvBezeroak.Rows.Add(b.Izena, b.Abizena, b.Ostatua.ToString());
            dgvBezeroak.Rows[rowIndex].Tag = b;
        }

        private void PrestatuFormularioBerria()
        {
            txtId.Text = BezeroXmlKudeatzailea.KalkulatuHurrengoId().ToString();
            txtIzena.Clear();
            txtAbizena.Clear();
            txtEmaila.Clear();
            txtTelefonoa.Clear();
            if (cmbOstatua.Items.Count > 0)
            {
                cmbOstatua.SelectedIndex = 0;
            }
            txtSortzeEguna.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        // Taulako bezeroan kilkatzerakoan
        private void dgvBezeroak_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvBezeroak.Rows[e.RowIndex].Tag is not Bezeroa bezeroa) return;

            IrekiBezeroLeihoa(bezeroa);
        }

        // Bezeroaren leihoa bilatu (null bada, irekita ez dago)
        private FrmBezeroLeihoa? BilatuLeihoa(int bezeroId)
        {
            return Application.OpenForms
                .OfType<FrmBezeroLeihoa>()
                .FirstOrDefault(f => f.BezeroId == bezeroId);
        }

        // Leihoa ireki, edo aurrera ekarri jada irekita badago
        private FrmBezeroLeihoa IrekiBezeroLeihoa(Bezeroa bezeroa)
        {
            FrmBezeroLeihoa? leihoa = BilatuLeihoa(bezeroa.Id);

            if (leihoa == null)
            {
                leihoa = new FrmBezeroLeihoa(bezeroa, zerrenda);
                leihoa.Show();
            }
            else
            {
                leihoa.Activate();
            }

            return leihoa;
        }

        private void btnSortu_Click(object? sender, EventArgs e)
        {
            string izena = txtIzena.Text.Trim();
            string abizena = txtAbizena.Text.Trim();
            string emaila = txtEmaila.Text.Trim();
            string telefonoa = txtTelefonoa.Text.Trim();
            string sortzeEguna = txtSortzeEguna.Text.Trim();

            if (string.IsNullOrWhiteSpace(izena) ||
                string.IsNullOrWhiteSpace(abizena) ||
                string.IsNullOrWhiteSpace(emaila) ||
                string.IsNullOrWhiteSpace(telefonoa) ||
                string.IsNullOrWhiteSpace(sortzeEguna))
            {
                MessageBox.Show("Datu guztiak bete behar dituzu.", "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbOstatua.SelectedItem is not OstatuMota ostatua)
            {
                MessageBox.Show("Ostatu mota aukeratu behar duzu.", "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // XML-ko azken ID-aren hurrengoa kalkulatu
            int idBerria = BezeroXmlKudeatzailea.KalkulatuHurrengoId();

            // Bezeroa sortu eta memorian gorde
            Bezeroa bezeroa = Datuak.BezeroaSortu(
                idBerria,
                izena,
                abizena,
                emaila,
                telefonoa,
                ostatua,
                sortzeEguna);

            // XML fitxategian gorde
            BezeroXmlKudeatzailea.GehituBezeroaXmlan(bezeroa);

            // Ezkerreko taulan gehitu
            GehituErrenkadaTaulan(bezeroa);

            MessageBox.Show($"Bezeroa erregistratua: {bezeroa.Izena} {bezeroa.Abizena} (ID {bezeroa.Id})");

            // Bezero leihoa erakutsi datu guztiekin
            IrekiBezeroLeihoa(bezeroa);

            // Hurrengo bezerorako prestatu
            PrestatuFormularioBerria();
        }
    }
}
