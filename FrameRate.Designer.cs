namespace Ffmpeg_With_Shell
{
    partial class FrameRate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_FrameRate = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_FrameRate
            // 
            this.textBox_FrameRate.Location = new System.Drawing.Point(12, 12);
            this.textBox_FrameRate.MaxLength = 7;
            this.textBox_FrameRate.Name = "textBox_FrameRate";
            this.textBox_FrameRate.Size = new System.Drawing.Size(70, 28);
            this.textBox_FrameRate.TabIndex = 0;
            this.textBox_FrameRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_FrameRate_KeyPress);
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(147, 10);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 30);
            this.button_Submit.TabIndex = 1;
            this.button_Submit.Text = "确定";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(88, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "帧/秒";
            // 
            // FrameRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 54);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_FrameRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrameRate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "帧率设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FrameRate;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Label label1;
    }
}