namespace IdazkaritzaApp.Formularioak
{
    partial class FrmBezeroBerria
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
            txtIzena = new TextBox();
            lblOstatua = new Label();
            cmbOstatua = new ComboBox();
            btnSortu = new Button();
            lblId = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // lblIzena
            // 
            lblIzena.AutoSize = true;
            lblIzena.Location = new Point(258, 134);
            lblIzena.Name = "lblIzena";
            lblIzena.Size = new Size(44, 20);
            lblIzena.TabIndex = 0;
            lblIzena.Text = "Izena";
            // 
            // txtIzena
            // 
            txtIzena.Location = new Point(411, 134);
            txtIzena.Name = "txtIzena";
            txtIzena.Size = new Size(148, 27);
            txtIzena.TabIndex = 1;
            // 
            // lblOstatua
            // 
            lblOstatua.AutoSize = true;
            lblOstatua.Location = new Point(258, 197);
            lblOstatua.Name = "lblOstatua";
            lblOstatua.Size = new Size(91, 20);
            lblOstatua.TabIndex = 2;
            lblOstatua.Text = "Ostatu mota";
            // 
            // cmbOstatua
            // 
            cmbOstatua.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOstatua.FormattingEnabled = true;
            cmbOstatua.Location = new Point(411, 197);
            cmbOstatua.Name = "cmbOstatua";
            cmbOstatua.Size = new Size(148, 28);
            cmbOstatua.TabIndex = 3;
            // 
            // btnSortu
            // 
            btnSortu.Location = new Point(318, 277);
            btnSortu.Name = "btnSortu";
            btnSortu.Size = new Size(164, 47);
            btnSortu.TabIndex = 4;
            btnSortu.Text = "Erregistratu";
            btnSortu.UseVisualStyleBackColor = true;
            btnSortu.Click += btnSortu_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(258, 77);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 5;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(411, 77);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(71, 27);
            txtId.TabIndex = 6;
            // 
            // FrmBezeroBerria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnSortu);
            Controls.Add(cmbOstatua);
            Controls.Add(lblOstatua);
            Controls.Add(txtIzena);
            Controls.Add(lblIzena);
            Name = "FrmBezeroBerria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bezero berria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIzena;
        private TextBox txtIzena;
        private Label lblOstatua;
        private ComboBox cmbOstatua;
        private Button btnSortu;
        private Label lblId;
        private TextBox txtId;
    }
}