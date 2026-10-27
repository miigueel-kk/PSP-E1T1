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
            lblIzena.Location = new Point(214, 125);
            lblIzena.Name = "lblIzena";
            lblIzena.Size = new Size(44, 20);
            lblIzena.TabIndex = 2;
            lblIzena.Text = "Izena";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(214, 181);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 3;
            lblId.Text = "ID";
            // 
            // lblOstatua
            // 
            lblOstatua.AutoSize = true;
            lblOstatua.Location = new Point(214, 237);
            lblOstatua.Name = "lblOstatua";
            lblOstatua.Size = new Size(91, 20);
            lblOstatua.TabIndex = 4;
            lblOstatua.Text = "Ostatu Mota";
            // 
            // textIzena
            // 
            textIzena.Location = new Point(363, 125);
            textIzena.Margin = new Padding(3, 4, 3, 4);
            textIzena.Name = "textIzena";
            textIzena.Size = new Size(114, 27);
            textIzena.TabIndex = 5;
            textIzena.TextChanged += textIzena_TextChanged;
            // 
            // textID
            // 
            textID.Location = new Point(363, 183);
            textID.Margin = new Padding(3, 4, 3, 4);
            textID.Name = "textID";
            textID.Size = new Size(114, 27);
            textID.TabIndex = 6;
            // 
            // cmbOstatua
            // 
            cmbOstatua.FormattingEnabled = true;
            cmbOstatua.Location = new Point(363, 233);
            cmbOstatua.Margin = new Padding(3, 4, 3, 4);
            cmbOstatua.Name = "cmbOstatua";
            cmbOstatua.Size = new Size(138, 28);
            cmbOstatua.TabIndex = 7;
            // 
            // btnEskuoihalak
            // 
            btnEskuoihalak.Location = new Point(141, 352);
            btnEskuoihalak.Margin = new Padding(3, 4, 3, 4);
            btnEskuoihalak.Name = "btnEskuoihalak";
            btnEskuoihalak.Size = new Size(103, 40);
            btnEskuoihalak.TabIndex = 8;
            btnEskuoihalak.Text = "Eskuoihalak";
            btnEskuoihalak.UseVisualStyleBackColor = true;
            // 
            // btnIzarak
            // 
            btnIzarak.Location = new Point(287, 352);
            btnIzarak.Margin = new Padding(3, 4, 3, 4);
            btnIzarak.Name = "btnIzarak";
            btnIzarak.Size = new Size(103, 40);
            btnIzarak.TabIndex = 9;
            btnIzarak.Text = "Izarak";
            btnIzarak.UseVisualStyleBackColor = true;
           
            // 
            // btnZaborra
            // 
            btnZaborra.Location = new Point(454, 352);
            btnZaborra.Margin = new Padding(3, 4, 3, 4);
            btnZaborra.Name = "btnZaborra";
            btnZaborra.Size = new Size(103, 40);
            btnZaborra.TabIndex = 10;
            btnZaborra.Text = "Zaborra";
            btnZaborra.UseVisualStyleBackColor = true;
            // 
            // btnJatetxea
            // 
            btnJatetxea.Location = new Point(615, 352);
            btnJatetxea.Margin = new Padding(3, 4, 3, 4);
            btnJatetxea.Name = "btnJatetxea";
            btnJatetxea.Size = new Size(103, 40);
            btnJatetxea.TabIndex = 11;
            btnJatetxea.Text = "Jatetxea";
            btnJatetxea.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(231, 453);
            btnCheckOut.Margin = new Padding(3, 4, 3, 4);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(389, 53);
            btnCheckOut.TabIndex = 12;
            btnCheckOut.Text = "Check-out";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // FrmBezeroLeihoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmBezeroLeihoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBezeroLeihoa";
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