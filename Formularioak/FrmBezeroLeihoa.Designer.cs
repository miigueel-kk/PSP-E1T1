namespace IdazkaritzaApp.Formularioak
{
    partial class FrmBezeroLeihoa
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
            lblId = new Label();
            textID = new TextBox();
            lblIzena = new Label();
            textIzena = new TextBox();
            lblAbizena = new Label();
            textAbizena = new TextBox();
            lblEmaila = new Label();
            textEmaila = new TextBox();
            lblTelefonoa = new Label();
            textTelefonoa = new TextBox();
            lblOstatua = new Label();
            cmbOstatua = new ComboBox();
            lblMezua = new Label();
            textSortzeEguna = new TextBox();
            btnEskuoihalak = new Button();
            btnIzarak = new Button();
            btnZaborra = new Button();
            btnJatetxea = new Button();
            btnCheckOut = new Button();
            textMezua = new TextBox();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(219, 26);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // textID
            // 
            textID.Location = new Point(350, 24);
            textID.Name = "textID";
            textID.ReadOnly = true;
            textID.Size = new Size(210, 23);
            textID.TabIndex = 1;
            // 
            // lblIzena
            // 
            lblIzena.AutoSize = true;
            lblIzena.Location = new Point(219, 58);
            lblIzena.Name = "lblIzena";
            lblIzena.Size = new Size(34, 15);
            lblIzena.TabIndex = 2;
            lblIzena.Text = "Izena";
            // 
            // textIzena
            // 
            textIzena.Location = new Point(350, 56);
            textIzena.Name = "textIzena";
            textIzena.ReadOnly = true;
            textIzena.Size = new Size(210, 23);
            textIzena.TabIndex = 3;
            textIzena.TextChanged += textIzena_TextChanged;
            // 
            // lblAbizena
            // 
            lblAbizena.AutoSize = true;
            lblAbizena.Location = new Point(219, 89);
            lblAbizena.Name = "lblAbizena";
            lblAbizena.Size = new Size(49, 15);
            lblAbizena.TabIndex = 4;
            lblAbizena.Text = "Abizena";
            // 
            // textAbizena
            // 
            textAbizena.Location = new Point(350, 87);
            textAbizena.Name = "textAbizena";
            textAbizena.ReadOnly = true;
            textAbizena.Size = new Size(210, 23);
            textAbizena.TabIndex = 5;
            // 
            // lblEmaila
            // 
            lblEmaila.AutoSize = true;
            lblEmaila.Location = new Point(219, 121);
            lblEmaila.Name = "lblEmaila";
            lblEmaila.Size = new Size(42, 15);
            lblEmaila.TabIndex = 6;
            lblEmaila.Text = "Emaila";
            // 
            // textEmaila
            // 
            textEmaila.Location = new Point(350, 118);
            textEmaila.Name = "textEmaila";
            textEmaila.ReadOnly = true;
            textEmaila.Size = new Size(210, 23);
            textEmaila.TabIndex = 7;
            // 
            // lblTelefonoa
            // 
            lblTelefonoa.AutoSize = true;
            lblTelefonoa.Location = new Point(219, 152);
            lblTelefonoa.Name = "lblTelefonoa";
            lblTelefonoa.Size = new Size(59, 15);
            lblTelefonoa.TabIndex = 8;
            lblTelefonoa.Text = "Telefonoa";
            // 
            // textTelefonoa
            // 
            textTelefonoa.Location = new Point(350, 150);
            textTelefonoa.Name = "textTelefonoa";
            textTelefonoa.ReadOnly = true;
            textTelefonoa.Size = new Size(210, 23);
            textTelefonoa.TabIndex = 9;
            // 
            // lblOstatua
            // 
            lblOstatua.AutoSize = true;
            lblOstatua.Location = new Point(219, 184);
            lblOstatua.Name = "lblOstatua";
            lblOstatua.Size = new Size(73, 15);
            lblOstatua.TabIndex = 10;
            lblOstatua.Text = "Ostatu Mota";
            // 
            // cmbOstatua
            // 
            cmbOstatua.FormattingEnabled = true;
            cmbOstatua.Location = new Point(350, 182);
            cmbOstatua.Name = "cmbOstatua";
            cmbOstatua.Size = new Size(210, 23);
            cmbOstatua.TabIndex = 11;
            // 
            // lblMezua
            // 
            lblMezua.AutoSize = true;
            lblMezua.Location = new Point(220, 282);
            lblMezua.Name = "lblMezua";
            lblMezua.Size = new Size(48, 15);
            lblMezua.TabIndex = 12;
            lblMezua.Text = "Mezuak";
            // 
            // textSortzeEguna
            // 
            textSortzeEguna.Location = new Point(350, 213);
            textSortzeEguna.Name = "textSortzeEguna";
            textSortzeEguna.ReadOnly = true;
            textSortzeEguna.Size = new Size(210, 23);
            textSortzeEguna.TabIndex = 13;
            // 
            // btnEskuoihalak
            // 
            btnEskuoihalak.Location = new Point(137, 341);
            btnEskuoihalak.Name = "btnEskuoihalak";
            btnEskuoihalak.Size = new Size(90, 30);
            btnEskuoihalak.TabIndex = 14;
            btnEskuoihalak.Text = "Eskuoihalak";
            btnEskuoihalak.UseVisualStyleBackColor = true;
            // 
            // btnIzarak
            // 
            btnIzarak.Location = new Point(265, 341);
            btnIzarak.Name = "btnIzarak";
            btnIzarak.Size = new Size(90, 30);
            btnIzarak.TabIndex = 15;
            btnIzarak.Text = "Izarak";
            btnIzarak.UseVisualStyleBackColor = true;
            // 
            // btnZaborra
            // 
            btnZaborra.Location = new Point(411, 341);
            btnZaborra.Name = "btnZaborra";
            btnZaborra.Size = new Size(90, 30);
            btnZaborra.TabIndex = 16;
            btnZaborra.Text = "Zaborra";
            btnZaborra.UseVisualStyleBackColor = true;
            // 
            // btnJatetxea
            // 
            btnJatetxea.Location = new Point(552, 341);
            btnJatetxea.Name = "btnJatetxea";
            btnJatetxea.Size = new Size(90, 30);
            btnJatetxea.TabIndex = 17;
            btnJatetxea.Text = "Jatetxea";
            btnJatetxea.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(219, 409);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(341, 40);
            btnCheckOut.TabIndex = 18;
            btnCheckOut.Text = "Check-out";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // textMezua
            // 
            textMezua.Location = new Point(350, 256);
            textMezua.Multiline = true;
            textMezua.Name = "textMezua";
            textMezua.ReadOnly = true;
            textMezua.ScrollBars = ScrollBars.Vertical;
            textMezua.Size = new Size(210, 65);
            textMezua.TabIndex = 19;
            // 
            // FrmBezeroLeihoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(textMezua);
            Controls.Add(btnCheckOut);
            Controls.Add(btnJatetxea);
            Controls.Add(btnZaborra);
            Controls.Add(btnIzarak);
            Controls.Add(btnEskuoihalak);
            Controls.Add(textSortzeEguna);
            Controls.Add(lblMezua);
            Controls.Add(cmbOstatua);
            Controls.Add(lblOstatua);
            Controls.Add(textTelefonoa);
            Controls.Add(lblTelefonoa);
            Controls.Add(textEmaila);
            Controls.Add(lblEmaila);
            Controls.Add(textAbizena);
            Controls.Add(lblAbizena);
            Controls.Add(textIzena);
            Controls.Add(lblIzena);
            Controls.Add(textID);
            Controls.Add(lblId);
            Name = "FrmBezeroLeihoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBezeroLeihoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblId;
        private TextBox textID;
        private Label lblIzena;
        private TextBox textIzena;
        private Label lblAbizena;
        private TextBox textAbizena;
        private Label lblEmaila;
        private TextBox textEmaila;
        private Label lblTelefonoa;
        private TextBox textTelefonoa;
        private Label lblOstatua;
        private ComboBox cmbOstatua;
        private Label lblMezua;
        private TextBox textSortzeEguna;
        private Button btnEskuoihalak;
        private Button btnIzarak;
        private Button btnZaborra;
        private Button btnJatetxea;
        private Button btnCheckOut;
        private TextBox textMezua;
    }
}
