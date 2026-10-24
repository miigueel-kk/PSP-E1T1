namespace IdazkaritzaApp.Formularioak
{
    partial class FrmBezeroLehioa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIzena = new Label();
            lblId = new Label();
            lblOstatua = new Label();
            textIzena = new TextBox();
            textID = new TextBox();
            cmbOstatua = new ComboBox();
            btnEskuoihalak = new Button();
            btnIzarak = new Button();
            btnZaborra = new Button();
            btnJatetxea = new Button();
            btnCheckOut = new Button();
            SuspendLayout();
            // 
            // lblIzena
            // 
            lblIzena.AutoSize = true;
            lblIzena.Location = new Point(187, 94);
            lblIzena.Name = "lblIzena";
            lblIzena.Size = new Size(34, 15);
            lblIzena.TabIndex = 2;
            lblIzena.Text = "Izena";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(187, 136);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 3;
            lblId.Text = "ID";
            // 
            // lblOstatua
            // 
            lblOstatua.AutoSize = true;
            lblOstatua.Location = new Point(187, 178);
            lblOstatua.Name = "lblOstatua";
            lblOstatua.Size = new Size(73, 15);
            lblOstatua.TabIndex = 4;
            lblOstatua.Text = "Ostatu Mota";
            // 
            // textIzena
            // 
            textIzena.Location = new Point(318, 94);
            textIzena.Name = "textIzena";
            textIzena.Size = new Size(100, 23);
            textIzena.TabIndex = 5;
            // 
            // textID
            // 
            textID.Location = new Point(318, 137);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 6;
            // 
            // cmbOstatua
            // 
            cmbOstatua.FormattingEnabled = true;
            cmbOstatua.Location = new Point(318, 175);
            cmbOstatua.Name = "cmbOstatua";
            cmbOstatua.Size = new Size(121, 23);
            cmbOstatua.TabIndex = 7;
            // 
            // btnEskuoihalak
            // 
            btnEskuoihalak.Location = new Point(123, 264);
            btnEskuoihalak.Name = "btnEskuoihalak";
            btnEskuoihalak.Size = new Size(90, 30);
            btnEskuoihalak.TabIndex = 8;
            btnEskuoihalak.Text = "Eskuoihalak";
            btnEskuoihalak.UseVisualStyleBackColor = true;
            // 
            // btnIzarak
            // 
            btnIzarak.Location = new Point(251, 264);
            btnIzarak.Name = "btnIzarak";
            btnIzarak.Size = new Size(90, 30);
            btnIzarak.TabIndex = 9;
            btnIzarak.Text = "Izarak";
            btnIzarak.UseVisualStyleBackColor = true;
            // 
            // btnZaborra
            // 
            btnZaborra.Location = new Point(397, 264);
            btnZaborra.Name = "btnZaborra";
            btnZaborra.Size = new Size(90, 30);
            btnZaborra.TabIndex = 10;
            btnZaborra.Text = "Zaborra";
            btnZaborra.UseVisualStyleBackColor = true;
            // 
            // btnJatetxea
            // 
            btnJatetxea.Location = new Point(538, 264);
            btnJatetxea.Name = "btnJatetxea";
            btnJatetxea.Size = new Size(90, 30);
            btnJatetxea.TabIndex = 11;
            btnJatetxea.Text = "Jatetxea";
            btnJatetxea.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(202, 340);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(340, 40);
            btnCheckOut.TabIndex = 12;
            btnCheckOut.Text = "Check-out";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // FrmBezeroLehioa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCheckOut);
            Controls.Add(btnJatetxea);
            Controls.Add(btnZaborra);
            Controls.Add(btnIzarak);
            Controls.Add(btnEskuoihalak);
            Controls.Add(cmbOstatua);
            Controls.Add(textID);
            Controls.Add(textIzena);
            Controls.Add(lblOstatua);
            Controls.Add(lblId);
            Controls.Add(lblIzena);
            Name = "FrmBezeroLehioa";
            Text = "FrmBezeroLehioa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblIzena;
        private Label lblId;
        private Label lblOstatua;
        private TextBox textIzena;
        private TextBox textID;
        private ComboBox cmbOstatua;
        private Button btnEskuoihalak;
        private Button btnIzarak;
        private Button btnZaborra;
        private Button btnJatetxea;
        private Button btnCheckOut;
    }
}