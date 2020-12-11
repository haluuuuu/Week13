namespace Week13
{
    partial class url_interface
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
            this.url_data = new System.Windows.Forms.Label();
            this.Inputdata = new System.Windows.Forms.TextBox();
            this.url_proses = new System.Windows.Forms.Button();
            this.labelUbah = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // url_data
            // 
            this.url_data.AutoSize = true;
            this.url_data.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.url_data.Location = new System.Drawing.Point(36, 29);
            this.url_data.Name = "url_data";
            this.url_data.Size = new System.Drawing.Size(89, 20);
            this.url_data.TabIndex = 0;
            this.url_data.Text = "Input Data:";
            this.url_data.UseWaitCursor = true;
            this.url_data.Click += new System.EventHandler(this.url_data_Click);
            // 
            // Inputdata
            // 
            this.Inputdata.Location = new System.Drawing.Point(40, 65);
            this.Inputdata.Name = "Inputdata";
            this.Inputdata.Size = new System.Drawing.Size(671, 26);
            this.Inputdata.TabIndex = 1;
            this.Inputdata.UseWaitCursor = true;
            this.Inputdata.TextChanged += new System.EventHandler(this.Inputdata_TextChanged);
            // 
            // url_proses
            // 
            this.url_proses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.url_proses.Location = new System.Drawing.Point(40, 109);
            this.url_proses.Name = "url_proses";
            this.url_proses.Size = new System.Drawing.Size(125, 35);
            this.url_proses.TabIndex = 2;
            this.url_proses.Text = "Proses";
            this.url_proses.UseVisualStyleBackColor = true;
            this.url_proses.UseWaitCursor = true;
            this.url_proses.Click += new System.EventHandler(this.url_proses_Click);
            // 
            // labelUbah
            // 
            this.labelUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUbah.Location = new System.Drawing.Point(32, 183);
            this.labelUbah.Name = "labelUbah";
            this.labelUbah.Size = new System.Drawing.Size(276, 77);
            this.labelUbah.TabIndex = 3;
            this.labelUbah.Text = "[EMPTY]";
            this.labelUbah.UseWaitCursor = true;
            this.labelUbah.Click += new System.EventHandler(this.ulr_isi_Click);
            // 
            // url_interface
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelUbah);
            this.Controls.Add(this.url_proses);
            this.Controls.Add(this.Inputdata);
            this.Controls.Add(this.url_data);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Name = "url_interface";
            this.Text = "Form Pengataturan Warna";
            this.TransparencyKey = System.Drawing.Color.SandyBrown;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.url_interface_Load);
            this.BackColorChanged += new System.EventHandler(this.url_interface_BackColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label url_data;
        private System.Windows.Forms.TextBox Inputdata;
        private System.Windows.Forms.Button url_proses;
        private System.Windows.Forms.Label labelUbah;
    }
}

