namespace BTRobot4EB
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.qr_create = new System.Windows.Forms.Button();
            this.groupBoxQR = new System.Windows.Forms.GroupBox();
            this.textBoxQR = new System.Windows.Forms.TextBox();
            this.groupBoxQR.SuspendLayout();
            this.SuspendLayout();
            // 
            // qr_create
            // 
            this.qr_create.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qr_create.Location = new System.Drawing.Point(51, 40);
            this.qr_create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qr_create.Name = "qr_create";
            this.qr_create.Size = new System.Drawing.Size(120, 48);
            this.qr_create.TabIndex = 0;
            this.qr_create.Text = "QR生成";
            this.qr_create.UseVisualStyleBackColor = true;
            // 
            // groupBoxQR
            // 
            this.groupBoxQR.Controls.Add(this.textBoxQR);
            this.groupBoxQR.Location = new System.Drawing.Point(231, 12);
            this.groupBoxQR.Name = "groupBoxQR";
            this.groupBoxQR.Size = new System.Drawing.Size(477, 456);
            this.groupBoxQR.TabIndex = 1;
            this.groupBoxQR.TabStop = false;
            this.groupBoxQR.Text = "QR生成设置";
            // 
            // textBoxQR
            // 
            this.textBoxQR.Location = new System.Drawing.Point(19, 28);
            this.textBoxQR.Multiline = true;
            this.textBoxQR.Name = "textBoxQR";
            this.textBoxQR.Size = new System.Drawing.Size(439, 68);
            this.textBoxQR.TabIndex = 0;
            this.textBoxQR.Text = "请输入文本...";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.groupBoxQR);
            this.Controls.Add(this.qr_create);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTRobot4EB";
            this.groupBoxQR.ResumeLayout(false);
            this.groupBoxQR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button qr_create;
        private System.Windows.Forms.GroupBox groupBoxQR;
        private System.Windows.Forms.TextBox textBoxQR;
    }
}

