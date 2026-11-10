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

            var mezuaZutabea = new DataGridViewButtonColumn
            {
                Name = "mezua",
                HeaderText = "Mezua",
                Text = "Mezua",
                UseColumnTextForButtonValue = true,
                FillWeight = 60                       
            };
            dgvBezeroak.Columns.Add(mezuaZutabea);

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

        private void dgvBezeroak_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvBezeroak.Rows[e.RowIndex].Tag is not Bezeroa bezeroa) return;

            if (dgvBezeroak.Columns[e.ColumnIndex].Name == "mezua")
                MezuaBidali(bezeroa);          
            else
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

        private void MezuaBidali(Bezeroa bezeroa)
        {
            string? testua = GaldetuMezua(bezeroa);
            if (string.IsNullOrWhiteSpace(testua)) return;   // utzi edo hutsik

            FrmBezeroLeihoa leihoa = IrekiBezeroLeihoa(bezeroa);
            leihoa.MezuaErakutsi(testua.Trim());
        }

        // Mezua idazteko leiho txikia (kodetik sortua, ez du diseinurik behar)
        private static string? GaldetuMezua(Bezeroa bezeroa)
        {
            using Form dialogoa = new Form
            {
                Text = $"Mezua - {bezeroa.Izena} {bezeroa.Abizena}",
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
            dialogoa.AcceptButton = btnBidali;   // Enter = bidali
            dialogoa.CancelButton = btnUtzi;     // Esc = utzi

            return dialogoa.ShowDialog() == DialogResult.OK ? txtMezua.Text : null;
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
            new FrmBezeroLeihoa(bezeroa, zerrenda).Show();

            // Hurrengo bezerorako prestatu
            PrestatuFormularioBerria();
        }
    }
}
