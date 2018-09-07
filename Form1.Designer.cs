namespace Herunterfahren
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_ab = new System.Windows.Forms.Button();
            this.nud_h = new System.Windows.Forms.NumericUpDown();
            this.lbl_zeit = new System.Windows.Forms.Label();
            this.nud_m = new System.Windows.Forms.NumericUpDown();
            this.nud_s = new System.Windows.Forms.NumericUpDown();
            this.rbn_her = new System.Windows.Forms.RadioButton();
            this.rbn_neu = new System.Windows.Forms.RadioButton();
            this.rbn_abb = new System.Windows.Forms.RadioButton();
            this.lbl_was = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_s)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(13, 151);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_ab
            // 
            this.btn_ab.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ab.Location = new System.Drawing.Point(94, 151);
            this.btn_ab.Name = "btn_ab";
            this.btn_ab.Size = new System.Drawing.Size(72, 23);
            this.btn_ab.TabIndex = 1;
            this.btn_ab.Text = "Abbrechen";
            this.btn_ab.UseVisualStyleBackColor = true;
            this.btn_ab.Click += new System.EventHandler(this.btn_ab_Click);
            // 
            // nud_h
            // 
            this.nud_h.Location = new System.Drawing.Point(13, 125);
            this.nud_h.Name = "nud_h";
            this.nud_h.Size = new System.Drawing.Size(47, 20);
            this.nud_h.TabIndex = 2;
            // 
            // lbl_zeit
            // 
            this.lbl_zeit.AutoSize = true;
            this.lbl_zeit.Location = new System.Drawing.Point(13, 106);
            this.lbl_zeit.Name = "lbl_zeit";
            this.lbl_zeit.Size = new System.Drawing.Size(120, 13);
            this.lbl_zeit.TabIndex = 3;
            this.lbl_zeit.Text = "Verzögerung (hh:mm:ss)";
            // 
            // nud_m
            // 
            this.nud_m.Location = new System.Drawing.Point(66, 125);
            this.nud_m.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_m.Name = "nud_m";
            this.nud_m.Size = new System.Drawing.Size(47, 20);
            this.nud_m.TabIndex = 2;
            // 
            // nud_s
            // 
            this.nud_s.Location = new System.Drawing.Point(119, 125);
            this.nud_s.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_s.Name = "nud_s";
            this.nud_s.Size = new System.Drawing.Size(47, 20);
            this.nud_s.TabIndex = 2;
            // 
            // rbn_her
            // 
            this.rbn_her.AutoSize = true;
            this.rbn_her.Checked = true;
            this.rbn_her.Location = new System.Drawing.Point(12, 28);
            this.rbn_her.Name = "rbn_her";
            this.rbn_her.Size = new System.Drawing.Size(96, 17);
            this.rbn_her.TabIndex = 4;
            this.rbn_her.TabStop = true;
            this.rbn_her.Text = "Herunterfahren";
            this.rbn_her.UseVisualStyleBackColor = true;
            // 
            // rbn_neu
            // 
            this.rbn_neu.AutoSize = true;
            this.rbn_neu.Location = new System.Drawing.Point(12, 51);
            this.rbn_neu.Name = "rbn_neu";
            this.rbn_neu.Size = new System.Drawing.Size(77, 17);
            this.rbn_neu.TabIndex = 4;
            this.rbn_neu.TabStop = true;
            this.rbn_neu.Text = "Neustarten";
            this.rbn_neu.UseVisualStyleBackColor = true;
            // 
            // rbn_abb
            // 
            this.rbn_abb.AutoSize = true;
            this.rbn_abb.Location = new System.Drawing.Point(12, 74);
            this.rbn_abb.Name = "rbn_abb";
            this.rbn_abb.Size = new System.Drawing.Size(77, 17);
            this.rbn_abb.TabIndex = 4;
            this.rbn_abb.Text = "Abbrechen";
            this.rbn_abb.UseVisualStyleBackColor = true;
            this.rbn_abb.CheckedChanged += new System.EventHandler(this.rbn_abb_CheckedChanged);
            // 
            // lbl_was
            // 
            this.lbl_was.AutoSize = true;
            this.lbl_was.Location = new System.Drawing.Point(12, 9);
            this.lbl_was.Name = "lbl_was";
            this.lbl_was.Size = new System.Drawing.Size(35, 13);
            this.lbl_was.TabIndex = 5;
            this.lbl_was.Text = "Was?";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_ab;
            this.ClientSize = new System.Drawing.Size(178, 186);
            this.Controls.Add(this.lbl_was);
            this.Controls.Add(this.rbn_abb);
            this.Controls.Add(this.rbn_neu);
            this.Controls.Add(this.rbn_her);
            this.Controls.Add(this.lbl_zeit);
            this.Controls.Add(this.nud_s);
            this.Controls.Add(this.nud_m);
            this.Controls.Add(this.nud_h);
            this.Controls.Add(this.btn_ab);
            this.Controls.Add(this.btn_ok);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(194, 224);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(194, 224);
            this.Name = "Form1";
            this.Text = "Herunterfahren";
            ((System.ComponentModel.ISupportInitialize)(this.nud_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_s)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_ab;
        private System.Windows.Forms.NumericUpDown nud_h;
        private System.Windows.Forms.Label lbl_zeit;
        private System.Windows.Forms.NumericUpDown nud_m;
        private System.Windows.Forms.NumericUpDown nud_s;
        private System.Windows.Forms.RadioButton rbn_her;
        private System.Windows.Forms.RadioButton rbn_neu;
        private System.Windows.Forms.RadioButton rbn_abb;
        private System.Windows.Forms.Label lbl_was;
    }
}

