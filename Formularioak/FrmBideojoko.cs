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
    public partial class FrmBideojoko : Form
    {
        //Lehio honen bideojokoa gordetzen du
        private readonly Bideojoko bideojoko;

        //Lehioa sortzen denean bideojokoa hasieratzen du
        public FrmBideojoko()
        {
            //Windows forms sortutako osagai guztiak sartzen ditu
            InitializeComponent();

            //Bideojoko objektua sortzen du
            this.bideojoko = new Bideojoko();

            //Botoia klikatzean bere metodoa exekutatzen da
            btnHasiBideojokoa.Click += btnHasiBideojokoa_Click;
        }
        
        private void btnHasiBideojokoa_Click(object sender, EventArgs e) 
        {
            //Bideojokoaren prozesua hasten du
            bideojoko.Hasi(out string mezua);
            //Mezua erakusten du
            MessageBox.Show(mezua);
        }

        private void FrmBideojoko_Load(object sender, EventArgs e)
        {

        }
    }
}