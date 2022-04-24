
namespace CagriMerkezi
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnToplamCagri = new System.Windows.Forms.Button();
            this.lblToplamCagri = new System.Windows.Forms.Label();
            this.lvTopamCagri = new System.Windows.Forms.ListView();
            this.txtKelimeAra = new System.Windows.Forms.TextBox();
            this.btnKelimeAra = new System.Windows.Forms.Button();
            this.ltbKelimeAra = new System.Windows.Forms.ListBox();
            this.btnAramaYap = new System.Windows.Forms.Button();
            this.btnCagriAta = new System.Windows.Forms.Button();
            this.btnCagriyiBitir = new System.Windows.Forms.Button();
            this.btnOrnekVeri = new System.Windows.Forms.Button();
            this.lblislemTuru = new System.Windows.Forms.Label();
            this.lblNot = new System.Windows.Forms.Label();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.rbBireysel = new System.Windows.Forms.RadioButton();
            this.rbTicari = new System.Windows.Forms.RadioButton();
            this.lvCagri = new System.Windows.Forms.ListView();
            this.cmbTemsilci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnToplamCagri
            // 
            this.btnToplamCagri.Location = new System.Drawing.Point(394, 315);
            this.btnToplamCagri.Name = "btnToplamCagri";
            this.btnToplamCagri.Size = new System.Drawing.Size(109, 32);
            this.btnToplamCagri.TabIndex = 17;
            this.btnToplamCagri.Text = "Toplam Çağrı";
            this.btnToplamCagri.UseVisualStyleBackColor = true;
            this.btnToplamCagri.Click += new System.EventHandler(this.btnToplamCagri_Click);
            // 
            // lblToplamCagri
            // 
            this.lblToplamCagri.AutoSize = true;
            this.lblToplamCagri.Location = new System.Drawing.Point(509, 323);
            this.lblToplamCagri.Name = "lblToplamCagri";
            this.lblToplamCagri.Size = new System.Drawing.Size(0, 16);
            this.lblToplamCagri.TabIndex = 18;
            // 
            // lvTopamCagri
            // 
            this.lvTopamCagri.HideSelection = false;
            this.lvTopamCagri.Location = new System.Drawing.Point(369, 353);
            this.lvTopamCagri.Name = "lvTopamCagri";
            this.lvTopamCagri.Size = new System.Drawing.Size(279, 81);
            this.lvTopamCagri.TabIndex = 21;
            this.lvTopamCagri.UseCompatibleStateImageBehavior = false;
            this.lvTopamCagri.View = System.Windows.Forms.View.List;
            // 
            // txtKelimeAra
            // 
            this.txtKelimeAra.Location = new System.Drawing.Point(47, 328);
            this.txtKelimeAra.Multiline = true;
            this.txtKelimeAra.Name = "txtKelimeAra";
            this.txtKelimeAra.Size = new System.Drawing.Size(130, 32);
            this.txtKelimeAra.TabIndex = 5;
            // 
            // btnKelimeAra
            // 
            this.btnKelimeAra.Location = new System.Drawing.Point(180, 328);
            this.btnKelimeAra.Name = "btnKelimeAra";
            this.btnKelimeAra.Size = new System.Drawing.Size(130, 32);
            this.btnKelimeAra.TabIndex = 6;
            this.btnKelimeAra.Text = "Kelime Ara";
            this.btnKelimeAra.UseVisualStyleBackColor = true;
            this.btnKelimeAra.Click += new System.EventHandler(this.btnKelimeAra_Click);
            // 
            // ltbKelimeAra
            // 
            this.ltbKelimeAra.FormattingEnabled = true;
            this.ltbKelimeAra.ItemHeight = 16;
            this.ltbKelimeAra.Location = new System.Drawing.Point(47, 366);
            this.ltbKelimeAra.Name = "ltbKelimeAra";
            this.ltbKelimeAra.Size = new System.Drawing.Size(263, 68);
            this.ltbKelimeAra.TabIndex = 7;
            // 
            // btnAramaYap
            // 
            this.btnAramaYap.Location = new System.Drawing.Point(103, 246);
            this.btnAramaYap.Name = "btnAramaYap";
            this.btnAramaYap.Size = new System.Drawing.Size(109, 32);
            this.btnAramaYap.TabIndex = 0;
            this.btnAramaYap.Text = "Arama Yap";
            this.btnAramaYap.UseVisualStyleBackColor = true;
            this.btnAramaYap.Click += new System.EventHandler(this.btnAramaYap_Click);
            // 
            // btnCagriAta
            // 
            this.btnCagriAta.Location = new System.Drawing.Point(276, 246);
            this.btnCagriAta.Name = "btnCagriAta";
            this.btnCagriAta.Size = new System.Drawing.Size(109, 32);
            this.btnCagriAta.TabIndex = 1;
            this.btnCagriAta.Text = "Çağrı Ata";
            this.btnCagriAta.UseVisualStyleBackColor = true;
            this.btnCagriAta.Click += new System.EventHandler(this.btnCagriAta_Click);
            // 
            // btnCagriyiBitir
            // 
            this.btnCagriyiBitir.Location = new System.Drawing.Point(440, 246);
            this.btnCagriyiBitir.Name = "btnCagriyiBitir";
            this.btnCagriyiBitir.Size = new System.Drawing.Size(109, 32);
            this.btnCagriyiBitir.TabIndex = 2;
            this.btnCagriyiBitir.Text = "Çağrıyı Bitir";
            this.btnCagriyiBitir.UseVisualStyleBackColor = true;
            this.btnCagriyiBitir.Click += new System.EventHandler(this.btnCagriyiBitir_Click);
            // 
            // btnOrnekVeri
            // 
            this.btnOrnekVeri.Location = new System.Drawing.Point(108, 89);
            this.btnOrnekVeri.Name = "btnOrnekVeri";
            this.btnOrnekVeri.Size = new System.Drawing.Size(202, 29);
            this.btnOrnekVeri.TabIndex = 4;
            this.btnOrnekVeri.Text = "Örnek Verileri Yükle";
            this.btnOrnekVeri.UseVisualStyleBackColor = true;
            this.btnOrnekVeri.Click += new System.EventHandler(this.btnOrnekVeri_Click);
            // 
            // lblislemTuru
            // 
            this.lblislemTuru.AutoSize = true;
            this.lblislemTuru.Location = new System.Drawing.Point(81, 22);
            this.lblislemTuru.Name = "lblislemTuru";
            this.lblislemTuru.Size = new System.Drawing.Size(229, 16);
            this.lblislemTuru.TabIndex = 11;
            this.lblislemTuru.Text = "Lütfen İşlem yapacağınız Türü Seçiniz";
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Location = new System.Drawing.Point(404, 102);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(211, 16);
            this.lblNot.TabIndex = 12;
            this.lblNot.Text = "Alacağınız notları bu kısma yazınız.";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(392, 124);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(223, 116);
            this.txtNotlar.TabIndex = 13;
            // 
            // rbBireysel
            // 
            this.rbBireysel.AutoSize = true;
            this.rbBireysel.Location = new System.Drawing.Point(336, 22);
            this.rbBireysel.Name = "rbBireysel";
            this.rbBireysel.Size = new System.Drawing.Size(77, 20);
            this.rbBireysel.TabIndex = 14;
            this.rbBireysel.TabStop = true;
            this.rbBireysel.Text = "Bireysel";
            this.rbBireysel.UseVisualStyleBackColor = true;
            this.rbBireysel.CheckedChanged += new System.EventHandler(this.rbBireysel_CheckedChanged);
            // 
            // rbTicari
            // 
            this.rbTicari.AutoSize = true;
            this.rbTicari.Location = new System.Drawing.Point(429, 22);
            this.rbTicari.Name = "rbTicari";
            this.rbTicari.Size = new System.Drawing.Size(62, 20);
            this.rbTicari.TabIndex = 15;
            this.rbTicari.TabStop = true;
            this.rbTicari.Text = "Ticari";
            this.rbTicari.UseVisualStyleBackColor = true;
            this.rbTicari.CheckedChanged += new System.EventHandler(this.rbTicari_CheckedChanged);
            // 
            // lvCagri
            // 
            this.lvCagri.HideSelection = false;
            this.lvCagri.Location = new System.Drawing.Point(30, 124);
            this.lvCagri.Name = "lvCagri";
            this.lvCagri.Size = new System.Drawing.Size(341, 116);
            this.lvCagri.TabIndex = 16;
            this.lvCagri.UseCompatibleStateImageBehavior = false;
            this.lvCagri.View = System.Windows.Forms.View.List;
            // 
            // cmbTemsilci
            // 
            this.cmbTemsilci.FormattingEnabled = true;
            this.cmbTemsilci.Location = new System.Drawing.Point(358, 53);
            this.cmbTemsilci.Name = "cmbTemsilci";
            this.cmbTemsilci.Size = new System.Drawing.Size(121, 24);
            this.cmbTemsilci.TabIndex = 19;
            this.cmbTemsilci.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lütfen Müşteri Temsilcisnizi Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 502);
            this.Controls.Add(this.lvTopamCagri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTemsilci);
            this.Controls.Add(this.lblToplamCagri);
            this.Controls.Add(this.btnToplamCagri);
            this.Controls.Add(this.lvCagri);
            this.Controls.Add(this.rbTicari);
            this.Controls.Add(this.rbBireysel);
            this.Controls.Add(this.txtNotlar);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.lblislemTuru);
            this.Controls.Add(this.ltbKelimeAra);
            this.Controls.Add(this.btnKelimeAra);
            this.Controls.Add(this.txtKelimeAra);
            this.Controls.Add(this.btnOrnekVeri);
            this.Controls.Add(this.btnCagriyiBitir);
            this.Controls.Add(this.btnCagriAta);
            this.Controls.Add(this.btnAramaYap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnToplamCagri;
        private System.Windows.Forms.Label lblToplamCagri;
        private System.Windows.Forms.ListView lvTopamCagri;
        private System.Windows.Forms.TextBox txtKelimeAra;
        private System.Windows.Forms.Button btnKelimeAra;
        private System.Windows.Forms.ListBox ltbKelimeAra;
        private System.Windows.Forms.Button btnAramaYap;
        private System.Windows.Forms.Button btnCagriAta;
        private System.Windows.Forms.Button btnCagriyiBitir;
        private System.Windows.Forms.Button btnOrnekVeri;
        private System.Windows.Forms.Label lblislemTuru;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.RadioButton rbBireysel;
        private System.Windows.Forms.RadioButton rbTicari;
        private System.Windows.Forms.ListView lvCagri;
        private System.Windows.Forms.ComboBox cmbTemsilci;
        private System.Windows.Forms.Label label1;
    }
}

