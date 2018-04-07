namespace LSB_BItmap
{
    partial class picImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(picImage));
            this.btnhiden = new System.Windows.Forms.Button();
            this.btndecrypt = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSteg = new System.Windows.Forms.Button();
            this.btnDetect = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhiden
            // 
            this.btnhiden.Location = new System.Drawing.Point(145, 337);
            this.btnhiden.Name = "btnhiden";
            this.btnhiden.Size = new System.Drawing.Size(75, 23);
            this.btnhiden.TabIndex = 2;
            this.btnhiden.Text = "Encypt";
            this.btnhiden.UseVisualStyleBackColor = true;
            this.btnhiden.Visible = false;
            this.btnhiden.Click += new System.EventHandler(this.btnhiden_Click);
            // 
            // btndecrypt
            // 
            this.btndecrypt.Location = new System.Drawing.Point(145, 337);
            this.btndecrypt.Name = "btndecrypt";
            this.btndecrypt.Size = new System.Drawing.Size(75, 23);
            this.btndecrypt.TabIndex = 3;
            this.btndecrypt.Text = "Decrypt";
            this.btndecrypt.UseVisualStyleBackColor = true;
            this.btndecrypt.Visible = false;
            this.btndecrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtText
            // 
            this.txtText.Enabled = false;
            this.txtText.Location = new System.Drawing.Point(81, 281);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(227, 20);
            this.txtText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(25, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "This app belongs to Tú Anh (N14DCAT054)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ACTION";
            // 
            // btnSteg
            // 
            this.btnSteg.Location = new System.Drawing.Point(301, 50);
            this.btnSteg.Name = "btnSteg";
            this.btnSteg.Size = new System.Drawing.Size(97, 33);
            this.btnSteg.TabIndex = 10;
            this.btnSteg.Text = "Steganography";
            this.btnSteg.UseVisualStyleBackColor = true;
            this.btnSteg.Click += new System.EventHandler(this.btnSteg_Click);
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(301, 101);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(97, 35);
            this.btnDetect.TabIndex = 11;
            this.btnDetect.Text = "Detect ";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(58, 123);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(196, 24);
            this.lblSelect.TabIndex = 12;
            this.lblSelect.Text = "Select your image!! ";
            this.lblSelect.Click += new System.EventHandler(this.lblSelect_Click);
            // 
            // picImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 381);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btndecrypt);
            this.Controls.Add(this.btnhiden);
            this.Controls.Add(this.btnSteg);
            this.Name = "picImage";
            this.Text = "Tú Anh App LSB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnhiden;
        private System.Windows.Forms.Button btndecrypt;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSteg;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Label lblSelect;
    }
}

