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
            this.textBoxAIDir = new System.Windows.Forms.TextBox();
            this.buttonAIDir = new System.Windows.Forms.Button();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.checkBoxAI = new System.Windows.Forms.CheckBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.buttonDir = new System.Windows.Forms.Button();
            this.textBoxQR = new System.Windows.Forms.TextBox();
            this.groupBoxQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // qr_create
            // 
            this.qr_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qr_create.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qr_create.ForeColor = System.Drawing.SystemColors.ControlText;
            this.qr_create.Location = new System.Drawing.Point(51, 40);
            this.qr_create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qr_create.Name = "qr_create";
            this.qr_create.Size = new System.Drawing.Size(120, 48);
            this.qr_create.TabIndex = 0;
            this.qr_create.Text = "QR生成";
            this.qr_create.UseVisualStyleBackColor = true;
            this.qr_create.Click += new System.EventHandler(this.qr_create_Click);
            // 
            // groupBoxQR
            // 
            this.groupBoxQR.Controls.Add(this.textBoxAIDir);
            this.groupBoxQR.Controls.Add(this.buttonAIDir);
            this.groupBoxQR.Controls.Add(this.pictureBoxQR);
            this.groupBoxQR.Controls.Add(this.checkBoxAI);
            this.groupBoxQR.Controls.Add(this.buttonGenerate);
            this.groupBoxQR.Controls.Add(this.textBoxDir);
            this.groupBoxQR.Controls.Add(this.buttonDir);
            this.groupBoxQR.Controls.Add(this.textBoxQR);
            this.groupBoxQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxQR.Location = new System.Drawing.Point(231, 12);
            this.groupBoxQR.Name = "groupBoxQR";
            this.groupBoxQR.Size = new System.Drawing.Size(477, 456);
            this.groupBoxQR.TabIndex = 1;
            this.groupBoxQR.TabStop = false;
            this.groupBoxQR.Text = "QR生成设置";
            // 
            // textBoxAIDir
            // 
            this.textBoxAIDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAIDir.Enabled = false;
            this.textBoxAIDir.Location = new System.Drawing.Point(19, 415);
            this.textBoxAIDir.Name = "textBoxAIDir";
            this.textBoxAIDir.Size = new System.Drawing.Size(390, 23);
            this.textBoxAIDir.TabIndex = 6;
            this.textBoxAIDir.Text = "请设置 AI 安装路径";
            this.textBoxAIDir.Visible = false;
            // 
            // buttonAIDir
            // 
            this.buttonAIDir.Enabled = false;
            this.buttonAIDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAIDir.Location = new System.Drawing.Point(415, 415);
            this.buttonAIDir.Name = "buttonAIDir";
            this.buttonAIDir.Size = new System.Drawing.Size(42, 23);
            this.buttonAIDir.TabIndex = 5;
            this.buttonAIDir.Text = "...";
            this.buttonAIDir.UseVisualStyleBackColor = true;
            this.buttonAIDir.Visible = false;
            this.buttonAIDir.Click += new System.EventHandler(this.buttonAIDir_Click);
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Location = new System.Drawing.Point(120, 212);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxQR.TabIndex = 4;
            this.pictureBoxQR.TabStop = false;
            // 
            // checkBoxAI
            // 
            this.checkBoxAI.AutoSize = true;
            this.checkBoxAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAI.Location = new System.Drawing.Point(337, 212);
            this.checkBoxAI.Name = "checkBoxAI";
            this.checkBoxAI.Size = new System.Drawing.Size(128, 21);
            this.checkBoxAI.TabIndex = 3;
            this.checkBoxAI.Text = "保存后在 AI 中打开";
            this.checkBoxAI.UseVisualStyleBackColor = true;
            this.checkBoxAI.CheckedChanged += new System.EventHandler(this.checkBoxAI_CheckedChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonGenerate.Location = new System.Drawing.Point(337, 240);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(120, 48);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "生成并保存";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGe_Click);
            // 
            // textBoxDir
            // 
            this.textBoxDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDir.Location = new System.Drawing.Point(19, 111);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(390, 23);
            this.textBoxDir.TabIndex = 2;
            // 
            // buttonDir
            // 
            this.buttonDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDir.Location = new System.Drawing.Point(415, 111);
            this.buttonDir.Name = "buttonDir";
            this.buttonDir.Size = new System.Drawing.Size(42, 23);
            this.buttonDir.TabIndex = 1;
            this.buttonDir.Text = "...";
            this.buttonDir.UseVisualStyleBackColor = true;
            this.buttonDir.Click += new System.EventHandler(this.buttonDir_Click);
            // 
            // textBoxQR
            // 
            this.textBoxQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button qr_create;
        private System.Windows.Forms.GroupBox groupBoxQR;
        private System.Windows.Forms.TextBox textBoxQR;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Button buttonDir;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.CheckBox checkBoxAI;
        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.TextBox textBoxAIDir;
        private System.Windows.Forms.Button buttonAIDir;
    }
}

