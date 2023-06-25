namespace uji_nafa
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Left = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.btNilai = new System.Windows.Forms.Button();
            this.btMapel = new System.Windows.Forms.Button();
            this.btGuru = new System.Windows.Forms.Button();
            this.btSiswa = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.Panel();
            this.Top.SuspendLayout();
            this.Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Top.Controls.Add(this.label1);
            this.Top.Controls.Add(this.panel3);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(800, 89);
            this.Top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aplikasi Pendataan Siswa";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 82);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Left.Controls.Add(this.btLogout);
            this.Left.Controls.Add(this.btNilai);
            this.Left.Controls.Add(this.btMapel);
            this.Left.Controls.Add(this.btGuru);
            this.Left.Controls.Add(this.btSiswa);
            this.Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left.Location = new System.Drawing.Point(0, 89);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(148, 511);
            this.Left.TabIndex = 1;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.Location = new System.Drawing.Point(14, 220);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(122, 37);
            this.btLogout.TabIndex = 4;
            this.btLogout.Text = "Log Out";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btNilai
            // 
            this.btNilai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btNilai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNilai.Location = new System.Drawing.Point(14, 177);
            this.btNilai.Name = "btNilai";
            this.btNilai.Size = new System.Drawing.Size(122, 37);
            this.btNilai.TabIndex = 3;
            this.btNilai.Text = "Nilai";
            this.btNilai.UseVisualStyleBackColor = false;
            this.btNilai.Click += new System.EventHandler(this.btNilai_Click);
            // 
            // btMapel
            // 
            this.btMapel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btMapel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMapel.Location = new System.Drawing.Point(14, 134);
            this.btMapel.Name = "btMapel";
            this.btMapel.Size = new System.Drawing.Size(122, 37);
            this.btMapel.TabIndex = 2;
            this.btMapel.Text = "Mapel";
            this.btMapel.UseVisualStyleBackColor = false;
            this.btMapel.Click += new System.EventHandler(this.btMapel_Click);
            // 
            // btGuru
            // 
            this.btGuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btGuru.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuru.Location = new System.Drawing.Point(14, 91);
            this.btGuru.Name = "btGuru";
            this.btGuru.Size = new System.Drawing.Size(122, 37);
            this.btGuru.TabIndex = 1;
            this.btGuru.Text = "Guru";
            this.btGuru.UseVisualStyleBackColor = false;
            this.btGuru.Click += new System.EventHandler(this.btGuru_Click);
            // 
            // btSiswa
            // 
            this.btSiswa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btSiswa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSiswa.Location = new System.Drawing.Point(14, 48);
            this.btSiswa.Name = "btSiswa";
            this.btSiswa.Size = new System.Drawing.Size(122, 37);
            this.btSiswa.TabIndex = 0;
            this.btSiswa.Text = "Siswa";
            this.btSiswa.UseVisualStyleBackColor = false;
            this.btSiswa.Click += new System.EventHandler(this.btSiswa_Click);
            // 
            // Fill
            // 
            this.Fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fill.BackgroundImage")));
            this.Fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fill.Location = new System.Drawing.Point(148, 89);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(652, 511);
            this.Fill.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Top);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Top.ResumeLayout(false);
            this.Top.PerformLayout();
            this.Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel Left;
        private System.Windows.Forms.Panel Fill;
        private System.Windows.Forms.Button btMapel;
        private System.Windows.Forms.Button btGuru;
        private System.Windows.Forms.Button btSiswa;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btNilai;
        private System.Windows.Forms.Label label1;
    }
}