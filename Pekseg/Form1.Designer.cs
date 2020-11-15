namespace Pekseg
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
            this.tabControlStatisztikak = new System.Windows.Forms.TabControl();
            this.tabPageAdatok = new System.Windows.Forms.TabPage();
            this.groupBoxPeksegek = new System.Windows.Forms.GroupBox();
            this.textBoxPekseg = new System.Windows.Forms.TextBox();
            this.listBoxPekseg = new System.Windows.Forms.ListBox();
            this.buttonHozzaadPekaru2 = new System.Windows.Forms.Button();
            this.listBoxPekaru2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonHozzaadPekseg = new System.Windows.Forms.Button();
            this.groupBoxPekaruk = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHozzaadPekaru = new System.Windows.Forms.Button();
            this.listBoxPekaru = new System.Windows.Forms.ListBox();
            this.textBoxPekaru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxLaktoz = new System.Windows.Forms.CheckBox();
            this.numericUpDownPekaru = new System.Windows.Forms.NumericUpDown();
            this.tabPageStatisztikak = new System.Windows.Forms.TabPage();
            this.laktozlabel = new System.Windows.Forms.Label();
            this.avgAr = new System.Windows.Forms.Label();
            this.minTermek = new System.Windows.Forms.Label();
            this.maxTermek = new System.Windows.Forms.Label();
            this.pekaru = new System.Windows.Forms.Label();
            this.alapitva = new System.Windows.Forms.Label();
            this.listBoxStat = new System.Windows.Forms.ListBox();
            this.peksegNeve = new System.Windows.Forms.Label();
            this.tabControlStatisztikak.SuspendLayout();
            this.tabPageAdatok.SuspendLayout();
            this.groupBoxPeksegek.SuspendLayout();
            this.groupBoxPekaruk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPekaru)).BeginInit();
            this.tabPageStatisztikak.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStatisztikak
            // 
            this.tabControlStatisztikak.AccessibleName = "";
            this.tabControlStatisztikak.Controls.Add(this.tabPageAdatok);
            this.tabControlStatisztikak.Controls.Add(this.tabPageStatisztikak);
            this.tabControlStatisztikak.Location = new System.Drawing.Point(12, 12);
            this.tabControlStatisztikak.Name = "tabControlStatisztikak";
            this.tabControlStatisztikak.SelectedIndex = 0;
            this.tabControlStatisztikak.Size = new System.Drawing.Size(637, 426);
            this.tabControlStatisztikak.TabIndex = 0;
            this.tabControlStatisztikak.Click += new System.EventHandler(this.tabControlStatisztikak_Click);
            // 
            // tabPageAdatok
            // 
            this.tabPageAdatok.Controls.Add(this.groupBoxPeksegek);
            this.tabPageAdatok.Controls.Add(this.groupBoxPekaruk);
            this.tabPageAdatok.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdatok.Name = "tabPageAdatok";
            this.tabPageAdatok.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdatok.Size = new System.Drawing.Size(629, 400);
            this.tabPageAdatok.TabIndex = 0;
            this.tabPageAdatok.Text = "Adatok";
            this.tabPageAdatok.UseVisualStyleBackColor = true;
            this.tabPageAdatok.Click += new System.EventHandler(this.tabPageAdatok_Click);
            // 
            // groupBoxPeksegek
            // 
            this.groupBoxPeksegek.Controls.Add(this.textBoxPekseg);
            this.groupBoxPeksegek.Controls.Add(this.listBoxPekseg);
            this.groupBoxPeksegek.Controls.Add(this.buttonHozzaadPekaru2);
            this.groupBoxPeksegek.Controls.Add(this.listBoxPekaru2);
            this.groupBoxPeksegek.Controls.Add(this.label4);
            this.groupBoxPeksegek.Controls.Add(this.buttonHozzaadPekseg);
            this.groupBoxPeksegek.Location = new System.Drawing.Point(317, 6);
            this.groupBoxPeksegek.Name = "groupBoxPeksegek";
            this.groupBoxPeksegek.Size = new System.Drawing.Size(305, 388);
            this.groupBoxPeksegek.TabIndex = 9;
            this.groupBoxPeksegek.TabStop = false;
            this.groupBoxPeksegek.Text = "Pékségek";
            // 
            // textBoxPekseg
            // 
            this.textBoxPekseg.Location = new System.Drawing.Point(9, 32);
            this.textBoxPekseg.Name = "textBoxPekseg";
            this.textBoxPekseg.Size = new System.Drawing.Size(290, 20);
            this.textBoxPekseg.TabIndex = 11;
            // 
            // listBoxPekseg
            // 
            this.listBoxPekseg.FormattingEnabled = true;
            this.listBoxPekseg.Location = new System.Drawing.Point(6, 157);
            this.listBoxPekseg.Name = "listBoxPekseg";
            this.listBoxPekseg.Size = new System.Drawing.Size(195, 225);
            this.listBoxPekseg.TabIndex = 10;
            this.listBoxPekseg.SelectedIndexChanged += new System.EventHandler(this.listBoxPekseg_SelectedIndexChanged);
            // 
            // buttonHozzaadPekaru2
            // 
            this.buttonHozzaadPekaru2.Location = new System.Drawing.Point(6, 128);
            this.buttonHozzaadPekaru2.Name = "buttonHozzaadPekaru2";
            this.buttonHozzaadPekaru2.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaadPekaru2.TabIndex = 9;
            this.buttonHozzaadPekaru2.Text = "Hozzáad";
            this.buttonHozzaadPekaru2.UseVisualStyleBackColor = true;
            this.buttonHozzaadPekaru2.Click += new System.EventHandler(this.buttonHozzaadPekaru2_Click);
            // 
            // listBoxPekaru2
            // 
            this.listBoxPekaru2.FormattingEnabled = true;
            this.listBoxPekaru2.Location = new System.Drawing.Point(210, 157);
            this.listBoxPekaru2.Name = "listBoxPekaru2";
            this.listBoxPekaru2.Size = new System.Drawing.Size(89, 225);
            this.listBoxPekaru2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pékség neve";
            // 
            // buttonHozzaadPekseg
            // 
            this.buttonHozzaadPekseg.Location = new System.Drawing.Point(6, 58);
            this.buttonHozzaadPekseg.Name = "buttonHozzaadPekseg";
            this.buttonHozzaadPekseg.Size = new System.Drawing.Size(293, 23);
            this.buttonHozzaadPekseg.TabIndex = 7;
            this.buttonHozzaadPekseg.Text = "Létrehoz";
            this.buttonHozzaadPekseg.UseVisualStyleBackColor = true;
            this.buttonHozzaadPekseg.Click += new System.EventHandler(this.buttonHozzaadPekseg_Click);
            // 
            // groupBoxPekaruk
            // 
            this.groupBoxPekaruk.Controls.Add(this.label1);
            this.groupBoxPekaruk.Controls.Add(this.buttonHozzaadPekaru);
            this.groupBoxPekaruk.Controls.Add(this.listBoxPekaru);
            this.groupBoxPekaruk.Controls.Add(this.textBoxPekaru);
            this.groupBoxPekaruk.Controls.Add(this.label2);
            this.groupBoxPekaruk.Controls.Add(this.checkBoxLaktoz);
            this.groupBoxPekaruk.Controls.Add(this.numericUpDownPekaru);
            this.groupBoxPekaruk.Location = new System.Drawing.Point(6, 6);
            this.groupBoxPekaruk.Name = "groupBoxPekaruk";
            this.groupBoxPekaruk.Size = new System.Drawing.Size(305, 388);
            this.groupBoxPekaruk.TabIndex = 8;
            this.groupBoxPekaruk.TabStop = false;
            this.groupBoxPekaruk.Text = "Pékáruk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pékáru neve";
            // 
            // buttonHozzaadPekaru
            // 
            this.buttonHozzaadPekaru.Location = new System.Drawing.Point(6, 120);
            this.buttonHozzaadPekaru.Name = "buttonHozzaadPekaru";
            this.buttonHozzaadPekaru.Size = new System.Drawing.Size(293, 23);
            this.buttonHozzaadPekaru.TabIndex = 7;
            this.buttonHozzaadPekaru.Text = "Létrehoz";
            this.buttonHozzaadPekaru.UseVisualStyleBackColor = true;
            this.buttonHozzaadPekaru.Click += new System.EventHandler(this.buttonHozzaadPekaru_Click);
            // 
            // listBoxPekaru
            // 
            this.listBoxPekaru.FormattingEnabled = true;
            this.listBoxPekaru.Location = new System.Drawing.Point(6, 157);
            this.listBoxPekaru.Name = "listBoxPekaru";
            this.listBoxPekaru.Size = new System.Drawing.Size(293, 225);
            this.listBoxPekaru.TabIndex = 0;
            this.listBoxPekaru.SelectedIndexChanged += new System.EventHandler(this.listBoxPekaru_SelectedIndexChanged);
            // 
            // textBoxPekaru
            // 
            this.textBoxPekaru.Location = new System.Drawing.Point(6, 32);
            this.textBoxPekaru.Name = "textBoxPekaru";
            this.textBoxPekaru.Size = new System.Drawing.Size(293, 20);
            this.textBoxPekaru.TabIndex = 1;
            this.textBoxPekaru.TextChanged += new System.EventHandler(this.textBoxPekaru_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pékáru ára";
            // 
            // checkBoxLaktoz
            // 
            this.checkBoxLaktoz.AutoSize = true;
            this.checkBoxLaktoz.Location = new System.Drawing.Point(6, 97);
            this.checkBoxLaktoz.Name = "checkBoxLaktoz";
            this.checkBoxLaktoz.Size = new System.Drawing.Size(92, 17);
            this.checkBoxLaktoz.TabIndex = 2;
            this.checkBoxLaktoz.Text = "Laktózmentes";
            this.checkBoxLaktoz.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPekaru
            // 
            this.numericUpDownPekaru.Location = new System.Drawing.Point(6, 71);
            this.numericUpDownPekaru.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownPekaru.Name = "numericUpDownPekaru";
            this.numericUpDownPekaru.Size = new System.Drawing.Size(293, 20);
            this.numericUpDownPekaru.TabIndex = 3;
            this.numericUpDownPekaru.ValueChanged += new System.EventHandler(this.numericUpDownPekaru_ValueChanged);
            // 
            // tabPageStatisztikak
            // 
            this.tabPageStatisztikak.Controls.Add(this.peksegNeve);
            this.tabPageStatisztikak.Controls.Add(this.laktozlabel);
            this.tabPageStatisztikak.Controls.Add(this.avgAr);
            this.tabPageStatisztikak.Controls.Add(this.minTermek);
            this.tabPageStatisztikak.Controls.Add(this.maxTermek);
            this.tabPageStatisztikak.Controls.Add(this.pekaru);
            this.tabPageStatisztikak.Controls.Add(this.alapitva);
            this.tabPageStatisztikak.Controls.Add(this.listBoxStat);
            this.tabPageStatisztikak.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatisztikak.Name = "tabPageStatisztikak";
            this.tabPageStatisztikak.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatisztikak.Size = new System.Drawing.Size(629, 400);
            this.tabPageStatisztikak.TabIndex = 1;
            this.tabPageStatisztikak.Text = "Statisztikák";
            this.tabPageStatisztikak.UseVisualStyleBackColor = true;
            // 
            // laktozlabel
            // 
            this.laktozlabel.AutoSize = true;
            this.laktozlabel.Location = new System.Drawing.Point(229, 116);
            this.laktozlabel.Name = "laktozlabel";
            this.laktozlabel.Size = new System.Drawing.Size(123, 13);
            this.laktozlabel.TabIndex = 6;
            this.laktozlabel.Text = "Laktózmentes termékek:";
            // 
            // avgAr
            // 
            this.avgAr.AutoSize = true;
            this.avgAr.Location = new System.Drawing.Point(229, 103);
            this.avgAr.Name = "avgAr";
            this.avgAr.Size = new System.Drawing.Size(57, 13);
            this.avgAr.TabIndex = 5;
            this.avgAr.Text = "Átlagos ár:";
            // 
            // minTermek
            // 
            this.minTermek.AutoSize = true;
            this.minTermek.Location = new System.Drawing.Point(229, 77);
            this.minTermek.Name = "minTermek";
            this.minTermek.Size = new System.Drawing.Size(100, 13);
            this.minTermek.TabIndex = 4;
            this.minTermek.Text = "Legolcsóbb termék:";
            // 
            // maxTermek
            // 
            this.maxTermek.AutoSize = true;
            this.maxTermek.Location = new System.Drawing.Point(229, 90);
            this.maxTermek.Name = "maxTermek";
            this.maxTermek.Size = new System.Drawing.Size(102, 13);
            this.maxTermek.TabIndex = 3;
            this.maxTermek.Text = "Legdrágább termék:";
            // 
            // pekaru
            // 
            this.pekaru.AutoSize = true;
            this.pekaru.Location = new System.Drawing.Point(229, 64);
            this.pekaru.Name = "pekaru";
            this.pekaru.Size = new System.Drawing.Size(44, 13);
            this.pekaru.TabIndex = 2;
            this.pekaru.Text = "Pékáru:";
            // 
            // alapitva
            // 
            this.alapitva.AutoSize = true;
            this.alapitva.Location = new System.Drawing.Point(229, 51);
            this.alapitva.Name = "alapitva";
            this.alapitva.Size = new System.Drawing.Size(50, 13);
            this.alapitva.TabIndex = 1;
            this.alapitva.Text = "Alapítva:";
            // 
            // listBoxStat
            // 
            this.listBoxStat.FormattingEnabled = true;
            this.listBoxStat.Location = new System.Drawing.Point(6, 6);
            this.listBoxStat.Name = "listBoxStat";
            this.listBoxStat.Size = new System.Drawing.Size(202, 381);
            this.listBoxStat.TabIndex = 0;
            this.listBoxStat.SelectedIndexChanged += new System.EventHandler(this.listBoxStat_SelectedIndexChanged);
            // 
            // peksegNeve
            // 
            this.peksegNeve.AutoSize = true;
            this.peksegNeve.Location = new System.Drawing.Point(229, 23);
            this.peksegNeve.Name = "peksegNeve";
            this.peksegNeve.Size = new System.Drawing.Size(0, 13);
            this.peksegNeve.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.tabControlStatisztikak);
            this.Name = "Form1";
            this.Text = "Pekseg";
            this.tabControlStatisztikak.ResumeLayout(false);
            this.tabPageAdatok.ResumeLayout(false);
            this.groupBoxPeksegek.ResumeLayout(false);
            this.groupBoxPeksegek.PerformLayout();
            this.groupBoxPekaruk.ResumeLayout(false);
            this.groupBoxPekaruk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPekaru)).EndInit();
            this.tabPageStatisztikak.ResumeLayout(false);
            this.tabPageStatisztikak.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStatisztikak;
        private System.Windows.Forms.TabPage tabPageAdatok;
        private System.Windows.Forms.TabPage tabPageStatisztikak;
        private System.Windows.Forms.TextBox textBoxPekaru;
        private System.Windows.Forms.ListBox listBoxPekaru;
        private System.Windows.Forms.NumericUpDown numericUpDownPekaru;
        private System.Windows.Forms.CheckBox checkBoxLaktoz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHozzaadPekaru;
        private System.Windows.Forms.GroupBox groupBoxPekaruk;
        private System.Windows.Forms.GroupBox groupBoxPeksegek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonHozzaadPekseg;
        private System.Windows.Forms.ListBox listBoxPekseg;
        private System.Windows.Forms.Button buttonHozzaadPekaru2;
        private System.Windows.Forms.ListBox listBoxPekaru2;
        private System.Windows.Forms.Label laktozlabel;
        private System.Windows.Forms.Label avgAr;
        private System.Windows.Forms.Label minTermek;
        private System.Windows.Forms.Label maxTermek;
        private System.Windows.Forms.Label pekaru;
        private System.Windows.Forms.Label alapitva;
        private System.Windows.Forms.ListBox listBoxStat;
        private System.Windows.Forms.TextBox textBoxPekseg;
        private System.Windows.Forms.Label peksegNeve;
    }
}

