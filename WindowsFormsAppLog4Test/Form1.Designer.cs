namespace WindowsFormsAppLog4Test
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateLog = new System.Windows.Forms.Button();
            this.btnCreateExceptionLog = new System.Windows.Forms.Button();
            this.btnRedisTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateLog
            // 
            this.btnCreateLog.Location = new System.Drawing.Point(594, 167);
            this.btnCreateLog.Name = "btnCreateLog";
            this.btnCreateLog.Size = new System.Drawing.Size(108, 23);
            this.btnCreateLog.TabIndex = 0;
            this.btnCreateLog.Text = "创建日志";
            this.btnCreateLog.UseVisualStyleBackColor = true;
            this.btnCreateLog.Click += new System.EventHandler(this.btnCreateLog_Click);
            // 
            // btnCreateExceptionLog
            // 
            this.btnCreateExceptionLog.Location = new System.Drawing.Point(594, 210);
            this.btnCreateExceptionLog.Name = "btnCreateExceptionLog";
            this.btnCreateExceptionLog.Size = new System.Drawing.Size(108, 23);
            this.btnCreateExceptionLog.TabIndex = 1;
            this.btnCreateExceptionLog.Text = "创建异常日志";
            this.btnCreateExceptionLog.UseVisualStyleBackColor = true;
            this.btnCreateExceptionLog.Click += new System.EventHandler(this.btnCreateExceptionLog_Click);
            // 
            // btnRedisTest
            // 
            this.btnRedisTest.Location = new System.Drawing.Point(346, 214);
            this.btnRedisTest.Name = "btnRedisTest";
            this.btnRedisTest.Size = new System.Drawing.Size(108, 23);
            this.btnRedisTest.TabIndex = 2;
            this.btnRedisTest.Text = "Redis";
            this.btnRedisTest.UseVisualStyleBackColor = true;
            this.btnRedisTest.Click += new System.EventHandler(this.btnRedisTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRedisTest);
            this.Controls.Add(this.btnCreateExceptionLog);
            this.Controls.Add(this.btnCreateLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateLog;
        private System.Windows.Forms.Button btnCreateExceptionLog;
        private System.Windows.Forms.Button btnRedisTest;
    }
}

