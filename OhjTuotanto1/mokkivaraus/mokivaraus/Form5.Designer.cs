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
            this.button_muokkaa_nayta = new System.Windows.Forms.Button();
            this.btn_muokkaa_muokkaa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_tallenna_laskutus = new System.Windows.Forms.DataGridView();
            this.btn_tulosta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tallenna_laskutus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_tulosta);
            this.panel1.Controls.Add(this.button_muokkaa_nayta);
            this.panel1.Controls.Add(this.btn_muokkaa_muokkaa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView_tallenna_laskutus);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 500);
            this.panel1.TabIndex = 15;
            // 
            // button_muokkaa_nayta
            // 
            this.button_muokkaa_nayta.Location = new System.Drawing.Point(402, 33);
            this.button_muokkaa_nayta.Name = "button_muokkaa_nayta";
            this.button_muokkaa_nayta.Size = new System.Drawing.Size(197, 29);
            this.button_muokkaa_nayta.TabIndex = 12;
            this.button_muokkaa_nayta.Text = "Näytä olemassa olevat laskut";
            this.button_muokkaa_nayta.UseVisualStyleBackColor = true;
            this.button_muokkaa_nayta.Click += new System.EventHandler(this.button_muokkaa_nayta_Click);
            // 
            // btn_muokkaa_muokkaa
            // 
            this.btn_muokkaa_muokkaa.Location = new System.Drawing.Point(70, 368);
            this.btn_muokkaa_muokkaa.Name = "btn_muokkaa_muokkaa";
            this.btn_muokkaa_muokkaa.Size = new System.Drawing.Size(121, 36);
            this.btn_muokkaa_muokkaa.TabIndex = 11;
            this.btn_muokkaa_muokkaa.Text = "Tallenna";
            this.btn_muokkaa_muokkaa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tallenna PDF-lasku";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 294);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ALV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Summa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Varaus ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lasku ID";
            // 
            // dataGridView_tallenna_laskutus
            // 
            this.dataGridView_tallenna_laskutus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tallenna_laskutus.Location = new System.Drawing.Point(402, 77);
            this.dataGridView_tallenna_laskutus.Name = "dataGridView_tallenna_laskutus";
            this.dataGridView_tallenna_laskutus.RowHeadersWidth = 51;
            this.dataGridView_tallenna_laskutus.RowTemplate.Height = 24;
            this.dataGridView_tallenna_laskutus.Size = new System.Drawing.Size(430, 327);
            this.dataGridView_tallenna_laskutus.TabIndex = 0;
            // 
            // btn_tulosta
            // 
            this.btn_tulosta.Location = new System.Drawing.Point(219, 368);
            this.btn_tulosta.Name = "btn_tulosta";
            this.btn_tulosta.Size = new System.Drawing.Size(121, 36);
            this.btn_tulosta.TabIndex = 13;
            this.btn_tulosta.Text = "Tulosta";
            this.btn_tulosta.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 503);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Tallenna PDF-muotoon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tallenna_laskutus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_muokkaa_nayta;
        private System.Windows.Forms.Button btn_muokkaa_muokkaa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_tallenna_laskutus;
        private System.Windows.Forms.Button btn_tulosta;
    }
}