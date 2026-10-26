namespace IdazkaritzaApp.Formularioak
{
    partial class EskaeraLeihoa
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
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(211, 59);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 0;
            button1.Text = "Lanaldia Hasi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(444, 59);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 1;
            button2.Text = "Lanaldia Bukatu";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(checkBox2, 3, 2);
            tableLayoutPanel1.Controls.Add(checkBox1, 3, 1);
            tableLayoutPanel1.Controls.Add(checkBox3, 3, 3);
            tableLayoutPanel1.Controls.Add(checkBox4, 3, 4);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(124, 130);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(582, 221);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(63, 103);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Ez amaituta";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(63, 53);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Amaituta";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(63, 153);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(75, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Amaituta";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(63, 203);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(87, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Ez amaituta";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 0);
            label2.Name = "label2";
            label2.Size = new Size(14, 45);
            label2.TabIndex = 5;
            label2.Text = "Mota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 0);
            label3.Name = "label3";
            label3.Size = new Size(14, 50);
            label3.TabIndex = 6;
            label3.Text = "Bezeroa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Egoera";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(14, 50);
            label1.TabIndex = 4;
            label1.Text = "Langilea_Kudeatzen";
            label1.Click += label1_Click;
            // 
            // EskaeraLeihoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EskaeraLeihoa";
            Text = "EskaeraLeihoa";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
    }
}