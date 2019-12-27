namespace MARC
{
    partial class CourseCardView
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.flow_panel_container = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flow_panel_container
            // 
            this.flow_panel_container.AutoScroll = true;
            this.flow_panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_panel_container.Location = new System.Drawing.Point(0, 0);
            this.flow_panel_container.Name = "flow_panel_container";
            this.flow_panel_container.Size = new System.Drawing.Size(675, 447);
            this.flow_panel_container.TabIndex = 0;
            // 
            // CourseCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.flow_panel_container);
            this.Name = "CourseCardView";
            this.Size = new System.Drawing.Size(675, 447);
            this.Load += new System.EventHandler(this.CourseCardView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow_panel_container;
    }
}
