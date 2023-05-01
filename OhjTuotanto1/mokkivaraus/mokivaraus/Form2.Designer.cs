namespace mokivaraus
{
    partial class Form2
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
            this.lbmokkinimi = new System.Windows.Forms.Label();
            this.lbkatuosoite = new System.Windows.Forms.Label();
            this.lbhinta = new System.Windows.Forms.Label();
            this.lbkuvaus = new System.Windows.Forms.Label();
            this.lbhenkilomaara = new System.Windows.Forms.Label();
            this.lbvvarustelu = new System.Windows.Forms.Label();
            this.cblemmikit = new System.Windows.Forms.CheckBox();
            this.cbtupakointi = new System.Windows.Forms.CheckBox();
            this.cbvarustelu = new System.Windows.Forms.ComboBox();
            this.tbmokkiid_mokki = new System.Windows.Forms.TextBox();
            this.tbalueid_mokki = new System.Windows.Forms.TextBox();
            this.tbpostinumero_mokki = new System.Windows.Forms.TextBox();
            this.tbmokkinimi_mokki = new System.Windows.Forms.TextBox();
            this.tbkatuosoite_mokki = new System.Windows.Forms.TextBox();
            this.tbhinta_mokki = new System.Windows.Forms.TextBox();
            this.btallenna = new System.Windows.Forms.Button();
            this.Listboxvarustelu = new System.Windows.Forms.ListBox();
            this.lbmokki_id = new System.Windows.Forms.Label();
            this.lbalue_id = new System.Windows.Forms.Label();
            this.lbpostinro = new System.Windows.Forms.Label();
            this.tbhenkilomaara_mokki = new System.Windows.Forms.TextBox();
            this.tbkuvaus_mokki = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lisää mökki";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbmokkinimi
            // 
            this.lbmokkinimi.AutoSize = true;
            this.lbmokkinimi.Location = new System.Drawing.Point(37, 142);
            this.lbmokkinimi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmokkinimi.Name = "lbmokkinimi";
            this.lbmokkinimi.Size = new System.Drawing.Size(60, 13);
            this.lbmokkinimi.TabIndex = 1;
            this.lbmokkinimi.Text = "Mokin nimi:";
            this.lbmokkinimi.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbkatuosoite
            // 
            this.lbkatuosoite.AutoSize = true;
            this.lbkatuosoite.Location = new System.Drawing.Point(37, 168);
            this.lbkatuosoite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbkatuosoite.Name = "lbkatuosoite";
            this.lbkatuosoite.Size = new System.Drawing.Size(60, 13);
            this.lbkatuosoite.TabIndex = 2;
            this.lbkatuosoite.Text = "Katuosoite:";
            this.lbkatuosoite.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbhinta
            // 
            this.lbhinta.AutoSize = true;
            this.lbhinta.Location = new System.Drawing.Point(37, 199);
            this.lbhinta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbhinta.Name = "lbhinta";
            this.lbhinta.Size = new System.Drawing.Size(35, 13);
            this.lbhinta.TabIndex = 3;
            this.lbhinta.Text = "Hinta:";
            this.lbhinta.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbkuvaus
            // 
            this.lbkuvaus.AutoSize = true;
            this.lbkuvaus.Location = new System.Drawing.Point(37, 266);
            this.lbkuvaus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbkuvaus.Name = "lbkuvaus";
            this.lbkuvaus.Size = new System.Drawing.Size(46, 13);
            this.lbkuvaus.TabIndex = 4;
            this.lbkuvaus.Text = "Kuvaus:";
            this.lbkuvaus.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbhenkilomaara
            // 
            this.lbhenkilomaara.AutoSize = true;
            this.lbhenkilomaara.Location = new System.Drawing.Point(37, 230);
            this.lbhenkilomaara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbhenkilomaara.Name = "lbhenkilomaara";
            this.lbhenkilomaara.Size = new System.Drawing.Size(75, 13);
            this.lbhenkilomaara.TabIndex = 5;
            this.lbhenkilomaara.Text = "Henkilömäärä:";
            this.lbhenkilomaara.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbvvarustelu
            // 
            this.lbvvarustelu.AutoSize = true;
            this.lbvvarustelu.Location = new System.Drawing.Point(315, 42);
            this.lbvvarustelu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbvvarustelu.Name = "lbvvarustelu";
            this.lbvvarustelu.Size = new System.Drawing.Size(54, 13);
            this.lbvvarustelu.TabIndex = 7;
            this.lbvvarustelu.Text = "Varustelu:";
            // 
            // cblemmikit
            // 
            this.cblemmikit.AutoSize = true;
            this.cblemmikit.Location = new System.Drawing.Point(308, 158);
            this.cblemmikit.Margin = new System.Windows.Forms.Padding(2);
            this.cblemmikit.Name = "cblemmikit";
            this.cblemmikit.Size = new System.Drawing.Size(99, 17);
            this.cblemmikit.TabIndex = 11;
            this.cblemmikit.Text = "Lemmikit sallittu";
            this.cblemmikit.UseVisualStyleBackColor = true;
            // 
            // cbtupakointi
            // 
            this.cbtupakointi.AutoSize = true;
            this.cbtupakointi.Location = new System.Drawing.Point(308, 192);
            this.cbtupakointi.Margin = new System.Windows.Forms.Padding(2);
            this.cbtupakointi.Name = "cbtupakointi";
            this.cbtupakointi.Size = new System.Drawing.Size(108, 17);
            this.cbtupakointi.TabIndex = 12;
            this.cbtupakointi.Text = "Tupakointi sallittu";
            this.cbtupakointi.UseVisualStyleBackColor = true;
            // 
            // cbvarustelu
            // 
            this.cbvarustelu.FormattingEnabled = true;
            this.cbvarustelu.Items.AddRange(new object[] {
            "Takka",
            "Palju",
            "Uimaranta",
            "Grilli",
            "Syöttötuoli",
            "Parveke",
            "Sauna",
            "Tiskikone",
            "Pyykinpesukone",
            "Laituri"});
            this.cbvarustelu.Location = new System.Drawing.Point(369, 36);
            this.cbvarustelu.Margin = new System.Windows.Forms.Padding(2);
            this.cbvarustelu.Name = "cbvarustelu";
            this.cbvarustelu.Size = new System.Drawing.Size(92, 21);
            this.cbvarustelu.TabIndex = 13;
            // 
            // tbmokkiid_mokki
            // 
            this.tbmokkiid_mokki.Location = new System.Drawing.Point(145, 53);
            this.tbmokkiid_mokki.Margin = new System.Windows.Forms.Padding(2);
            this.tbmokkiid_mokki.Name = "tbmokkiid_mokki";
            this.tbmokkiid_mokki.Size = new System.Drawing.Size(129, 20);
            this.tbmokkiid_mokki.TabIndex = 14;
            // 
            // tbalueid_mokki
            // 
            this.tbalueid_mokki.Location = new System.Drawing.Point(145, 79);
            this.tbalueid_mokki.Margin = new System.Windows.Forms.Padding(2);
            this.tbalueid_mokki.Name = "tbalueid_mokki";
            this.tbalueid_mokki.Size = new System.Drawing.Size(129, 20);
            this.tbalueid_mokki.TabIndex = 15;
            // 
            // tbpostinumero_mokki
            // 
            this.tbpostinumero_mokki.Location = new System.Drawing.Point(145, 107);
            this.tbpostinumero_mokki.Margin = new System.Windows.Forms.Padding(2);
            this.tbpostinumero_mokki.Name = "tbpostinumero_mokki";
            this.tbpostinumero_mokki.Size = new System.Drawing.Size(129, 20);
            this.tbpostinumero_mokki.TabIndex = 16;
            // 
            // tbmokkinimi_mokki
            // 
            this.tbmokkinimi_mokki.Location = new System.Drawing.Point(145, 135);
            this.tbmokkinimi_mokki.Margin = new System.Windows.Forms.Padding(2);
            this.tbmokkinimi_mokki.Name = "tbmokkinimi_mokki";
            this.tbmokkinimi_mokki.Size = new System.Drawing.Size(129, 20);
            this.tbmokkinimi_mokki.TabIndex = 17;
            // 
            // tbkatuosoite_mokki
            // 
            this.tbkatuosoite_mokki.Location = new System.Drawing.Point(145, 161);
            this.tbkatuosoite_mokki.Margin = new System.Windows.Forms.Padding(2);
            this.tbkatuosoite_mokki.Name = "tbkatuosoite_mokki";
            this.tbkatuosoite_mokki.Size = new System.Drawing.Size(129, 20);
            this.tbkatuosoite_mokki.TabIndex = 18;
            // 
            // tbhinta_mokki
            // 
            this.tbhinta_mokki.Location = new System.Drawing.Point(145, 192);
            this.tbhinta_mokki.Margin = new System.Windows.Forms.Padding(2);
            this.tbhinta_mokki.Name = "tbhinta_mokki";
            this.tbhinta_mokki.Size = new System.Drawing.Size(129, 20);
            this.tbhinta_mokki.TabIndex = 19;
            // 
            // btallenna
            // 
            this.btallenna.Location = new System.Drawing.Point(337, 279);
            this.btallenna.Margin = new System.Windows.Forms.Padding(2);
            this.btallenna.Name = "btallenna";
            this.btallenna.Size = new System.Drawing.Size(124, 43);
            this.btallenna.TabIndex = 20;
            this.btallenna.Text = "Tallenna";
            this.btallenna.UseVisualStyleBackColor = true;
            this.btallenna.Click += new System.EventHandler(this.button1_Click);
            // 
            // Listboxvarustelu
            // 
            this.Listboxvarustelu.FormattingEnabled = true;
            this.Listboxvarustelu.Location = new System.Drawing.Point(370, 60);
            this.Listboxvarustelu.Margin = new System.Windows.Forms.Padding(2);
            this.Listboxvarustelu.Name = "Listboxvarustelu";
            this.Listboxvarustelu.Size = new System.Drawing.Size(91, 95);
            this.Listboxvarustelu.TabIndex = 21;
            // 
            // lbmokki_id
            // 
            this.lbmokki_id.AutoSize = true;
            this.lbmokki_id.Location = new System.Drawing.Point(37, 60);
            this.lbmokki_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmokki_id.Name = "lbmokki_id";
            this.lbmokki_id.Size = new System.Drawing.Size(53, 13);
            this.lbmokki_id.TabIndex = 22;
            this.lbmokki_id.Text = "Mokki_id:";
            // 
            // lbalue_id
            // 
            this.lbalue_id.AutoSize = true;
            this.lbalue_id.Location = new System.Drawing.Point(37, 86);
            this.lbalue_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbalue_id.Name = "lbalue_id";
            this.lbalue_id.Size = new System.Drawing.Size(45, 13);
            this.lbalue_id.TabIndex = 23;
            this.lbalue_id.Text = "Alue_id:";
            // 
            // lbpostinro
            // 
            this.lbpostinro.AutoSize = true;
            this.lbpostinro.Location = new System.Drawing.Point(37, 114);
            this.lbpostinro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpostinro.Name = "lbpostinro";
            this.lbpostinro.Size = new System.Drawing.Size(68, 13);
            this.lbpostinro.TabIndex = 24;
            this.lbpostinro.Text = "Postinumero:";
            // 
            // tbhenkilomaara_mokki
            // 
            this.tbhenkilomaara_mokki.Location = new System.Drawing.Point(145, 223);
            this.tbhenkilomaara_mokki.Margin = new System.Windows.Forms.Padding(2);
            this.tbhenkilomaara_mokki.Name = "tbhenkilomaara_mokki";
            this.tbhenkilomaara_mokki.Size = new System.Drawing.Size(129, 20);
            this.tbhenkilomaara_mokki.TabIndex = 25;
            // 
            // tbkuvaus_mokki
            // 
            this.tbkuvaus_mokki.Location = new System.Drawing.Point(145, 259);
            this.tbkuvaus_mokki.Margin = new System.Windows.Forms.Padding(2);
            this.tbkuvaus_mokki.Name = "tbkuvaus_mokki";
            this.tbkuvaus_mokki.Size = new System.Drawing.Size(129, 20);
            this.tbkuvaus_mokki.TabIndex = 27;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 358);
            this.Controls.Add(this.tbkuvaus_mokki);
            this.Controls.Add(this.tbhenkilomaara_mokki);
            this.Controls.Add(this.lbpostinro);
            this.Controls.Add(this.lbalue_id);
            this.Controls.Add(this.lbmokki_id);
            this.Controls.Add(this.Listboxvarustelu);
            this.Controls.Add(this.btallenna);
            this.Controls.Add(this.tbhinta_mokki);
            this.Controls.Add(this.tbkatuosoite_mokki);
            this.Controls.Add(this.tbmokkinimi_mokki);
            this.Controls.Add(this.tbpostinumero_mokki);
            this.Controls.Add(this.tbalueid_mokki);
            this.Controls.Add(this.tbmokkiid_mokki);
            this.Controls.Add(this.cbvarustelu);
            this.Controls.Add(this.cbtupakointi);
            this.Controls.Add(this.cblemmikit);
            this.Controls.Add(this.lbvvarustelu);
            this.Controls.Add(this.lbhenkilomaara);
            this.Controls.Add(this.lbkuvaus);
            this.Controls.Add(this.lbhinta);
            this.Controls.Add(this.lbkatuosoite);
            this.Controls.Add(this.lbmokkinimi);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Mökin lisäys";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbmokkinimi;
        private System.Windows.Forms.Label lbkatuosoite;
        private System.Windows.Forms.Label lbhinta;
        private System.Windows.Forms.Label lbkuvaus;
        private System.Windows.Forms.Label lbhenkilomaara;
        private System.Windows.Forms.Label lbvvarustelu;
        private System.Windows.Forms.CheckBox cblemmikit;
        private System.Windows.Forms.CheckBox cbtupakointi;
        private System.Windows.Forms.ComboBox cbvarustelu;
        private System.Windows.Forms.TextBox tbmokkiid_mokki;
        private System.Windows.Forms.TextBox tbalueid_mokki;
        private System.Windows.Forms.TextBox tbpostinumero_mokki;
        private System.Windows.Forms.TextBox tbmokkinimi_mokki;
        private System.Windows.Forms.TextBox tbkatuosoite_mokki;
        private System.Windows.Forms.TextBox tbhinta_mokki;
        private System.Windows.Forms.Button btallenna;
        private System.Windows.Forms.ListBox Listboxvarustelu;
        private System.Windows.Forms.Label lbmokki_id;
        private System.Windows.Forms.Label lbalue_id;
        private System.Windows.Forms.Label lbpostinro;
        private System.Windows.Forms.TextBox tbhenkilomaara_mokki;
        private System.Windows.Forms.TextBox tbkuvaus_mokki;
    }
}