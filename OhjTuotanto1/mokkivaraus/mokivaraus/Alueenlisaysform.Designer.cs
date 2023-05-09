namespace mokivaraus
{
    partial class AlueenlisaysForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbalueid = new System.Windows.Forms.TextBox();
            this.tbalueennimi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alueen ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alueen nimi: ";
            // 
            // tbalueid
            // 
            this.tbalueid.Location = new System.Drawing.Point(144, 30);
            this.tbalueid.Name = "tbalueid";
            this.tbalueid.Size = new System.Drawing.Size(162, 20);
            this.tbalueid.TabIndex = 2;
            // 
            // tbalueennimi
            // 
            this.tbalueennimi.Location = new System.Drawing.Point(144, 77);
            this.tbalueennimi.Name = "tbalueennimi";
            this.tbalueennimi.Size = new System.Drawing.Size(162, 20);
            this.tbalueennimi.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tallenna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alueenlisaysform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbalueennimi);
            this.Controls.Add(this.tbalueid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alueenlisaysform";
            this.Text = "Uusi alue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbalueid;
        private System.Windows.Forms.TextBox tbalueennimi;
        private System.Windows.Forms.Button button1;
    }
}