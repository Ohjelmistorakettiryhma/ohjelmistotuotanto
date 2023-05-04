namespace mokivaraus
{
    partial class Form3
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
            this.dataGridView_muokkaa_laskutus = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLaskuid_Muokkaa = new System.Windows.Forms.TextBox();
            this.tbVarausid_muokkaa = new System.Windows.Forms.TextBox();
            this.tbsumma_muokkaa = new System.Windows.Forms.TextBox();
            this.tbalv_muokkaa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_muokkaa_muokkaa = new System.Windows.Forms.Button();
            this.button_muokkaa_nayta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_muokkaa_laskutus)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_muokkaa_laskutus
            // 
            this.dataGridView_muokkaa_laskutus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_muokkaa_laskutus.Location = new System.Drawing.Point(402, 77);
            this.dataGridView_muokkaa_laskutus.Name = "dataGridView_muokkaa_laskutus";
            this.dataGridView_muokkaa_laskutus.RowHeadersWidth = 51;
            this.dataGridView_muokkaa_laskutus.RowTemplate.Height = 24;
            this.dataGridView_muokkaa_laskutus.Size = new System.Drawing.Size(430, 327);
            this.dataGridView_muokkaa_laskutus.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Varaus ID";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ALV";
            // 
            // tbLaskuid_Muokkaa
            // 
            this.tbLaskuid_Muokkaa.Location = new System.Drawing.Point(131, 115);
            this.tbLaskuid_Muokkaa.Name = "tbLaskuid_Muokkaa";
            this.tbLaskuid_Muokkaa.Size = new System.Drawing.Size(176, 22);
            this.tbLaskuid_Muokkaa.TabIndex = 6;
            this.tbLaskuid_Muokkaa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLaskuid_Muokkaa_KeyPress);
            this.tbLaskuid_Muokkaa.Validating += new System.ComponentModel.CancelEventHandler(this.tbLaskuid_Muokkaa_Validating);
            // 
            // tbVarausid_muokkaa
            // 
            this.tbVarausid_muokkaa.Location = new System.Drawing.Point(131, 172);
            this.tbVarausid_muokkaa.Name = "tbVarausid_muokkaa";
            this.tbVarausid_muokkaa.Size = new System.Drawing.Size(176, 22);
            this.tbVarausid_muokkaa.TabIndex = 7;
            this.tbVarausid_muokkaa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVarausid_muokkaa_KeyPress);
            // 
            // tbsumma_muokkaa
            // 
            this.tbsumma_muokkaa.Location = new System.Drawing.Point(131, 233);
            this.tbsumma_muokkaa.Name = "tbsumma_muokkaa";
            this.tbsumma_muokkaa.Size = new System.Drawing.Size(176, 22);
            this.tbsumma_muokkaa.TabIndex = 8;
            this.tbsumma_muokkaa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsumma_muokkaa_KeyPress);
            // 
            // tbalv_muokkaa
            // 
            this.tbalv_muokkaa.Location = new System.Drawing.Point(131, 294);
            this.tbalv_muokkaa.Name = "tbalv_muokkaa";
            this.tbalv_muokkaa.Size = new System.Drawing.Size(176, 22);
            this.tbalv_muokkaa.TabIndex = 9;
            this.tbalv_muokkaa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbalv_muokkaa_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Muokkaa laskua";
            // 
            // btn_muokkaa_muokkaa
            // 
            this.btn_muokkaa_muokkaa.Location = new System.Drawing.Point(157, 368);
            this.btn_muokkaa_muokkaa.Name = "btn_muokkaa_muokkaa";
            this.btn_muokkaa_muokkaa.Size = new System.Drawing.Size(121, 36);
            this.btn_muokkaa_muokkaa.TabIndex = 11;
            this.btn_muokkaa_muokkaa.Text = "Muokkaa";
            this.btn_muokkaa_muokkaa.UseVisualStyleBackColor = true;
            this.btn_muokkaa_muokkaa.Click += new System.EventHandler(this.btn_muokkaa_muokkaa_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button_muokkaa_nayta);
            this.panel1.Controls.Add(this.btn_muokkaa_muokkaa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbalv_muokkaa);
            this.panel1.Controls.Add(this.tbsumma_muokkaa);
            this.panel1.Controls.Add(this.tbVarausid_muokkaa);
            this.panel1.Controls.Add(this.tbLaskuid_Muokkaa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView_muokkaa_laskutus);
            this.panel1.Location = new System.Drawing.Point(4, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 486);
            this.panel1.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Laskutus";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_muokkaa_laskutus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_muokkaa_laskutus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLaskuid_Muokkaa;
        private System.Windows.Forms.TextBox tbVarausid_muokkaa;
        private System.Windows.Forms.TextBox tbsumma_muokkaa;
        private System.Windows.Forms.TextBox tbalv_muokkaa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_muokkaa_muokkaa;
        private System.Windows.Forms.Button button_muokkaa_nayta;
        private System.Windows.Forms.Panel panel1;
    }
}