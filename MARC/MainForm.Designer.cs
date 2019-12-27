namespace MARC
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pic_box_underscore = new System.Windows.Forms.PictureBox();
            this.pic_box_close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            MainForm.pnl_container = new System.Windows.Forms.Panel();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_underscore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_close)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pnl_header.Controls.Add(this.pic_box_underscore);
            this.pnl_header.Controls.Add(this.pic_box_close);
            this.pnl_header.Controls.Add(this.panel1);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(900, 25);
            this.pnl_header.TabIndex = 0;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseMove);
            this.pnl_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseUp);
            // 
            // pic_box_underscore
            // 
            this.pic_box_underscore.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_box_underscore.Image = ((System.Drawing.Image)(resources.GetObject("pic_box_underscore.Image")));
            this.pic_box_underscore.Location = new System.Drawing.Point(850, 0);
            this.pic_box_underscore.Name = "pic_box_underscore";
            this.pic_box_underscore.Size = new System.Drawing.Size(25, 25);
            this.pic_box_underscore.TabIndex = 2;
            this.pic_box_underscore.TabStop = false;
            this.pic_box_underscore.Click += new System.EventHandler(this.pic_box_underscore_Click);
            // 
            // pic_box_close
            // 
            this.pic_box_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_box_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_box_close.Image")));
            this.pic_box_close.Location = new System.Drawing.Point(875, 0);
            this.pic_box_close.Name = "pic_box_close";
            this.pic_box_close.Size = new System.Drawing.Size(25, 25);
            this.pic_box_close.TabIndex = 1;
            this.pic_box_close.TabStop = false;
            this.pic_box_close.Click += new System.EventHandler(this.pic_box_close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 25);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
            this.label1.Location = new System.Drawing.Point(28, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MARC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_container
            // 
            MainForm.pnl_container.Dock = System.Windows.Forms.DockStyle.Bottom;
            MainForm.pnl_container.Location = new System.Drawing.Point(0, 31);
            MainForm.pnl_container.Name = "pnl_container";
            MainForm.pnl_container.Size = new System.Drawing.Size(900, 500);
            MainForm.pnl_container.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(900, 531);
            this.Controls.Add(MainForm.pnl_container);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_underscore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.PictureBox pic_box_underscore;
        private System.Windows.Forms.PictureBox pic_box_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private static System.Windows.Forms.Panel pnl_container;
    }
}

