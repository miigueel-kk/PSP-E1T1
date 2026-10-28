namespace IdazkaritzaApp.Formularioak
{
    partial class FrmBideojoko
    {
        //Diseinatzailearen osagaiak gordetzen ditu
        private System.ComponentModel.IContainer components = null;

        //Erabilitako baliabideak garbitzen ditu
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //Windows Form diseinatzaileak sortutako kodea
        private void InitializeComponent()
        {
            //Botoia sortzen du
            btnHasiBideojokoa = new Button();
            SuspendLayout();

            //Bideojokoa hasteko botoiaren konfigurazioa
            btnHasiBideojokoa.Location = new Point(250, 140);
            btnHasiBideojokoa.Margin = new Padding(3, 2, 3, 2);
            btnHasiBideojokoa.Name = "btnHasiBideojokoa";
            btnHasiBideojokoa.Size = new Size(200, 45);
            btnHasiBideojokoa.TabIndex = 0;
            btnHasiBideojokoa.Text = "Hasi bideojokoa";
            btnHasiBideojokoa.UseVisualStyleBackColor = true;

            //FrmBideojoko lehioaren konfigurazioa
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnHasiBideojokoa);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBideojoko";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bideojokoa";
            Load += FrmBideojoko_Load;
            ResumeLayout(false);
        }

        //Bideojokoa hasteko botoia
        private Button btnHasiBideojokoa;
    }
}