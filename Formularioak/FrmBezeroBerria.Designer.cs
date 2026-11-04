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
            lblZerrenda = new Label();
            dgvBezeroak = new DataGridView();
            lblBerria = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblIzena = new Label();
            txtIzena = new TextBox();
            lblAbizena = new Label();
            txtAbizena = new TextBox();
            lblEmaila = new Label();
            txtEmaila = new TextBox();
            lblTelefonoa = new Label();
            txtTelefonoa = new TextBox();
            lblOstatua = new Label();
            cmbOstatua = new ComboBox();
            lblSortzeEguna = new Label();
            txtSortzeEguna = new TextBox();
            btnSortu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBezeroak).BeginInit();
            SuspendLayout();
            // 
            // lblZerrenda
            // 
            lblZerrenda.AutoSize = true;
            lblZerrenda.Font = new Font("Segoe UI", 10F);
            lblZerrenda.Location = new Point(25, 22);
            lblZerrenda.Name = "lblZerrenda";
            lblZerrenda.Size = new Size(148, 23);
            lblZerrenda.TabIndex = 0;
            lblZerrenda.Text = "Bezeroen zerrenda";
            // 
            // dgvBezeroak
            // 
            dgvBezeroak.AllowUserToAddRows = false;
            dgvBezeroak.AllowUserToDeleteRows = false;
            dgvBezeroak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBezeroak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBezeroak.Location = new Point(25, 55);
            dgvBezeroak.MultiSelect = false;
            dgvBezeroak.Name = "dgvBezeroak";
            dgvBezeroak.ReadOnly = true;
            dgvBezeroak.RowHeadersVisible = false;
            dgvBezeroak.RowTemplate.Height = 29;
            dgvBezeroak.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBezeroak.Size = new Size(440, 390);
            dgvBezeroak.TabIndex = 1;
            dgvBezeroak.CellClick += dgvBezeroak_CellClick;
            // 
            // lblBerria
            // 
            lblBerria.AutoSize = true;
            lblBerria.Font = new Font("Segoe UI", 10F);
            lblBerria.Location = new Point(510, 22);
            lblBerria.Name = "lblBerria";
            lblBerria.Size = new Size(202, 23);
            lblBerria.TabIndex = 2;
            lblBerria.Text = "Bezero berria erregistratu";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(510, 68);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 3;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(645, 65);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(90, 27);
            txtId.TabIndex = 4;
            // 
            // lblIzena
            // 
            lblIzena.AutoSize = true;
            lblIzena.Location = new Point(510, 113);
            lblIzena.Name = "lblIzena";
            lblIzena.Size = new Size(44, 20);
            lblIzena.TabIndex = 5;
            lblIzena.Text = "Izena";
            // 
            // txtIzena
            // 
            txtIzena.Location = new Point(645, 110);
            txtIzena.Name = "txtIzena";
            txtIzena.Size = new Size(220, 27);
            txtIzena.TabIndex = 6;
            // 
            // lblAbizena
            // 
            lblAbizena.AutoSize = true;
            lblAbizena.Location = new Point(510, 158);
            lblAbizena.Name = "lblAbizena";
            lblAbizena.Size = new Size(62, 20);
            lblAbizena.TabIndex = 7;
            lblAbizena.Text = "Abizena";
            // 
            // txtAbizena
            // 
            txtAbizena.Location = new Point(645, 155);
            txtAbizena.Name = "txtAbizena";
            txtAbizena.Size = new Size(220, 27);
            txtAbizena.TabIndex = 8;
            // 
            // lblEmaila
            // 
            lblEmaila.AutoSize = true;
            lblEmaila.Location = new Point(510, 203);
            lblEmaila.Name = "lblEmaila";
            lblEmaila.Size = new Size(52, 20);
            lblEmaila.TabIndex = 9;
            lblEmaila.Text = "Emaila";
            // 
            // txtEmaila
            // 
            txtEmaila.Location = new Point(645, 200);
            txtEmaila.Name = "txtEmaila";
            txtEmaila.Size = new Size(220, 27);
            txtEmaila.TabIndex = 10;
            // 
            // lblTelefonoa
            // 
            lblTelefonoa.AutoSize = true;
            lblTelefonoa.Location = new Point(510, 248);
            lblTelefonoa.Name = "lblTelefonoa";
            lblTelefonoa.Size = new Size(74, 20);
            lblTelefonoa.TabIndex = 11;
            lblTelefonoa.Text = "Telefonoa";
            // 
            // txtTelefonoa
            // 
            txtTelefonoa.Location = new Point(645, 245);
            txtTelefonoa.Name = "txtTelefonoa";
            txtTelefonoa.Size = new Size(220, 27);
            txtTelefonoa.TabIndex = 12;
            // 
            // lblOstatua
            // 
            lblOstatua.AutoSize = true;
            lblOstatua.Location = new Point(510, 293);
            lblOstatua.Name = "lblOstatua";
            lblOstatua.Size = new Size(91, 20);
            lblOstatua.TabIndex = 13;
            lblOstatua.Text = "Ostatu mota";
            // 
            // cmbOstatua
            // 
            cmbOstatua.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOstatua.FormattingEnabled = true;
            cmbOstatua.Location = new Point(645, 290);
            cmbOstatua.Name = "cmbOstatua";
            cmbOstatua.Size = new Size(220, 28);
            cmbOstatua.TabIndex = 14;
            // 
            // lblSortzeEguna
            // 
            lblSortzeEguna.AutoSize = true;
            lblSortzeEguna.Location = new Point(510, 338);
            lblSortzeEguna.Name = "lblSortzeEguna";
            lblSortzeEguna.Size = new Size(96, 20);
            lblSortzeEguna.TabIndex = 15;
            lblSortzeEguna.Text = "Sortze eguna";
            // 
            // txtSortzeEguna
            // 
            txtSortzeEguna.Location = new Point(645, 335);
            txtSortzeEguna.Name = "txtSortzeEguna";
            txtSortzeEguna.Size = new Size(220, 27);
            txtSortzeEguna.TabIndex = 16;
            // 
            // btnSortu
            // 
            btnSortu.Location = new Point(600, 395);
            btnSortu.Name = "btnSortu";
            btnSortu.Size = new Size(190, 47);
            btnSortu.TabIndex = 17;
            btnSortu.Text = "Erregistratu";
            btnSortu.UseVisualStyleBackColor = true;
            btnSortu.Click += btnSortu_Click;
            // 
            // FrmBezeroBerria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 475);
            Controls.Add(lblZerrenda);
            Controls.Add(dgvBezeroak);
            Controls.Add(lblBerria);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtIzena);
            Controls.Add(lblIzena);
            Controls.Add(txtAbizena);
            Controls.Add(lblAbizena);
            Controls.Add(txtEmaila);
            Controls.Add(lblEmaila);
            Controls.Add(txtTelefonoa);
            Controls.Add(lblTelefonoa);
            Controls.Add(cmbOstatua);
            Controls.Add(lblOstatua);
            Controls.Add(txtSortzeEguna);
            Controls.Add(lblSortzeEguna);
            Controls.Add(btnSortu);
            Name = "FrmBezeroBerria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bezero berria";
            ((System.ComponentModel.ISupportInitialize)dgvBezeroak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblZerrenda;
        private DataGridView dgvBezeroak;
        private Label lblBerria;
        private Label lblId;
        private TextBox txtId;
        private Label lblIzena;
        private TextBox txtIzena;
        private Label lblAbizena;
        private TextBox txtAbizena;
        private Label lblEmaila;
        private TextBox txtEmaila;
        private Label lblTelefonoa;
        private TextBox txtTelefonoa;
        private Label lblOstatua;
        private ComboBox cmbOstatua;
        private Label lblSortzeEguna;
        private TextBox txtSortzeEguna;
        private Button btnSortu;
    }
}
