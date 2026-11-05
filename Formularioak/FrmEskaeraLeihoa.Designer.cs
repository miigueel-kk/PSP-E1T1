namespace IdazkaritzaApp.Formularioak
{
    partial class FrmEskaeraLeihoa
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
            lanaHasiBotoia = new Button();
            LanaBukatuBotoia = new Button();
            eskaeraTaula = new DataGridView();
            btnInportatuEsportatu = new Button();
            ((System.ComponentModel.ISupportInitialize)eskaeraTaula).BeginInit();
            SuspendLayout();
            // 
            // lanaHasiBotoia
            // 
            lanaHasiBotoia.Location = new Point(243, 57);
            lanaHasiBotoia.Margin = new Padding(3, 4, 3, 4);
            lanaHasiBotoia.Name = "lanaHasiBotoia";
            lanaHasiBotoia.Size = new Size(137, 53);
            lanaHasiBotoia.TabIndex = 0;
            lanaHasiBotoia.Text = "Lanaldia Hasi";
            lanaHasiBotoia.UseVisualStyleBackColor = true;
            lanaHasiBotoia.Click += button1_Click;
            // 
            // LanaBukatuBotoia
            // 
            LanaBukatuBotoia.Location = new Point(511, 57);
            LanaBukatuBotoia.Margin = new Padding(3, 4, 3, 4);
            LanaBukatuBotoia.Name = "LanaBukatuBotoia";
            LanaBukatuBotoia.Size = new Size(137, 53);
            LanaBukatuBotoia.TabIndex = 1;
            LanaBukatuBotoia.Text = "Lanaldia Bukatu";
            LanaBukatuBotoia.UseVisualStyleBackColor = true;
            LanaBukatuBotoia.Click += LanaBukatuBotoia_Click;
            // 
            // eskaeraTaula
            // 
            eskaeraTaula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eskaeraTaula.Location = new Point(125, 153);
            eskaeraTaula.Name = "eskaeraTaula";
            eskaeraTaula.RowHeadersWidth = 51;
            eskaeraTaula.Size = new Size(664, 266);
            eskaeraTaula.TabIndex = 2;
            eskaeraTaula.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnInportatuEsportatu
            // 
            btnInportatuEsportatu.Location = new Point(357, 460); // Taularen azpian kokatuta
            btnInportatuEsportatu.Name = "btnInportatuEsportatu";
            btnInportatuEsportatu.Size = new Size(200, 45);
            btnInportatuEsportatu.TabIndex = 3;
            btnInportatuEsportatu.Text = "Inportatu / Esportatu";
            btnInportatuEsportatu.UseVisualStyleBackColor = true;
            btnInportatuEsportatu.Click += btnInportatuEsportatu_Click;
            // 
            // EskaeraLeihoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnInportatuEsportatu);
            Controls.Add(eskaeraTaula);
            Controls.Add(LanaBukatuBotoia);
            Controls.Add(lanaHasiBotoia);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EskaeraLeihoa";
            Text = "EskaeraLeihoa";
            ((System.ComponentModel.ISupportInitialize)eskaeraTaula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button lanaHasiBotoia;
        private Button LanaBukatuBotoia;
        private DataGridView eskaeraTaula;
        private Button btnInportatuEsportatu;
    }
}
