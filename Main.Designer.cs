namespace Ffmpeg_With_Shell
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_AssConverter = new System.Windows.Forms.TabPage();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_AssConvert = new System.Windows.Forms.Button();
            this.groupBox_AssConverter = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ResY = new System.Windows.Forms.TextBox();
            this.textBox_ResX = new System.Windows.Forms.TextBox();
            this.comboBox_Resolution = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_FrameRate = new System.Windows.Forms.ComboBox();
            this.button_MovPathSelector = new System.Windows.Forms.Button();
            this.textBox_MovPath = new System.Windows.Forms.TextBox();
            this.button_AssPathSelector = new System.Windows.Forms.Button();
            this.textBox_AssPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel1.SuspendLayout();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_AssConverter.SuspendLayout();
            this.groupBox_AssConverter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Main.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer_Main.Name = "splitContainer_Main";
            // 
            // splitContainer_Main.Panel1
            // 
            this.splitContainer_Main.Panel1.Controls.Add(this.tabControl_Main);
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.textBox_Output);
            this.splitContainer_Main.Size = new System.Drawing.Size(1200, 675);
            this.splitContainer_Main.SplitterDistance = 520;
            this.splitContainer_Main.SplitterWidth = 6;
            this.splitContainer_Main.TabIndex = 0;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_AssConverter);
            this.tabControl_Main.Controls.Add(this.tabPage2);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(520, 675);
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_AssConverter
            // 
            this.tabPage_AssConverter.Controls.Add(this.button_Stop);
            this.tabPage_AssConverter.Controls.Add(this.button_AssConvert);
            this.tabPage_AssConverter.Controls.Add(this.groupBox_AssConverter);
            this.tabPage_AssConverter.Location = new System.Drawing.Point(4, 28);
            this.tabPage_AssConverter.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_AssConverter.Name = "tabPage_AssConverter";
            this.tabPage_AssConverter.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_AssConverter.Size = new System.Drawing.Size(512, 643);
            this.tabPage_AssConverter.TabIndex = 0;
            this.tabPage_AssConverter.Text = "Ass字幕转换";
            this.tabPage_AssConverter.UseVisualStyleBackColor = true;
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(4, 596);
            this.button_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(500, 34);
            this.button_Stop.TabIndex = 2;
            this.button_Stop.Text = "停止";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_AssConvert
            // 
            this.button_AssConvert.Location = new System.Drawing.Point(4, 552);
            this.button_AssConvert.Margin = new System.Windows.Forms.Padding(4);
            this.button_AssConvert.Name = "button_AssConvert";
            this.button_AssConvert.Size = new System.Drawing.Size(500, 34);
            this.button_AssConvert.TabIndex = 1;
            this.button_AssConvert.Text = "转换";
            this.button_AssConvert.UseVisualStyleBackColor = true;
            this.button_AssConvert.Click += new System.EventHandler(this.button_AssConvert_Click);
            // 
            // groupBox_AssConverter
            // 
            this.groupBox_AssConverter.Controls.Add(this.groupBox1);
            this.groupBox_AssConverter.Controls.Add(this.comboBox_FrameRate);
            this.groupBox_AssConverter.Controls.Add(this.button_MovPathSelector);
            this.groupBox_AssConverter.Controls.Add(this.textBox_MovPath);
            this.groupBox_AssConverter.Controls.Add(this.button_AssPathSelector);
            this.groupBox_AssConverter.Controls.Add(this.textBox_AssPath);
            this.groupBox_AssConverter.Controls.Add(this.label4);
            this.groupBox_AssConverter.Controls.Add(this.label2);
            this.groupBox_AssConverter.Controls.Add(this.label1);
            this.groupBox_AssConverter.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_AssConverter.Location = new System.Drawing.Point(4, 4);
            this.groupBox_AssConverter.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_AssConverter.Name = "groupBox_AssConverter";
            this.groupBox_AssConverter.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_AssConverter.Size = new System.Drawing.Size(504, 538);
            this.groupBox_AssConverter.TabIndex = 0;
            this.groupBox_AssConverter.TabStop = false;
            this.groupBox_AssConverter.Text = "设置参数";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_ResY);
            this.groupBox1.Controls.Add(this.textBox_ResX);
            this.groupBox1.Controls.Add(this.comboBox_Resolution);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 108);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分辨率";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "预设";
            // 
            // textBox_ResY
            // 
            this.textBox_ResY.Location = new System.Drawing.Point(161, 62);
            this.textBox_ResY.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ResY.MaxLength = 5;
            this.textBox_ResY.Name = "textBox_ResY";
            this.textBox_ResY.Size = new System.Drawing.Size(70, 28);
            this.textBox_ResY.TabIndex = 12;
            this.textBox_ResY.Text = "1080";
            this.textBox_ResY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_ResY.TextChanged += new System.EventHandler(this.textBox_ResY_TextChanged);
            this.textBox_ResY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ResY_KeyPress);
            // 
            // textBox_ResX
            // 
            this.textBox_ResX.Location = new System.Drawing.Point(49, 62);
            this.textBox_ResX.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ResX.MaxLength = 5;
            this.textBox_ResX.Name = "textBox_ResX";
            this.textBox_ResX.Size = new System.Drawing.Size(70, 28);
            this.textBox_ResX.TabIndex = 11;
            this.textBox_ResX.Text = "1920";
            this.textBox_ResX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_ResX.TextChanged += new System.EventHandler(this.textBox_ResX_TextChanged);
            this.textBox_ResX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ResX_KeyPress);
            // 
            // comboBox_Resolution
            // 
            this.comboBox_Resolution.FormattingEnabled = true;
            this.comboBox_Resolution.Location = new System.Drawing.Point(66, 29);
            this.comboBox_Resolution.Name = "comboBox_Resolution";
            this.comboBox_Resolution.Size = new System.Drawing.Size(250, 26);
            this.comboBox_Resolution.TabIndex = 16;
            this.comboBox_Resolution.SelectedIndexChanged += new System.EventHandler(this.comboBox_Resolution_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "高";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "宽";
            // 
            // comboBox_FrameRate
            // 
            this.comboBox_FrameRate.FormattingEnabled = true;
            this.comboBox_FrameRate.Location = new System.Drawing.Point(12, 120);
            this.comboBox_FrameRate.Name = "comboBox_FrameRate";
            this.comboBox_FrameRate.Size = new System.Drawing.Size(250, 26);
            this.comboBox_FrameRate.TabIndex = 14;
            this.comboBox_FrameRate.SelectionChangeCommitted += new System.EventHandler(this.comboBox_FrameRate_SelectionChangeCommitted);
            // 
            // button_MovPathSelector
            // 
            this.button_MovPathSelector.Location = new System.Drawing.Point(434, 197);
            this.button_MovPathSelector.Margin = new System.Windows.Forms.Padding(4);
            this.button_MovPathSelector.Name = "button_MovPathSelector";
            this.button_MovPathSelector.Size = new System.Drawing.Size(57, 34);
            this.button_MovPathSelector.TabIndex = 9;
            this.button_MovPathSelector.Text = "……";
            this.button_MovPathSelector.UseVisualStyleBackColor = true;
            this.button_MovPathSelector.Click += new System.EventHandler(this.button_MovPathSelector_Click);
            // 
            // textBox_MovPath
            // 
            this.textBox_MovPath.Location = new System.Drawing.Point(12, 197);
            this.textBox_MovPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MovPath.Name = "textBox_MovPath";
            this.textBox_MovPath.Size = new System.Drawing.Size(410, 28);
            this.textBox_MovPath.TabIndex = 8;
            // 
            // button_AssPathSelector
            // 
            this.button_AssPathSelector.Location = new System.Drawing.Point(434, 46);
            this.button_AssPathSelector.Margin = new System.Windows.Forms.Padding(4);
            this.button_AssPathSelector.Name = "button_AssPathSelector";
            this.button_AssPathSelector.Size = new System.Drawing.Size(57, 34);
            this.button_AssPathSelector.TabIndex = 5;
            this.button_AssPathSelector.Text = "……";
            this.button_AssPathSelector.UseVisualStyleBackColor = true;
            this.button_AssPathSelector.Click += new System.EventHandler(this.button_AssPathSelector_Click);
            // 
            // textBox_AssPath
            // 
            this.textBox_AssPath.AllowDrop = true;
            this.textBox_AssPath.Location = new System.Drawing.Point(12, 48);
            this.textBox_AssPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_AssPath.Name = "textBox_AssPath";
            this.textBox_AssPath.Size = new System.Drawing.Size(410, 28);
            this.textBox_AssPath.TabIndex = 4;
            this.textBox_AssPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxAssPath_DragDrop);
            this.textBox_AssPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxAssPath_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "mov输出路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "帧率：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ass文件路径：";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(512, 643);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "敬请期待...";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_Output
            // 
            this.textBox_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Output.Location = new System.Drawing.Point(0, 0);
            this.textBox_Output.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Output.Size = new System.Drawing.Size(674, 675);
            this.textBox_Output.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.splitContainer_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "FFmpeg助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.splitContainer_Main.Panel1.ResumeLayout(false);
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            this.splitContainer_Main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_AssConverter.ResumeLayout(false);
            this.groupBox_AssConverter.ResumeLayout(false);
            this.groupBox_AssConverter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_Main;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_AssConverter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.GroupBox groupBox_AssConverter;
        private System.Windows.Forms.TextBox textBox_AssPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AssPathSelector;
        private System.Windows.Forms.Button button_AssConvert;
        private System.Windows.Forms.Button button_MovPathSelector;
        private System.Windows.Forms.TextBox textBox_MovPath;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ResY;
        private System.Windows.Forms.TextBox textBox_ResX;
        private System.Windows.Forms.ComboBox comboBox_FrameRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Resolution;
    }
}

