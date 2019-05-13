namespace MelikeYilmazOdev2
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
            this.groupBoxFakulte = new System.Windows.Forms.GroupBox();
            this.btnFakulteKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFakulte = new System.Windows.Forms.TextBox();
            this.listBoxFakulteler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxBolumler = new System.Windows.Forms.ListBox();
            this.groupBoxBolumEkle = new System.Windows.Forms.GroupBox();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBolum = new System.Windows.Forms.TextBox();
            this.groupBoxDersEkle = new System.Windows.Forms.GroupBox();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDers = new System.Windows.Forms.TextBox();
            this.listBoxDersler = new System.Windows.Forms.ListBox();
            this.groupBoxFakulte.SuspendLayout();
            this.groupBoxBolumEkle.SuspendLayout();
            this.groupBoxDersEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFakulte
            // 
            this.groupBoxFakulte.Controls.Add(this.btnFakulteKaydet);
            this.groupBoxFakulte.Controls.Add(this.label1);
            this.groupBoxFakulte.Controls.Add(this.textBoxFakulte);
            this.groupBoxFakulte.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFakulte.Name = "groupBoxFakulte";
            this.groupBoxFakulte.Size = new System.Drawing.Size(234, 176);
            this.groupBoxFakulte.TabIndex = 0;
            this.groupBoxFakulte.TabStop = false;
            this.groupBoxFakulte.Text = "Fakülte Ekle";
            // 
            // btnFakulteKaydet
            // 
            this.btnFakulteKaydet.Location = new System.Drawing.Point(150, 90);
            this.btnFakulteKaydet.Name = "btnFakulteKaydet";
            this.btnFakulteKaydet.Size = new System.Drawing.Size(67, 30);
            this.btnFakulteKaydet.TabIndex = 2;
            this.btnFakulteKaydet.Text = "Kaydet";
            this.btnFakulteKaydet.UseVisualStyleBackColor = true;
            this.btnFakulteKaydet.Click += new System.EventHandler(this.btnFakulteKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fakülte Adı";
            // 
            // textBoxFakulte
            // 
            this.textBoxFakulte.Location = new System.Drawing.Point(6, 58);
            this.textBoxFakulte.Name = "textBoxFakulte";
            this.textBoxFakulte.Size = new System.Drawing.Size(211, 26);
            this.textBoxFakulte.TabIndex = 0;
            // 
            // listBoxFakulteler
            // 
            this.listBoxFakulteler.FormattingEnabled = true;
            this.listBoxFakulteler.ItemHeight = 20;
            this.listBoxFakulteler.Location = new System.Drawing.Point(535, 12);
            this.listBoxFakulteler.Name = "listBoxFakulteler";
            this.listBoxFakulteler.Size = new System.Drawing.Size(165, 164);
            this.listBoxFakulteler.TabIndex = 1;
            this.listBoxFakulteler.SelectedIndexChanged += new System.EventHandler(this.listBoxFakulteler_SelectedIndexChanged);
            this.listBoxFakulteler.DoubleClick += new System.EventHandler(this.listBoxFakulteler_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(961, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fakülteler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(961, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bölümler";
            // 
            // listBoxBolumler
            // 
            this.listBoxBolumler.FormattingEnabled = true;
            this.listBoxBolumler.ItemHeight = 20;
            this.listBoxBolumler.Location = new System.Drawing.Point(706, 12);
            this.listBoxBolumler.Name = "listBoxBolumler";
            this.listBoxBolumler.Size = new System.Drawing.Size(165, 164);
            this.listBoxBolumler.TabIndex = 4;
            // 
            // groupBoxBolumEkle
            // 
            this.groupBoxBolumEkle.Controls.Add(this.btnBolumEkle);
            this.groupBoxBolumEkle.Controls.Add(this.label4);
            this.groupBoxBolumEkle.Controls.Add(this.textBoxBolum);
            this.groupBoxBolumEkle.Location = new System.Drawing.Point(252, 12);
            this.groupBoxBolumEkle.Name = "groupBoxBolumEkle";
            this.groupBoxBolumEkle.Size = new System.Drawing.Size(241, 176);
            this.groupBoxBolumEkle.TabIndex = 3;
            this.groupBoxBolumEkle.TabStop = false;
            this.groupBoxBolumEkle.Text = "Bölüm Ekle";
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.Location = new System.Drawing.Point(150, 90);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(85, 30);
            this.btnBolumEkle.TabIndex = 2;
            this.btnBolumEkle.Text = "Kaydet";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bölüm Adı";
            // 
            // textBoxBolum
            // 
            this.textBoxBolum.Location = new System.Drawing.Point(6, 58);
            this.textBoxBolum.Name = "textBoxBolum";
            this.textBoxBolum.Size = new System.Drawing.Size(229, 26);
            this.textBoxBolum.TabIndex = 0;
            // 
            // groupBoxDersEkle
            // 
            this.groupBoxDersEkle.Controls.Add(this.btnDersEkle);
            this.groupBoxDersEkle.Controls.Add(this.label5);
            this.groupBoxDersEkle.Controls.Add(this.textBoxDers);
            this.groupBoxDersEkle.Location = new System.Drawing.Point(5, 206);
            this.groupBoxDersEkle.Name = "groupBoxDersEkle";
            this.groupBoxDersEkle.Size = new System.Drawing.Size(241, 176);
            this.groupBoxDersEkle.TabIndex = 6;
            this.groupBoxDersEkle.TabStop = false;
            this.groupBoxDersEkle.Text = "Ders Ekle";
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(150, 90);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(85, 30);
            this.btnDersEkle.TabIndex = 2;
            this.btnDersEkle.Text = "Kaydet";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ders Adı";
            // 
            // textBoxDers
            // 
            this.textBoxDers.Location = new System.Drawing.Point(6, 58);
            this.textBoxDers.Name = "textBoxDers";
            this.textBoxDers.Size = new System.Drawing.Size(229, 26);
            this.textBoxDers.TabIndex = 0;
            // 
            // listBoxDersler
            // 
            this.listBoxDersler.FormattingEnabled = true;
            this.listBoxDersler.ItemHeight = 20;
            this.listBoxDersler.Location = new System.Drawing.Point(535, 206);
            this.listBoxDersler.Name = "listBoxDersler";
            this.listBoxDersler.Size = new System.Drawing.Size(165, 164);
            this.listBoxDersler.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 463);
            this.Controls.Add(this.listBoxDersler);
            this.Controls.Add(this.groupBoxDersEkle);
            this.Controls.Add(this.groupBoxBolumEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxBolumler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxFakulteler);
            this.Controls.Add(this.groupBoxFakulte);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxFakulte.ResumeLayout(false);
            this.groupBoxFakulte.PerformLayout();
            this.groupBoxBolumEkle.ResumeLayout(false);
            this.groupBoxBolumEkle.PerformLayout();
            this.groupBoxDersEkle.ResumeLayout(false);
            this.groupBoxDersEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFakulte;
        private System.Windows.Forms.Button btnFakulteKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFakulte;
        private System.Windows.Forms.ListBox listBoxFakulteler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxBolumler;
        private System.Windows.Forms.GroupBox groupBoxBolumEkle;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBolum;
        private System.Windows.Forms.GroupBox groupBoxDersEkle;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDers;
        private System.Windows.Forms.ListBox listBoxDersler;
    }
}

