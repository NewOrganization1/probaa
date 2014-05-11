namespace Aranzmani
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
            this.lbAranzmani = new System.Windows.Forms.ListBox();
            this.btnPrazniA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDenovi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDrzava = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodadiA = new System.Windows.Forms.Button();
            this.btnBrisiA = new System.Windows.Forms.Button();
            this.btnNajdolg = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nDoplata = new System.Windows.Forms.NumericUpDown();
            this.nLica = new System.Windows.Forms.NumericUpDown();
            this.btnDodadiR = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbRezervacija = new System.Windows.Forms.ListBox();
            this.btnPrazniR = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbVklica = new System.Windows.Forms.TextBox();
            this.tbVkCena = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDoplata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista na aranzmani";
            // 
            // lbAranzmani
            // 
            this.lbAranzmani.FormattingEnabled = true;
            this.lbAranzmani.Location = new System.Drawing.Point(15, 29);
            this.lbAranzmani.Name = "lbAranzmani";
            this.lbAranzmani.Size = new System.Drawing.Size(215, 381);
            this.lbAranzmani.TabIndex = 1;
            this.lbAranzmani.SelectedIndexChanged += new System.EventHandler(this.lbAranzmani_SelectedIndexChanged);
            // 
            // btnPrazniA
            // 
            this.btnPrazniA.Location = new System.Drawing.Point(15, 417);
            this.btnPrazniA.Name = "btnPrazniA";
            this.btnPrazniA.Size = new System.Drawing.Size(215, 23);
            this.btnPrazniA.TabIndex = 2;
            this.btnPrazniA.Text = "Isprazni ja listata so aranzmani";
            this.btnPrazniA.UseVisualStyleBackColor = true;
            this.btnPrazniA.Click += new System.EventHandler(this.btnPrazniA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCena);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbDenovi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDrzava);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMesto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(236, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 195);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacii za aranzmanot";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(10, 158);
            this.tbCena.Name = "tbCena";
            this.tbCena.ReadOnly = true;
            this.tbCena.Size = new System.Drawing.Size(220, 20);
            this.tbCena.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cena po lice";
            // 
            // tbDenovi
            // 
            this.tbDenovi.Location = new System.Drawing.Point(10, 119);
            this.tbDenovi.Name = "tbDenovi";
            this.tbDenovi.ReadOnly = true;
            this.tbDenovi.Size = new System.Drawing.Size(220, 20);
            this.tbDenovi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vremetraenje(denovi)";
            // 
            // tbDrzava
            // 
            this.tbDrzava.Location = new System.Drawing.Point(10, 80);
            this.tbDrzava.Name = "tbDrzava";
            this.tbDrzava.ReadOnly = true;
            this.tbDrzava.Size = new System.Drawing.Size(220, 20);
            this.tbDrzava.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drzava";
            // 
            // tbMesto
            // 
            this.tbMesto.Location = new System.Drawing.Point(10, 37);
            this.tbMesto.Name = "tbMesto";
            this.tbMesto.ReadOnly = true;
            this.tbMesto.Size = new System.Drawing.Size(220, 20);
            this.tbMesto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mesto";
            // 
            // btnDodadiA
            // 
            this.btnDodadiA.Location = new System.Drawing.Point(236, 230);
            this.btnDodadiA.Name = "btnDodadiA";
            this.btnDodadiA.Size = new System.Drawing.Size(236, 23);
            this.btnDodadiA.TabIndex = 4;
            this.btnDodadiA.Text = "Dodadi nov aranzman";
            this.btnDodadiA.UseVisualStyleBackColor = true;
            this.btnDodadiA.Click += new System.EventHandler(this.btnDodadiA_Click);
            // 
            // btnBrisiA
            // 
            this.btnBrisiA.Location = new System.Drawing.Point(236, 259);
            this.btnBrisiA.Name = "btnBrisiA";
            this.btnBrisiA.Size = new System.Drawing.Size(236, 23);
            this.btnBrisiA.TabIndex = 5;
            this.btnBrisiA.Text = "Izbrisi aranzman";
            this.btnBrisiA.UseVisualStyleBackColor = true;
            this.btnBrisiA.Click += new System.EventHandler(this.btnBrisiA_Click);
            // 
            // btnNajdolg
            // 
            this.btnNajdolg.Location = new System.Drawing.Point(236, 288);
            this.btnNajdolg.Name = "btnNajdolg";
            this.btnNajdolg.Size = new System.Drawing.Size(236, 23);
            this.btnNajdolg.TabIndex = 6;
            this.btnNajdolg.Text = "Najdolg aranzman";
            this.btnNajdolg.UseVisualStyleBackColor = true;
            this.btnNajdolg.Click += new System.EventHandler(this.btnNajdolg_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nDoplata);
            this.groupBox2.Controls.Add(this.nLica);
            this.groupBox2.Controls.Add(this.btnDodadiR);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(237, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 129);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // nDoplata
            // 
            this.nDoplata.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nDoplata.Location = new System.Drawing.Point(6, 72);
            this.nDoplata.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nDoplata.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nDoplata.Name = "nDoplata";
            this.nDoplata.Size = new System.Drawing.Size(222, 20);
            this.nDoplata.TabIndex = 8;
            this.nDoplata.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // nLica
            // 
            this.nLica.Location = new System.Drawing.Point(6, 33);
            this.nLica.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nLica.Name = "nLica";
            this.nLica.Size = new System.Drawing.Size(222, 20);
            this.nLica.TabIndex = 7;
            this.nLica.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDodadiR
            // 
            this.btnDodadiR.Location = new System.Drawing.Point(6, 100);
            this.btnDodadiR.Name = "btnDodadiR";
            this.btnDodadiR.Size = new System.Drawing.Size(222, 23);
            this.btnDodadiR.TabIndex = 9;
            this.btnDodadiR.Text = "Dodadi rezervacija";
            this.btnDodadiR.UseVisualStyleBackColor = true;
            this.btnDodadiR.Click += new System.EventHandler(this.btnDodadiR_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Doplata za pat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lica:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Lista za rezervacija";
            // 
            // lbRezervacija
            // 
            this.lbRezervacija.FormattingEnabled = true;
            this.lbRezervacija.Location = new System.Drawing.Point(481, 31);
            this.lbRezervacija.Name = "lbRezervacija";
            this.lbRezervacija.Size = new System.Drawing.Size(261, 329);
            this.lbRezervacija.TabIndex = 10;
            // 
            // btnPrazniR
            // 
            this.btnPrazniR.Location = new System.Drawing.Point(481, 424);
            this.btnPrazniR.Name = "btnPrazniR";
            this.btnPrazniR.Size = new System.Drawing.Size(261, 23);
            this.btnPrazniR.TabIndex = 13;
            this.btnPrazniR.Text = "Isprazni ja listata so rezervacii";
            this.btnPrazniR.UseVisualStyleBackColor = true;
            this.btnPrazniR.Click += new System.EventHandler(this.btnPrazniR_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Vkupno lica:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Vkupno cena:";
            // 
            // tbVklica
            // 
            this.tbVklica.Location = new System.Drawing.Point(582, 371);
            this.tbVklica.Name = "tbVklica";
            this.tbVklica.ReadOnly = true;
            this.tbVklica.Size = new System.Drawing.Size(160, 20);
            this.tbVklica.TabIndex = 11;
            // 
            // tbVkCena
            // 
            this.tbVkCena.Location = new System.Drawing.Point(582, 394);
            this.tbVkCena.Name = "tbVkCena";
            this.tbVkCena.ReadOnly = true;
            this.tbVkCena.Size = new System.Drawing.Size(160, 20);
            this.tbVkCena.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 459);
            this.Controls.Add(this.tbVkCena);
            this.Controls.Add(this.tbVklica);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPrazniR);
            this.Controls.Add(this.lbRezervacija);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNajdolg);
            this.Controls.Add(this.btnBrisiA);
            this.Controls.Add(this.btnDodadiA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrazniA);
            this.Controls.Add(this.lbAranzmani);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDoplata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAranzmani;
        private System.Windows.Forms.Button btnPrazniA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDenovi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDrzava;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodadiA;
        private System.Windows.Forms.Button btnBrisiA;
        private System.Windows.Forms.Button btnNajdolg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nDoplata;
        private System.Windows.Forms.NumericUpDown nLica;
        private System.Windows.Forms.Button btnDodadiR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbRezervacija;
        private System.Windows.Forms.Button btnPrazniR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbVklica;
        private System.Windows.Forms.TextBox tbVkCena;
    }
}

