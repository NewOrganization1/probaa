namespace Aranzmani
{
    partial class NovAranzman
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.nDenovi = new System.Windows.Forms.NumericUpDown();
            this.nCena = new System.Windows.Forms.NumericUpDown();
            this.otkazi = new System.Windows.Forms.Button();
            this.dodadi = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nDenovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drzava";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vremetraenje(denovi)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cena po lice";
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(16, 30);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(283, 20);
            this.txtMesto.TabIndex = 4;
            this.txtMesto.Validating += new System.ComponentModel.CancelEventHandler(this.txtMesto_Validating);
            // 
            // txtDrzava
            // 
            this.txtDrzava.Location = new System.Drawing.Point(16, 69);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(283, 20);
            this.txtDrzava.TabIndex = 5;
            // 
            // nDenovi
            // 
            this.nDenovi.Location = new System.Drawing.Point(16, 123);
            this.nDenovi.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nDenovi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nDenovi.Name = "nDenovi";
            this.nDenovi.Size = new System.Drawing.Size(177, 20);
            this.nDenovi.TabIndex = 6;
            this.nDenovi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nCena
            // 
            this.nCena.Location = new System.Drawing.Point(16, 173);
            this.nCena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCena.Name = "nCena";
            this.nCena.Size = new System.Drawing.Size(177, 20);
            this.nCena.TabIndex = 7;
            this.nCena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // otkazi
            // 
            this.otkazi.CausesValidation = false;
            this.otkazi.Location = new System.Drawing.Point(16, 218);
            this.otkazi.Name = "otkazi";
            this.otkazi.Size = new System.Drawing.Size(111, 23);
            this.otkazi.TabIndex = 8;
            this.otkazi.Text = "Otkazi";
            this.otkazi.UseVisualStyleBackColor = true;
            this.otkazi.Click += new System.EventHandler(this.otkazi_Click);
            // 
            // dodadi
            // 
            this.dodadi.Location = new System.Drawing.Point(188, 218);
            this.dodadi.Name = "dodadi";
            this.dodadi.Size = new System.Drawing.Size(111, 23);
            this.dodadi.TabIndex = 9;
            this.dodadi.Text = "Dodadi";
            this.dodadi.UseVisualStyleBackColor = true;
            this.dodadi.Click += new System.EventHandler(this.dodadi_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NovAranzman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 288);
            this.Controls.Add(this.dodadi);
            this.Controls.Add(this.otkazi);
            this.Controls.Add(this.nCena);
            this.Controls.Add(this.nDenovi);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.txtMesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NovAranzman";
            this.Text = "NovAranzman";
            ((System.ComponentModel.ISupportInitialize)(this.nDenovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.NumericUpDown nDenovi;
        private System.Windows.Forms.NumericUpDown nCena;
        private System.Windows.Forms.Button otkazi;
        private System.Windows.Forms.Button dodadi;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}