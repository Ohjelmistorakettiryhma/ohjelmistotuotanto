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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtperapv = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEraantynyt = new System.Windows.Forms.RadioButton();
            this.rbMaksettu = new System.Windows.Forms.RadioButton();
            this.rbMaksamaton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lisaalasku)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lisää uusi lasku";
            // 
            // tblaskuid
            // 
            this.tblaskuid.Location = new System.Drawing.Point(99, 71);
            this.tblaskuid.Name = "tblaskuid";
            this.tblaskuid.Size = new System.Drawing.Size(175, 22);
            this.tblaskuid.TabIndex = 1;
            // 
            // tbvarausid
            // 
            this.tbvarausid.Location = new System.Drawing.Point(99, 124);
            this.tbvarausid.Name = "tbvarausid";
            this.tbvarausid.Size = new System.Drawing.Size(175, 22);
            this.tbvarausid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lasku ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Varaus ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Summa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "ALV";
            // 
            // lbSumma
            // 
            this.lbSumma.AutoSize = true;
            this.lbSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumma.Location = new System.Drawing.Point(95, 398);
            this.lbSumma.Name = "lbSumma";
            this.lbSumma.Size = new System.Drawing.Size(19, 20);
            this.lbSumma.TabIndex = 7;
            this.lbSumma.Text = "0";
            // 
            // lbALV
            // 
            this.lbALV.AutoSize = true;
            this.lbALV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbALV.Location = new System.Drawing.Point(95, 450);
            this.lbALV.Name = "lbALV";
            this.lbALV.Size = new System.Drawing.Size(19, 20);
            this.lbALV.TabIndex = 8;
            this.lbALV.Text = "0";
            // 
            // dataGridView_lisaalasku
            // 
            this.dataGridView_lisaalasku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lisaalasku.Location = new System.Drawing.Point(414, 124);
            this.dataGridView_lisaalasku.Name = "dataGridView_lisaalasku";
            this.dataGridView_lisaalasku.RowHeadersWidth = 51;
            this.dataGridView_lisaalasku.RowTemplate.Height = 24;
            this.dataGridView_lisaalasku.Size = new System.Drawing.Size(421, 361);
            this.dataGridView_lisaalasku.TabIndex = 9;
            // 
            // btnNaytaKaikki
            // 
            this.btnNaytaKaikki.Location = new System.Drawing.Point(667, 45);
            this.btnNaytaKaikki.Name = "btnNaytaKaikki";
            this.btnNaytaKaikki.Size = new System.Drawing.Size(168, 48);
            this.btnNaytaKaikki.TabIndex = 10;
            this.btnNaytaKaikki.Text = "Näytä kaikki laskut";
            this.btnNaytaKaikki.UseVisualStyleBackColor = true;
            this.btnNaytaKaikki.Click += new System.EventHandler(this.btnNaytaKaikki_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Lisää";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tila";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Eräpäivä";
            // 
            // dtperapv
            // 
            this.dtperapv.Location = new System.Drawing.Point(99, 339);
            this.dtperapv.Name = "dtperapv";
            this.dtperapv.Size = new System.Drawing.Size(175, 22);
            this.dtperapv.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtperapv);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnNaytaKaikki);
            this.panel1.Controls.Add(this.dataGridView_lisaalasku);
            this.panel1.Controls.Add(this.lbALV);
            this.panel1.Controls.Add(this.lbSumma);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbvarausid);
            this.panel1.Controls.Add(this.tblaskuid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 565);
            this.panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEraantynyt);
            this.groupBox1.Controls.Add(this.rbMaksettu);
            this.groupBox1.Controls.Add(this.rbMaksamaton);
            this.groupBox1.Location = new System.Drawing.Point(99, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 144);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // rbEraantynyt
            // 
            this.rbEraantynyt.AutoSize = true;
            this.rbEraantynyt.Location = new System.Drawing.Point(14, 120);
            this.rbEraantynyt.Name = "rbEraantynyt";
            this.rbEraantynyt.Size = new System.Drawing.Size(108, 20);
            this.rbEraantynyt.TabIndex = 2;
            this.rbEraantynyt.TabStop = true;
            this.rbEraantynyt.Text = "2 (erääntynyt)";
            this.rbEraantynyt.UseVisualStyleBackColor = true;
            // 
            // rbMaksettu
            // 
            this.rbMaksettu.AutoSize = true;
            this.rbMaksettu.Location = new System.Drawing.Point(14, 69);
            this.rbMaksettu.Name = "rbMaksettu";
            this.rbMaksettu.Size = new System.Drawing.Size(100, 20);
            this.rbMaksettu.TabIndex = 1;
            this.rbMaksettu.TabStop = true;
            this.rbMaksettu.Text = "1 (maksettu)";
            this.rbMaksettu.UseVisualStyleBackColor = true;
            // 
            // rbMaksamaton
            // 
            this.rbMaksamaton.AutoSize = true;
            this.rbMaksamaton.Location = new System.Drawing.Point(17, 21);
            this.rbMaksamaton.Name = "rbMaksamaton";
            this.rbMaksamaton.Size = new System.Drawing.Size(124, 20);
            this.rbMaksamaton.TabIndex = 0;
            this.rbMaksamaton.TabStop = true;
            this.rbMaksamaton.Text = "0 (maksamaton)";
            this.rbMaksamaton.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Laskutus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lisaalasku)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtperapv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEraantynyt;
        private System.Windows.Forms.RadioButton rbMaksettu;
        private System.Windows.Forms.RadioButton rbMaksamaton;
    }
}