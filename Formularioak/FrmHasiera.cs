using IdazkaritzaApp.Formularioak;
using IdazkaritzaApp.Modeloak;

namespace IdazkaritzaApp
{
    public partial class FrmHasiera : Form
    {
        private EskaeraZerrenda zerrenda = new EskaeraZerrenda();
        public FrmHasiera()
        {
            InitializeComponent();
        }

        private void btnLangile_Click(object sender, EventArgs e)
        {
            new EskaeraLeihoa(zerrenda).Show();
        }

        private void btnBezero_Click(object sender, EventArgs e)
        {
            //Bezero berria
            new FrmBezeroBerria(zerrenda).Show();
        }

    }
}
