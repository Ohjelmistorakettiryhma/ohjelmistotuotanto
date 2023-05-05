namespace mokivaraus
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_hae_pdf = new System.Windows.Forms.Button();
            this.button_muokkaa_nayta = new System.Windows.Forms.Button();
            this.btn_tallennapdf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbLasku_id_hae = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_tallenna_laskutus = new System.Windows.Forms.DataGridView();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_sahkoposti = new System.Windows.Forms.RadioButton();
            this.rbtn_Paperilasku = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tallenna_laskutus)).BeginInit();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_hae_pdf);
            this.panel1.Controls.Add(this.button_muokkaa_nayta);
            this.panel1.Controls.Add(this.btn_tallennapdf);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.tbLasku_id_hae);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView_tallenna_laskutus);
            this.panel1.Controls.Add(this.groupbox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 500);
            this.panel1.TabIndex = 15;
            // 
            // btn_hae_pdf
            // 
            this.btn_hae_pdf.Location = new System.Drawing.Point(508, 29);
            this.btn_hae_pdf.Name = "btn_hae_pdf";
            this.btn_hae_pdf.Size = new System.Drawing.Size(83, 29);
            this.btn_hae_pdf.TabIndex = 13;
            this.btn_hae_pdf.Text = "Hae";
            this.btn_hae_pdf.UseVisualStyleBackColor = true;
            // 
            // button_muokkaa_nayta
            // 
            this.button_muokkaa_nayta.Location = new System.Drawing.Point(635, 29);
            this.button_muokkaa_nayta.Name = "button_muokkaa_nayta";
            this.button_muokkaa_nayta.Size = new System.Drawing.Size(197, 29);
            this.button_muokkaa_nayta.TabIndex = 12;
            this.button_muokkaa_nayta.Text = "Näytä olemassa olevat laskut";
            this.button_muokkaa_nayta.UseVisualStyleBackColor = true;
            this.button_muokkaa_nayta.Click += new System.EventHandler(this.button_muokkaa_nayta_Click);
            // 
            // btn_tallennapdf
            // 
            this.btn_tallennapdf.Location = new System.Drawing.Point(674, 425);
            this.btn_tallennapdf.Name = "btn_tallennapdf";
            this.btn_tallennapdf.Size = new System.Drawing.Size(121, 36);
            this.btn_tallennapdf.TabIndex = 11;
            this.btn_tallennapdf.Text = "Tallenna";
            this.btn_tallennapdf.UseVisualStyleBackColor = true;
            this.btn_tallennapdf.Click += new System.EventHandler(this.btn_muokkaa_muokkaa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tallenna PDF-lasku";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(89, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 234);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 299);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 22);
            this.textBox2.TabIndex = 7;
            // 
            // tbLasku_id_hae
            // 
            this.tbLasku_id_hae.Location = new System.Drawing.Point(89, 117);
            this.tbLasku_id_hae.Name = "tbLasku_id_hae";
            this.tbLasku_id_hae.Size = new System.Drawing.Size(176, 22);
            this.tbLasku_id_hae.TabIndex = 6;
            this.tbLasku_id_hae.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbLasku_id_hae.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLasku_id_tallenna_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ALV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Summa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Varaus ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lasku ID";
            // 
            // dataGridView_tallenna_laskutus
            // 
            this.dataGridView_tallenna_laskutus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tallenna_laskutus.Location = new System.Drawing.Point(354, 95);
            this.dataGridView_tallenna_laskutus.Name = "dataGridView_tallenna_laskutus";
            this.dataGridView_tallenna_laskutus.RowHeadersWidth = 51;
            this.dataGridView_tallenna_laskutus.RowTemplate.Height = 24;
            this.dataGridView_tallenna_laskutus.Size = new System.Drawing.Size(478, 309);
            this.dataGridView_tallenna_laskutus.TabIndex = 0;
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.rbtn_sahkoposti);
            this.groupbox1.Controls.Add(this.rbtn_Paperilasku);
            this.groupbox1.Location = new System.Drawing.Point(288, 382);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(336, 79);
            this.groupbox1.TabIndex = 16;
            this.groupbox1.TabStop = false;
            // 
            // rbtn_sahkoposti
            // 
            this.rbtn_sahkoposti.AutoSize = true;
            this.rbtn_sahkoposti.Location = new System.Drawing.Point(20, 44);
            this.rbtn_sahkoposti.Name = "rbtn_sahkoposti";
            this.rbtn_sahkoposti.Size = new System.Drawing.Size(128, 20);
            this.rbtn_sahkoposti.TabIndex = 14;
            this.rbtn_sahkoposti.TabStop = true;
            this.rbtn_sahkoposti.Text = "Sähköpostilasku";
            this.rbtn_sahkoposti.UseVisualStyleBackColor = true;
            // 
            // rbtn_Paperilasku
            // 
            this.rbtn_Paperilasku.AutoSize = true;
            this.rbtn_Paperilasku.Location = new System.Drawing.Point(202, 44);
            this.rbtn_Paperilasku.Name = "rbtn_Paperilasku";
            this.rbtn_Paperilasku.Size = new System.Drawing.Size(100, 20);
            this.rbtn_Paperilasku.TabIndex = 15;
            this.rbtn_Paperilasku.TabStop = true;
            this.rbtn_Paperilasku.Text = "Paperilasku";
            this.rbtn_Paperilasku.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 503);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Lisää lasku";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tallenna_laskutus)).EndInit();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_muokkaa_nayta;
        private System.Windows.Forms.Button btn_tallennapdf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbLasku_id_hae;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_tallenna_laskutus;
        private System.Windows.Forms.Button btn_hae_pdf;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.RadioButton rbtn_sahkoposti;
        private System.Windows.Forms.RadioButton rbtn_Paperilasku;
    }
}