namespace PassaParola
{
    partial class PassaParola
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
            this.button15 = new System.Windows.Forms.Button();
            this.rchtxtsoru = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linklbl = new System.Windows.Forms.LinkLabel();
            this.txtcevap = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblbos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblyanlis = new System.Windows.Forms.Label();
            this.lbldogru = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.Location = new System.Drawing.Point(77, 63);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(301, 208);
            this.button15.TabIndex = 30;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // rchtxtsoru
            // 
            this.rchtxtsoru.Enabled = false;
            this.rchtxtsoru.Location = new System.Drawing.Point(6, 30);
            this.rchtxtsoru.Name = "rchtxtsoru";
            this.rchtxtsoru.Size = new System.Drawing.Size(449, 98);
            this.rchtxtsoru.TabIndex = 31;
            this.rchtxtsoru.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rchtxtsoru);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(506, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 141);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SORU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linklbl);
            this.groupBox2.Controls.Add(this.txtcevap);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(506, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 103);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CEVAP";
            // 
            // linklbl
            // 
            this.linklbl.AutoSize = true;
            this.linklbl.LinkColor = System.Drawing.Color.White;
            this.linklbl.Location = new System.Drawing.Point(173, 67);
            this.linklbl.Name = "linklbl";
            this.linklbl.Size = new System.Drawing.Size(71, 25);
            this.linklbl.TabIndex = 0;
            this.linklbl.TabStop = true;
            this.linklbl.Text = "Başla";
            this.linklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            // 
            // txtcevap
            // 
            this.txtcevap.Enabled = false;
            this.txtcevap.Location = new System.Drawing.Point(6, 30);
            this.txtcevap.Name = "txtcevap";
            this.txtcevap.Size = new System.Drawing.Size(449, 31);
            this.txtcevap.TabIndex = 0;
            this.txtcevap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcevap_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblbos);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblyanlis);
            this.groupBox3.Controls.Add(this.lbldogru);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(506, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 81);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // lblbos
            // 
            this.lblbos.AutoSize = true;
            this.lblbos.ForeColor = System.Drawing.Color.White;
            this.lblbos.Location = new System.Drawing.Point(409, 31);
            this.lblbos.Name = "lblbos";
            this.lblbos.Size = new System.Drawing.Size(25, 25);
            this.lblbos.TabIndex = 5;
            this.lblbos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(330, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "BOŞ :";
            // 
            // lblyanlis
            // 
            this.lblyanlis.AutoSize = true;
            this.lblyanlis.ForeColor = System.Drawing.Color.White;
            this.lblyanlis.Location = new System.Drawing.Point(277, 31);
            this.lblyanlis.Name = "lblyanlis";
            this.lblyanlis.Size = new System.Drawing.Size(25, 25);
            this.lblyanlis.TabIndex = 3;
            this.lblyanlis.Text = "0";
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.ForeColor = System.Drawing.Color.White;
            this.lbldogru.Location = new System.Drawing.Point(121, 31);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(25, 25);
            this.lbldogru.TabIndex = 2;
            this.lbldogru.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "YANLIŞ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOĞRU :";
            // 
            // PassaParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(996, 399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button15);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassaParola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassaParola";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.RichTextBox rchtxtsoru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcevap;
        private System.Windows.Forms.LinkLabel linklbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblyanlis;
        private System.Windows.Forms.Label lbldogru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbos;
        private System.Windows.Forms.Label label3;
    }
}

