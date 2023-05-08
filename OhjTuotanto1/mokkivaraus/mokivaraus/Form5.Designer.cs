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
            this.label1 = new System.Windows.Forms.Label();
            this.tblaskuid = new System.Windows.Forms.TextBox();
            this.tbvarausid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSumma = new System.Windows.Forms.Label();
            this.lbALV = new System.Windows.Forms.Label();
            this.dataGridView_lisaalasku = new System.Windows.Forms.DataGridView();
            this.btnNaytaKaikki = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lisaalasku)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lisää uusi lasku";
            // 
            // tblaskuid
            // 
            this.tblaskuid.Location = new System.Drawing.Point(104, 123);
            this.tblaskuid.Name = "tblaskuid";
            this.tblaskuid.Size = new System.Drawing.Size(175, 22);
            this.tblaskuid.TabIndex = 1;
            // 
            // tbvarausid
            // 
            this.tbvarausid.Location = new System.Drawing.Point(104, 184);
            this.tbvarausid.Name = "tbvarausid";
            this.tbvarausid.Size = new System.Drawing.Size(175, 22);
            this.tbvarausid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lasku ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Varaus ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Summa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "ALV";
            // 
            // lbSumma
            // 
            this.lbSumma.AutoSize = true;
            this.lbSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumma.Location = new System.Drawing.Point(100, 247);
            this.lbSumma.Name = "lbSumma";
            this.lbSumma.Size = new System.Drawing.Size(19, 20);
            this.lbSumma.TabIndex = 7;
            this.lbSumma.Text = "0";
            // 
            // lbALV
            // 
            this.lbALV.AutoSize = true;
            this.lbALV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbALV.Location = new System.Drawing.Point(100, 299);
            this.lbALV.Name = "lbALV";
            this.lbALV.Size = new System.Drawing.Size(19, 20);
            this.lbALV.TabIndex = 8;
            this.lbALV.Text = "0";
            // 
            // dataGridView_lisaalasku
            // 
            this.dataGridView_lisaalasku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lisaalasku.Location = new System.Drawing.Point(340, 121);
            this.dataGridView_lisaalasku.Name = "dataGridView_lisaalasku";
            this.dataGridView_lisaalasku.RowHeadersWidth = 51;
            this.dataGridView_lisaalasku.RowTemplate.Height = 24;
            this.dataGridView_lisaalasku.Size = new System.Drawing.Size(421, 274);
            this.dataGridView_lisaalasku.TabIndex = 9;
            // 
            // btnNaytaKaikki
            // 
            this.btnNaytaKaikki.Location = new System.Drawing.Point(593, 50);
            this.btnNaytaKaikki.Name = "btnNaytaKaikki";
            this.btnNaytaKaikki.Size = new System.Drawing.Size(168, 48);
            this.btnNaytaKaikki.TabIndex = 10;
            this.btnNaytaKaikki.Text = "Näytä kaikki laskut";
            this.btnNaytaKaikki.UseVisualStyleBackColor = true;
            this.btnNaytaKaikki.Click += new System.EventHandler(this.btnNaytaKaikki_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 48);
            this.button2.TabIndex = 11;
            this.button2.Text = "Lisää";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNaytaKaikki);
            this.Controls.Add(this.dataGridView_lisaalasku);
            this.Controls.Add(this.lbALV);
            this.Controls.Add(this.lbSumma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbvarausid);
            this.Controls.Add(this.tblaskuid);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Laskutus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lisaalasku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tblaskuid;
        private System.Windows.Forms.TextBox tbvarausid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSumma;
        private System.Windows.Forms.Label lbALV;
        private System.Windows.Forms.DataGridView dataGridView_lisaalasku;
        private System.Windows.Forms.Button btnNaytaKaikki;
        private System.Windows.Forms.Button button2;
    }
}