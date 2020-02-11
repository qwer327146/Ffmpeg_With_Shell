using Ffmpeg_With_Shell.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ffmpeg_With_Shell
{
    public partial class Form_Main : Form
    {
        private SubInfo subinfo;
        private FfmpegHelper ffmpegHelper;
        private Process mProcess;
        private string localFilePath;
        private string tempFilePath;

        public Form_Main()
        {
            InitializeComponent();
            InitAssConverter();
        }

        private void InitAssConverter()
        {
            subinfo = new SubInfo();
            ffmpegHelper = new FfmpegHelper();
            ffmpegHelper.FfmpegPath = String.Format("{0}{1}",System.AppDomain.CurrentDomain.BaseDirectory,"\\bin\\ffmpeg.exe");            
        }

        private void textBoxAssPath_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        /// <summary>
        /// 拖入ass文件操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAssPath_DragDrop(object sender, DragEventArgs e)
        {            
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);            
            if(files.Length > 1)
            {
                MessageBox.Show("不能拖入多个文件");
                return;
            }
            if (!(Path.GetExtension(files[0]) == ".ass" || Path.GetExtension(files[0]) == ".ASS"))
            {
                MessageBox.Show("仅支持ass文件");
                return;
            }
            textBox_AssPath.Text = files[0];
        }

        /// <summary>
        /// 弹出打开ass文件对号框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AssPathSelector_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePath = new OpenFileDialog();
            filePath.Filter = "(字幕文件)*.ass|*.ass;*.ASS|(所有文件)*.*|*.*";
            filePath.RestoreDirectory = true;

            filePath.ShowDialog();
            textBox_AssPath.Text = filePath.FileName;
        }

        /// <summary>
        /// 弹出保存mov文件对号框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_MovPathSelector_Click(object sender, EventArgs e)
        {
            SaveFileDialog filePath = new SaveFileDialog();
            filePath.Filter = "(视频文件)*.mov|*.mov";
            filePath.RestoreDirectory = true;

            filePath.ShowDialog();
            textBox_MovPath.Text = filePath.FileName;
        }

        private void button_AssConvert_Click(object sender, EventArgs e)
        {
            //判断参数是否为空
            if (textBox_AssPath.Text.Equals("") || textBox_MovFps.Text.Equals("") || textBox_MovTime.Text.Equals("") || textBox_MovPath.Text.Equals(""))
            {
                MessageBox.Show("参数不能为空！");
                return;
            }
            button_AssConvert.Enabled = false;
            textBox_Output.Text = "";
            SetSubinfo();
            
            //启动子线程转换
            ThreadStart childref = new ThreadStart(ConvertAss);
            Thread childThread = new Thread(childref);
            childThread.Start();
        }

        private void SetSubinfo()
        {            
            subinfo.Fps = textBox_MovFps.Text;
            subinfo.Time = textBox_MovTime.Text;
            subinfo.OutputPath = textBox_MovPath.Text;
            //subinfo.InputPath = textBox_AssPath.Text;
            //复制字幕文件到临时目录，subtitles无法接受绝对路径
            localFilePath = textBox_AssPath.Text;
            tempFilePath = String.Format("{0}{1}", System.AppDomain.CurrentDomain.BaseDirectory,"\\temp.ass");
            if(File.Exists(tempFilePath))
            {
                File.Delete(tempFilePath);
            }
            if(File.Exists(localFilePath))
            {
                File.Copy(localFilePath, tempFilePath, true);
            }
            subinfo.InputPath = "temp.ass";

            //设置ffmpeg转换参数
            ffmpegHelper.Arguments = String.Format("-y -f lavfi -i \"color = color = black@0.0:size = 1920x1080, format = rgba, subtitles ={0}:alpha = 1, fps = {1}\" -c:v png -t \"{2}\" {3} -stats",
                subinfo.InputPath, subinfo.Fps, subinfo.Time, subinfo.OutputPath);
            Clipboard.SetText(ffmpegHelper.Arguments);
            
        }

        private void ConvertAss()
        {
            mProcess = new Process();
            mProcess.StartInfo.FileName = ffmpegHelper.FfmpegPath;
            mProcess.StartInfo.Arguments = ffmpegHelper.Arguments;  //参数
            mProcess.StartInfo.UseShellExecute = false; //不使用系统外壳
            mProcess.StartInfo.RedirectStandardError= true;   //ffmpeg.exe错误输出流
            mProcess.StartInfo.CreateNoWindow = true;           
                       
            mProcess.Start();   //启动线程

            while (!mProcess.StandardError.EndOfStream)
            {
                //textBox_Output.AppendText(String.Format("{0}{1}", mProcess.StandardError.ReadLine(), "\r\n"));
                this.SetText(String.Format("{0}{1}", mProcess.StandardError.ReadLine(), "\r\n"));               
            }

            mProcess.WaitForExit(); //等待进程结束
            mProcess.Close();
            mProcess.Dispose(); //释放资源          
            button_AssConvert.BeginInvoke(new Action(() =>
            {
                button_AssConvert.Enabled = true;
            }));
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if(this.textBox_Output.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox_Output.AppendText(text);
                this.textBox_Output.Refresh();
            }
        }        
    }
}
