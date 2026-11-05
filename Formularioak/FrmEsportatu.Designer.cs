namespace IdazkaritzaApp.Formularioak
{
    partial class FormEsportatu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnInportatu = new System.Windows.Forms.Button();
            this.rbCSV = new System.Windows.Forms.RadioButton();
            this.rbXML = new System.Windows.Forms.RadioButton();
            this.lblProbintzia = new System.Windows.Forms.Label();
            this.lblHerria = new System.Windows.Forms.Label();
            this.cmbProbintzia = new System.Windows.Forms.ComboBox();
            this.cmbHerria = new System.Windows.Forms.ComboBox();
            this.btnEsportatu = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgresua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInportatu
            // 
            this.btnInportatu.Location = new System.Drawing.Point(110, 45);
            this.btnInportatu.Name = "btnInportatu";
            this.btnInportatu.Size = new System.Drawing.Size(220, 45);
            this.btnInportatu.TabIndex = 0;
            this.btnInportatu.Text = "INPORTATU DATUAK";
            this.btnInportatu.UseVisualStyleBackColor = true;
            this.btnInportatu.Click += new System.EventHandler(this.btnInportatu_Click);
            // 
            // rbCSV
            // 
            this.rbCSV.AutoSize = true;
            this.rbCSV.Checked = true;
            this.rbCSV.Location = new System.Drawing.Point(155, 120);
            this.rbCSV.Name = "rbCSV";
            this.rbCSV.Size = new System.Drawing.Size(55, 20);
            this.rbCSV.TabIndex = 1;
            this.rbCSV.TabStop = true;
            this.rbCSV.Text = "CSV";
            this.rbCSV.UseVisualStyleBackColor = true;
            // 
            // rbXML
            // 
            this.rbXML.AutoSize = true;
            this.rbXML.Location = new System.Drawing.Point(235, 120);
            this.rbXML.Name = "rbXML";
            this.rbXML.Size = new System.Drawing.Size(58, 20);
            this.rbXML.TabIndex = 2;
            this.rbXML.Text = "XML";
            this.rbXML.UseVisualStyleBackColor = true;
            // 
            // lblProbintzia
            // 
            this.lblProbintzia.AutoSize = true;
            this.lblProbintzia.Location = new System.Drawing.Point(65, 180);
            this.lblProbintzia.Name = "lblProbintzia";
            this.lblProbintzia.Size = new System.Drawing.Size(80, 15);
            this.lblProbintzia.TabIndex = 3;
            this.lblProbintzia.Text = "PROBINTZIA";
            // 
            // cmbProbintzia
            // 
            this.cmbProbintzia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProbintzia.FormattingEnabled = true;
            this.cmbProbintzia.Location = new System.Drawing.Point(165, 177);
            this.cmbProbintzia.Name = "cmbProbintzia";
            this.cmbProbintzia.Size = new System.Drawing.Size(165, 23);
            this.cmbProbintzia.TabIndex = 4;
            this.cmbProbintzia.SelectedIndexChanged += new System.EventHandler(this.cmbProbintzia_SelectedIndexChanged);
            // 
            // lblHerria
            // 
            this.lblHerria.AutoSize = true;
            this.lblHerria.Location = new System.Drawing.Point(65, 230);
            this.lblHerria.Name = "lblHerria";
            this.lblHerria.Size = new System.Drawing.Size(55, 15);
            this.lblHerria.TabIndex = 5;
            this.lblHerria.Text = "HERRIA";
            // 
            // cmbHerria
            // 
            this.cmbHerria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHerria.FormattingEnabled = true;
            this.cmbHerria.Location = new System.Drawing.Point(165, 227);
            this.cmbHerria.Name = "cmbHerria";
            this.cmbHerria.Size = new System.Drawing.Size(165, 23);
            this.cmbHerria.TabIndex = 6;
            // 
            // btnEsportatu
            // 
            this.btnEsportatu.Location = new System.Drawing.Point(110, 290);
            this.btnEsportatu.Name = "btnEsportatu";
            this.btnEsportatu.Size = new System.Drawing.Size(220, 45);
            this.btnEsportatu.TabIndex = 7;
            this.btnEsportatu.Text = "ESPORTATU DATUAK";
            this.btnEsportatu.UseVisualStyleBackColor = true;
            this.btnEsportatu.Click += new System.EventHandler(this.btnEsportatu_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(65, 350);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(310, 28);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // lblProgresua
            // 
            this.lblProgresua.Location = new System.Drawing.Point(65, 383);
            this.lblProgresua.Name = "lblProgresua";
            this.lblProgresua.Size = new System.Drawing.Size(310, 20);
            this.lblProgresua.TabIndex = 9;
            this.lblProgresua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProgresua.Visible = false;
            // 
            // FormEsportatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 420);
            this.Controls.Add(this.lblProgresua);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnEsportatu);
            this.Controls.Add(this.cmbHerria);
            this.Controls.Add(this.lblHerria);
            this.Controls.Add(this.cmbProbintzia);
            this.Controls.Add(this.lblProbintzia);
            this.Controls.Add(this.rbXML);
            this.Controls.Add(this.rbCSV);
            this.Controls.Add(this.btnInportatu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEsportatu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Idazkaritza Aplikazioa";
            this.Load += new System.EventHandler(this.FormEsportatu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnInportatu;
        private System.Windows.Forms.RadioButton rbCSV;
        private System.Windows.Forms.RadioButton rbXML;
        private System.Windows.Forms.Label lblProbintzia;
        private System.Windows.Forms.Label lblHerria;
        private System.Windows.Forms.ComboBox cmbProbintzia;
        private System.Windows.Forms.ComboBox cmbHerria;
        private System.Windows.Forms.Button btnEsportatu;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgresua;
    }
}
