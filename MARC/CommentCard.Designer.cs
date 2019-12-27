namespace MARC
{
    partial class CommentCard
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
            this.pnl_left = new System.Windows.Forms.Panel();
            this.lbl_comment_owner = new System.Windows.Forms.Label();
            this.lbl_comment = new System.Windows.Forms.Label();
            this.pnl_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
            this.pnl_left.Controls.Add(this.lbl_comment_owner);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(218, 60);
            this.pnl_left.TabIndex = 2;
            // 
            // lbl_comment_owner
            // 
            this.lbl_comment_owner.AutoSize = true;
            this.lbl_comment_owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_comment_owner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_comment_owner.Location = new System.Drawing.Point(3, 17);
            this.lbl_comment_owner.Name = "lbl_comment_owner";
            this.lbl_comment_owner.Size = new System.Drawing.Size(167, 24);
            this.lbl_comment_owner.TabIndex = 0;
            this.lbl_comment_owner.Text = "Comment Owner";
            // 
            // lbl_comment
            // 
            this.lbl_comment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lbl_comment.Location = new System.Drawing.Point(218, 0);
            this.lbl_comment.Name = "lbl_comment";
            this.lbl_comment.Size = new System.Drawing.Size(422, 60);
            this.lbl_comment.TabIndex = 7;
            this.lbl_comment.Text = "Comment";
            // 
            // CommentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.lbl_comment);
            this.Controls.Add(this.pnl_left);
            this.Name = "CommentCard";
            this.Size = new System.Drawing.Size(640, 60);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Label lbl_comment_owner;
        private System.Windows.Forms.Label lbl_comment;
    }
}
