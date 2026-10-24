using IdazkaritzaApp.Formularioak;

namespace IdazkaritzaApp
{
    public partial class FrmHasiera : Form
    {
        public FrmHasiera()
        {
            InitializeComponent();
        }

        private void btnLangile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Langile");
        }

        private void btnBezero_Click(object sender, EventArgs e)
        {
            //Bezero berria
            new FrmBezeroBerria().Show();
        }

    }
}
