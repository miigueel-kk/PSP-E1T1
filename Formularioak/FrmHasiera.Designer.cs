namespace IdazkaritzaApp
{
    partial class FrmHasiera
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLangile = new Button();
            btnBezero = new Button();
            SuspendLayout();
            // 
            // btnLangile
            // 
            btnLangile.Location = new Point(283, 64);
            btnLangile.Name = "btnLangile";
            btnLangile.Size = new Size(235, 105);
            btnLangile.TabIndex = 0;
            btnLangile.Text = "Langilea";
            btnLangile.UseVisualStyleBackColor = true;
            btnLangile.Click += btnLangile_Click;
            // 
            // btnBezero
            // 
            btnBezero.Location = new Point(283, 277);
            btnBezero.Name = "btnBezero";
            btnBezero.Size = new Size(235, 105);
            btnBezero.TabIndex = 1;
            btnBezero.Text = "Bezero";
            btnBezero.UseVisualStyleBackColor = true;
            btnBezero.Click += btnBezero_Click;
            // 
            // FrmHasiera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBezero);
            Controls.Add(btnLangile);
            Name = "FrmHasiera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Idazkaritza";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLangile;
        private Button btnBezero;
    }
}
