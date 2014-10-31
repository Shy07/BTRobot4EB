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
            this.buttonDir = new System.Windows.Forms.Button();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxAI = new System.Windows.Forms.CheckBox();
            this.groupBoxQR.SuspendLayout();
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
            // textBoxDir
            // 
            this.textBoxDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDir.Location = new System.Drawing.Point(19, 111);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(390, 23);
            this.textBoxDir.TabIndex = 2;
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(51, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "QR生成";
            this.button1.UseVisualStyleBackColor = true;
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
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Button buttonDir;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxAI;
    }
}

