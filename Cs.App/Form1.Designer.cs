namespace Cs.App
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.gBYakinSaldiri = new System.Windows.Forms.GroupBox();
            this.btnSaldir = new System.Windows.Forms.Button();
            this.gbFirlatilan = new System.Windows.Forms.GroupBox();
            this.btnFirlat = new System.Windows.Forms.Button();
            this.panelSilah = new System.Windows.Forms.Panel();
            this.gb_AtesliSilah = new System.Windows.Forms.GroupBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnYenidenDoldur = new System.Windows.Forms.Button();
            this.btnAtesEt = new System.Windows.Forms.Button();
            this.cmbSilahlar = new System.Windows.Forms.ComboBox();
            this.lblDetay = new System.Windows.Forms.Label();
            this.gBYakinSaldiri.SuspendLayout();
            this.gbFirlatilan.SuspendLayout();
            this.gb_AtesliSilah.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silah Seçiniz";
            // 
            // gBYakinSaldiri
            // 
            this.gBYakinSaldiri.Controls.Add(this.btnSaldir);
            this.gBYakinSaldiri.Location = new System.Drawing.Point(28, 288);
            this.gBYakinSaldiri.Name = "gBYakinSaldiri";
            this.gBYakinSaldiri.Size = new System.Drawing.Size(320, 115);
            this.gBYakinSaldiri.TabIndex = 1;
            this.gBYakinSaldiri.TabStop = false;
            this.gBYakinSaldiri.Text = "Yakın Saldırı Kontrol";
            this.gBYakinSaldiri.Visible = false;
            // 
            // btnSaldir
            // 
            this.btnSaldir.Location = new System.Drawing.Point(32, 32);
            this.btnSaldir.Name = "btnSaldir";
            this.btnSaldir.Size = new System.Drawing.Size(75, 63);
            this.btnSaldir.TabIndex = 0;
            this.btnSaldir.Text = "Saldır";
            this.btnSaldir.UseVisualStyleBackColor = true;
            this.btnSaldir.Click += new System.EventHandler(this.btnSaldir_Click);
            // 
            // gbFirlatilan
            // 
            this.gbFirlatilan.Controls.Add(this.btnFirlat);
            this.gbFirlatilan.Location = new System.Drawing.Point(420, 288);
            this.gbFirlatilan.Name = "gbFirlatilan";
            this.gbFirlatilan.Size = new System.Drawing.Size(320, 115);
            this.gbFirlatilan.TabIndex = 1;
            this.gbFirlatilan.TabStop = false;
            this.gbFirlatilan.Text = "Fırlatılan Silah Kontrol";
            this.gbFirlatilan.Visible = false;
            // 
            // btnFirlat
            // 
            this.btnFirlat.Location = new System.Drawing.Point(30, 32);
            this.btnFirlat.Name = "btnFirlat";
            this.btnFirlat.Size = new System.Drawing.Size(75, 63);
            this.btnFirlat.TabIndex = 0;
            this.btnFirlat.Text = "Fırlat";
            this.btnFirlat.UseVisualStyleBackColor = true;
            this.btnFirlat.Click += new System.EventHandler(this.btnFirlat_Click);
            // 
            // panelSilah
            // 
            this.panelSilah.Location = new System.Drawing.Point(438, 24);
            this.panelSilah.Name = "panelSilah";
            this.panelSilah.Size = new System.Drawing.Size(264, 236);
            this.panelSilah.TabIndex = 2;
            // 
            // gb_AtesliSilah
            // 
            this.gb_AtesliSilah.Controls.Add(this.lblDurum);
            this.gb_AtesliSilah.Controls.Add(this.btnYenidenDoldur);
            this.gb_AtesliSilah.Controls.Add(this.btnAtesEt);
            this.gb_AtesliSilah.Location = new System.Drawing.Point(28, 168);
            this.gb_AtesliSilah.Name = "gb_AtesliSilah";
            this.gb_AtesliSilah.Size = new System.Drawing.Size(320, 92);
            this.gb_AtesliSilah.TabIndex = 1;
            this.gb_AtesliSilah.TabStop = false;
            this.gb_AtesliSilah.Text = "Silah Kontrol";
            this.gb_AtesliSilah.Visible = false;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.Teal;
            this.lblDurum.Location = new System.Drawing.Point(208, 45);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(52, 17);
            this.lblDurum.TabIndex = 4;
            this.lblDurum.Text = "label2";
            // 
            // btnYenidenDoldur
            // 
            this.btnYenidenDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenidenDoldur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnYenidenDoldur.Location = new System.Drawing.Point(96, 20);
            this.btnYenidenDoldur.Name = "btnYenidenDoldur";
            this.btnYenidenDoldur.Size = new System.Drawing.Size(76, 67);
            this.btnYenidenDoldur.TabIndex = 0;
            this.btnYenidenDoldur.Text = "Doldur";
            this.btnYenidenDoldur.UseVisualStyleBackColor = true;
            this.btnYenidenDoldur.Click += new System.EventHandler(this.btnYenidenDoldur_Click);
            // 
            // btnAtesEt
            // 
            this.btnAtesEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAtesEt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAtesEt.Location = new System.Drawing.Point(12, 19);
            this.btnAtesEt.Name = "btnAtesEt";
            this.btnAtesEt.Size = new System.Drawing.Size(76, 67);
            this.btnAtesEt.TabIndex = 0;
            this.btnAtesEt.Text = "Ateş Et";
            this.btnAtesEt.UseVisualStyleBackColor = true;
            this.btnAtesEt.Click += new System.EventHandler(this.btnAtesEt_Click);
            this.btnAtesEt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAtesEt_MouseDown);
            this.btnAtesEt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAtesEt_MouseUp);
            // 
            // cmbSilahlar
            // 
            this.cmbSilahlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSilahlar.FormattingEnabled = true;
            this.cmbSilahlar.Location = new System.Drawing.Point(124, 26);
            this.cmbSilahlar.Name = "cmbSilahlar";
            this.cmbSilahlar.Size = new System.Drawing.Size(223, 21);
            this.cmbSilahlar.TabIndex = 3;
            this.cmbSilahlar.SelectedIndexChanged += new System.EventHandler(this.cmbSilahlar_SelectedIndexChanged);
            // 
            // lblDetay
            // 
            this.lblDetay.AutoSize = true;
            this.lblDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetay.ForeColor = System.Drawing.Color.Teal;
            this.lblDetay.Location = new System.Drawing.Point(37, 91);
            this.lblDetay.Name = "lblDetay";
            this.lblDetay.Size = new System.Drawing.Size(52, 17);
            this.lblDetay.TabIndex = 4;
            this.lblDetay.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDetay);
            this.Controls.Add(this.cmbSilahlar);
            this.Controls.Add(this.panelSilah);
            this.Controls.Add(this.gbFirlatilan);
            this.Controls.Add(this.gb_AtesliSilah);
            this.Controls.Add(this.gBYakinSaldiri);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBYakinSaldiri.ResumeLayout(false);
            this.gbFirlatilan.ResumeLayout(false);
            this.gb_AtesliSilah.ResumeLayout(false);
            this.gb_AtesliSilah.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBYakinSaldiri;
        private System.Windows.Forms.Button btnSaldir;
        private System.Windows.Forms.GroupBox gbFirlatilan;
        private System.Windows.Forms.Button btnFirlat;
        private System.Windows.Forms.Panel panelSilah;
        private System.Windows.Forms.GroupBox gb_AtesliSilah;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnYenidenDoldur;
        private System.Windows.Forms.Button btnAtesEt;
        private System.Windows.Forms.ComboBox cmbSilahlar;
        private System.Windows.Forms.Label lblDetay;
    }
}

