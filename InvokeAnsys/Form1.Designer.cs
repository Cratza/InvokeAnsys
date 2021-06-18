namespace InvokeAnsys
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAnsysFile = new System.Windows.Forms.TextBox();
            this.textBoxAPDLFile = new System.Windows.Forms.TextBox();
            this.buttonAnsysFileChoose = new System.Windows.Forms.Button();
            this.buttonAPDLFileChoose = new System.Windows.Forms.Button();
            this.buttonExcuteAnsys = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJobName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOutputDic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonResultWorkDic = new System.Windows.Forms.Button();
            this.textBoxResultFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAnsysFile
            // 
            this.textBoxAnsysFile.Location = new System.Drawing.Point(156, 53);
            this.textBoxAnsysFile.Name = "textBoxAnsysFile";
            this.textBoxAnsysFile.Size = new System.Drawing.Size(541, 25);
            this.textBoxAnsysFile.TabIndex = 0;
            // 
            // textBoxAPDLFile
            // 
            this.textBoxAPDLFile.Location = new System.Drawing.Point(156, 101);
            this.textBoxAPDLFile.Name = "textBoxAPDLFile";
            this.textBoxAPDLFile.Size = new System.Drawing.Size(541, 25);
            this.textBoxAPDLFile.TabIndex = 0;
            // 
            // buttonAnsysFileChoose
            // 
            this.buttonAnsysFileChoose.Location = new System.Drawing.Point(763, 50);
            this.buttonAnsysFileChoose.Name = "buttonAnsysFileChoose";
            this.buttonAnsysFileChoose.Size = new System.Drawing.Size(75, 31);
            this.buttonAnsysFileChoose.TabIndex = 1;
            this.buttonAnsysFileChoose.Text = "浏览...";
            this.buttonAnsysFileChoose.UseVisualStyleBackColor = true;
            this.buttonAnsysFileChoose.Click += new System.EventHandler(this.buttonAnsysFileChoose_Click);
            // 
            // buttonAPDLFileChoose
            // 
            this.buttonAPDLFileChoose.Location = new System.Drawing.Point(763, 95);
            this.buttonAPDLFileChoose.Name = "buttonAPDLFileChoose";
            this.buttonAPDLFileChoose.Size = new System.Drawing.Size(75, 31);
            this.buttonAPDLFileChoose.TabIndex = 1;
            this.buttonAPDLFileChoose.Text = "浏览...";
            this.buttonAPDLFileChoose.UseVisualStyleBackColor = true;
            this.buttonAPDLFileChoose.Click += new System.EventHandler(this.buttonAPDLFileChoose_Click);
            // 
            // buttonExcuteAnsys
            // 
            this.buttonExcuteAnsys.Location = new System.Drawing.Point(76, 253);
            this.buttonExcuteAnsys.Name = "buttonExcuteAnsys";
            this.buttonExcuteAnsys.Size = new System.Drawing.Size(75, 31);
            this.buttonExcuteAnsys.TabIndex = 1;
            this.buttonExcuteAnsys.Text = "执行";
            this.buttonExcuteAnsys.UseVisualStyleBackColor = true;
            this.buttonExcuteAnsys.Click += new System.EventHandler(this.buttonExcuteAnsys_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ansys安装目录：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "APDL文件目录：";
            // 
            // textBoxJobName
            // 
            this.textBoxJobName.Location = new System.Drawing.Point(156, 147);
            this.textBoxJobName.Name = "textBoxJobName";
            this.textBoxJobName.Size = new System.Drawing.Size(145, 25);
            this.textBoxJobName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "工程名称：";
            // 
            // textBoxOutputDic
            // 
            this.textBoxOutputDic.Location = new System.Drawing.Point(156, 191);
            this.textBoxOutputDic.Name = "textBoxOutputDic";
            this.textBoxOutputDic.Size = new System.Drawing.Size(541, 25);
            this.textBoxOutputDic.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "输出文件目录：";
            // 
            // buttonResultWorkDic
            // 
            this.buttonResultWorkDic.Location = new System.Drawing.Point(763, 191);
            this.buttonResultWorkDic.Name = "buttonResultWorkDic";
            this.buttonResultWorkDic.Size = new System.Drawing.Size(75, 31);
            this.buttonResultWorkDic.TabIndex = 1;
            this.buttonResultWorkDic.Text = "浏览...";
            this.buttonResultWorkDic.UseVisualStyleBackColor = true;
            this.buttonResultWorkDic.Click += new System.EventHandler(this.buttonResultWorkDic_Click);
            // 
            // textBoxResultFile
            // 
            this.textBoxResultFile.Location = new System.Drawing.Point(549, 144);
            this.textBoxResultFile.Name = "textBoxResultFile";
            this.textBoxResultFile.Size = new System.Drawing.Size(145, 25);
            this.textBoxResultFile.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "结果文件名称：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 557);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExcuteAnsys);
            this.Controls.Add(this.buttonResultWorkDic);
            this.Controls.Add(this.buttonAPDLFileChoose);
            this.Controls.Add(this.buttonAnsysFileChoose);
            this.Controls.Add(this.textBoxResultFile);
            this.Controls.Add(this.textBoxOutputDic);
            this.Controls.Add(this.textBoxJobName);
            this.Controls.Add(this.textBoxAPDLFile);
            this.Controls.Add(this.textBoxAnsysFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAnsysFile;
        private System.Windows.Forms.TextBox textBoxAPDLFile;
        private System.Windows.Forms.Button buttonAnsysFileChoose;
        private System.Windows.Forms.Button buttonAPDLFileChoose;
        private System.Windows.Forms.Button buttonExcuteAnsys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxJobName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOutputDic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonResultWorkDic;
        private System.Windows.Forms.TextBox textBoxResultFile;
        private System.Windows.Forms.Label label5;
    }
}

