namespace Ffmpeg_With_Shell
{
    partial class Form_Main
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
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_AssConverter = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.groupBox_AssConverter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAssPath = new System.Windows.Forms.TextBox();
            this.button_AssPathSelector = new System.Windows.Forms.Button();
            this.textBox_MovFps = new System.Windows.Forms.TextBox();
            this.textBox_MovTime = new System.Windows.Forms.TextBox();
            this.button_MovPathSelector = new System.Windows.Forms.Button();
            this.textBox_MovPath = new System.Windows.Forms.TextBox();
            this.button_AssConvert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel1.SuspendLayout();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_AssConverter.SuspendLayout();
            this.groupBox_AssConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Main.Name = "splitContainer_Main";
            // 
            // splitContainer_Main.Panel1
            // 
            this.splitContainer_Main.Panel1.Controls.Add(this.tabControl_Main);
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.textBox_Output);
            this.splitContainer_Main.Size = new System.Drawing.Size(800, 450);
            this.splitContainer_Main.SplitterDistance = 347;
            this.splitContainer_Main.TabIndex = 0;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_AssConverter);
            this.tabControl_Main.Controls.Add(this.tabPage2);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(347, 450);
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_AssConverter
            // 
            this.tabPage_AssConverter.Controls.Add(this.button_AssConvert);
            this.tabPage_AssConverter.Controls.Add(this.groupBox_AssConverter);
            this.tabPage_AssConverter.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AssConverter.Name = "tabPage_AssConverter";
            this.tabPage_AssConverter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AssConverter.Size = new System.Drawing.Size(339, 424);
            this.tabPage_AssConverter.TabIndex = 0;
            this.tabPage_AssConverter.Text = "Ass字幕转换";
            this.tabPage_AssConverter.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_Output
            // 
            this.textBox_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Output.Location = new System.Drawing.Point(0, 0);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.Size = new System.Drawing.Size(449, 450);
            this.textBox_Output.TabIndex = 0;
            // 
            // groupBox_AssConverter
            // 
            this.groupBox_AssConverter.Controls.Add(this.button_MovPathSelector);
            this.groupBox_AssConverter.Controls.Add(this.textBox_MovPath);
            this.groupBox_AssConverter.Controls.Add(this.textBox_MovTime);
            this.groupBox_AssConverter.Controls.Add(this.textBox_MovFps);
            this.groupBox_AssConverter.Controls.Add(this.button_AssPathSelector);
            this.groupBox_AssConverter.Controls.Add(this.textBoxAssPath);
            this.groupBox_AssConverter.Controls.Add(this.label4);
            this.groupBox_AssConverter.Controls.Add(this.label3);
            this.groupBox_AssConverter.Controls.Add(this.label2);
            this.groupBox_AssConverter.Controls.Add(this.label1);
            this.groupBox_AssConverter.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_AssConverter.Location = new System.Drawing.Point(3, 3);
            this.groupBox_AssConverter.Name = "groupBox_AssConverter";
            this.groupBox_AssConverter.Size = new System.Drawing.Size(333, 212);
            this.groupBox_AssConverter.TabIndex = 0;
            this.groupBox_AssConverter.TabStop = false;
            this.groupBox_AssConverter.Text = "设置参数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ass文件路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "帧率（例：30）：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "时间（格式：时:分:秒.毫秒，例：00:03:25.000）：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "mov输出路径：";
            // 
            // textBoxAssPath
            // 
            this.textBoxAssPath.Location = new System.Drawing.Point(8, 32);
            this.textBoxAssPath.Name = "textBoxAssPath";
            this.textBoxAssPath.Size = new System.Drawing.Size(275, 21);
            this.textBoxAssPath.TabIndex = 4;
            // 
            // button_AssPathSelector
            // 
            this.button_AssPathSelector.Location = new System.Drawing.Point(289, 31);
            this.button_AssPathSelector.Name = "button_AssPathSelector";
            this.button_AssPathSelector.Size = new System.Drawing.Size(38, 23);
            this.button_AssPathSelector.TabIndex = 5;
            this.button_AssPathSelector.Text = "……";
            this.button_AssPathSelector.UseVisualStyleBackColor = true;
            // 
            // textBox_MovFps
            // 
            this.textBox_MovFps.Location = new System.Drawing.Point(8, 81);
            this.textBox_MovFps.Name = "textBox_MovFps";
            this.textBox_MovFps.Size = new System.Drawing.Size(319, 21);
            this.textBox_MovFps.TabIndex = 6;
            // 
            // textBox_MovTime
            // 
            this.textBox_MovTime.Location = new System.Drawing.Point(8, 133);
            this.textBox_MovTime.Name = "textBox_MovTime";
            this.textBox_MovTime.Size = new System.Drawing.Size(319, 21);
            this.textBox_MovTime.TabIndex = 7;
            // 
            // button_MovPathSelector
            // 
            this.button_MovPathSelector.Location = new System.Drawing.Point(289, 181);
            this.button_MovPathSelector.Name = "button_MovPathSelector";
            this.button_MovPathSelector.Size = new System.Drawing.Size(38, 23);
            this.button_MovPathSelector.TabIndex = 9;
            this.button_MovPathSelector.Text = "……";
            this.button_MovPathSelector.UseVisualStyleBackColor = true;
            // 
            // textBox_MovPath
            // 
            this.textBox_MovPath.Location = new System.Drawing.Point(8, 182);
            this.textBox_MovPath.Name = "textBox_MovPath";
            this.textBox_MovPath.Size = new System.Drawing.Size(275, 21);
            this.textBox_MovPath.TabIndex = 8;
            // 
            // button_AssConvert
            // 
            this.button_AssConvert.Location = new System.Drawing.Point(3, 221);
            this.button_AssConvert.Name = "button_AssConvert";
            this.button_AssConvert.Size = new System.Drawing.Size(333, 23);
            this.button_AssConvert.TabIndex = 1;
            this.button_AssConvert.Text = "转换";
            this.button_AssConvert.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer_Main);
            this.Name = "Form_Main";
            this.Text = "ffmpeg助手";
            this.splitContainer_Main.Panel1.ResumeLayout(false);
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            this.splitContainer_Main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_AssConverter.ResumeLayout(false);
            this.groupBox_AssConverter.ResumeLayout(false);
            this.groupBox_AssConverter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_Main;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_AssConverter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.GroupBox groupBox_AssConverter;
        private System.Windows.Forms.TextBox textBoxAssPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AssPathSelector;
        private System.Windows.Forms.Button button_AssConvert;
        private System.Windows.Forms.Button button_MovPathSelector;
        private System.Windows.Forms.TextBox textBox_MovPath;
        private System.Windows.Forms.TextBox textBox_MovTime;
        private System.Windows.Forms.TextBox textBox_MovFps;
    }
}

