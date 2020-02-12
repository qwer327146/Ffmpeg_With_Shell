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
using System.Text.RegularExpressions;

namespace Ffmpeg_With_Shell
{
    public partial class Main : Form
    {
        private SubInfo subinfo;
        private FfmpegHelper ffmpegHelper;
        private Process mProcess;
        private string localFilePath;
        private string tempFilePath;
        //private ThreadStart childref;
        //private Thread childThread;

         class FrameRate
        {
            public string Name;
            public string Value;
            public FrameRate(string name, string val)
            {
                Name = name;
                Value = val;
            }
        }
         List<FrameRate> frameRates;
        public static float CustomFrameRate = 30;

        class Resolution
        {
            public string Name;
            public uint Width;
            public uint Height;
            public Resolution(string name, uint w, uint h)
            {
                Name = name;
                Width = w;
                Height = h;
            }
        }
        List<Resolution> resolutions;

        public Main()
        {
            InitializeComponent();
            InitAssConverter();
        }

        private void InitAssConverter()
        {
            subinfo = new SubInfo();
            ffmpegHelper = new FfmpegHelper();
            ffmpegHelper.FfmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\ffmpeg.exe");
            //硬编码！
            frameRates = new List<FrameRate>();
            frameRates.Add(new FrameRate("10  帧/秒", "10"));
            frameRates.Add(new FrameRate("12  帧/秒", "12"));
            frameRates.Add(new FrameRate("12.5  帧/秒", "12500/1000"));
            frameRates.Add(new FrameRate("15  帧/秒", "15"));
            frameRates.Add(new FrameRate("23.976  帧/秒", "24000/1001"));
            frameRates.Add(new FrameRate("24  帧/秒", "24"));
            frameRates.Add(new FrameRate("25  帧/秒", "25"));
            frameRates.Add(new FrameRate("29.97  帧/秒", "30000/1001"));
            frameRates.Add(new FrameRate("30  帧/秒", "30"));
            frameRates.Add(new FrameRate("50  帧/秒", "50"));
            frameRates.Add(new FrameRate("59.94  帧/秒", "60000/1001"));
            frameRates.Add(new FrameRate("60  帧/秒", "60"));
            frameRates.Add(new FrameRate("自定义...", ""));
            foreach (var frameRate in frameRates)
            {
                comboBox_FrameRate.Items.Add(frameRate.Name);
            }
            //默认30帧
            comboBox_FrameRate.SelectedIndex = 8;
            resolutions = new List<Resolution>();
            resolutions.Add(new Resolution("360P  (640×360)", 640, 360));
            resolutions.Add(new Resolution("480P/SD  (854×480)", 854, 480));
            resolutions.Add(new Resolution("540P  (960×540)", 960, 540));
            resolutions.Add(new Resolution("720P/HD  (1280×720)", 1280, 720));
            resolutions.Add(new Resolution("1080P/FHD  (1920×1080)", 1920, 1080));
            resolutions.Add(new Resolution("2K/QHD  (2560×1440)", 2560, 1440));
            resolutions.Add(new Resolution("4K UHD  (3840×2160)", 3840, 2160));
            resolutions.Add(new Resolution("8K UHD  (7680×4320)", 7680, 4320));
            resolutions.Add(new Resolution("QVGA  (320×240)", 320, 240));
            resolutions.Add(new Resolution("VGA  (640×480)", 640, 480));
            resolutions.Add(new Resolution("SVGA  (800×600)", 800, 600));
            resolutions.Add(new Resolution("XGA  (1024×768)", 1024, 768));
            resolutions.Add(new Resolution("SXGA  (1280×1024)", 1280, 1024));
            foreach (var resolution in resolutions)
            {
                comboBox_Resolution.Items.Add(resolution.Name);
            }
            //默认1080P
            comboBox_Resolution.SelectedIndex = 4;
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
            if (!(Path.GetExtension(files[0]).ToLower() == ".ass"))
            {
                MessageBox.Show("仅支持ass文件");
                return;
            }
            textBox_AssPath.Text = files[0];
            textBox_MovPath.Text = Path.ChangeExtension(textBox_AssPath.Text, ".mov");
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
            textBox_MovPath.Text = Path.ChangeExtension(textBox_AssPath.Text, ".mov");
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
            if (string.IsNullOrWhiteSpace(textBox_AssPath.Text) || string.IsNullOrWhiteSpace(frameRates[comboBox_FrameRate.SelectedIndex].Value) || string.IsNullOrWhiteSpace(textBox_MovPath.Text))
            {
                MessageBox.Show("参数不能为空！");
                return;
            }
            button_AssConvert.Enabled = false;
            textBox_Output.Text = "";
            SetSubinfo();

            //启动子线程转换
            //childref = new ThreadStart(ConvertAss);
            //childThread = new Thread(childref);
            //childThread.Start();
            ConvertAss();
        }

        private void SetSubinfo()
        {
            subinfo.Fps = frameRates[comboBox_FrameRate.SelectedIndex].Value;
            //subinfo.Time = textBox_MovTime.Text;
            subinfo.OutputPath = textBox_MovPath.Text;
            subinfo.ResX = textBox_ResX.Text;
            subinfo.ResY = textBox_ResY.Text;
            //subinfo.InputPath = textBox_AssPath.Text;
            //复制字幕文件到临时目录，subtitles无法接受绝对路径
            localFilePath = textBox_AssPath.Text;
            tempFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "temp.ass");
            if(File.Exists(tempFilePath))
            {
                File.Delete(tempFilePath);
            }
            //还要获取ass本身内容
            string[] assFileContent = { };
            if (File.Exists(localFilePath))
            {
                File.Copy(localFilePath, tempFilePath, true);
                assFileContent = File.ReadAllText(tempFilePath, Encoding.UTF8).Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            }
            subinfo.InputPath = "temp.ass";
            double maxTime = 0;
            foreach (var assLine in assFileContent)
            {
                if(Regex.IsMatch(assLine, "Dialogue", RegexOptions.IgnoreCase))
                {
                    //获得ass事件数据
                    var assEvent = Regex.Replace(assLine, "Dialogue:", "", RegexOptions.IgnoreCase).Trim().Split(new[] { ',' });
                    //获得结束时间
                    var lastTime = ParseTimeCode(assEvent[2].Trim());
                    if (lastTime > maxTime) maxTime = lastTime;
                }
            }
            //设置最终ass文件时长
            subinfo.Time = maxTime.ToString();

            //设置ffmpeg转换参数
            ffmpegHelper.Arguments = String.Format("-y -f lavfi -i \"color=c=black@0.0:s={0}x{1}:d={2}:r={3},format=rgba,ass={4}:alpha=1\" -c:v png \"{5}\"",
                subinfo.ResX,           //分辨率
                subinfo.ResY,           //分辨率
                subinfo.Time,           //时间
                subinfo.Fps,            //帧数
                subinfo.InputPath,      //ass文件路径
                subinfo.OutputPath);    //输出路径
            Clipboard.SetText(ffmpegHelper.Arguments);
        }

        double ParseTimeCode(string timeCode)
        {
            var arr = timeCode.Split(new[] { ':' });
            double.TryParse(arr[0], out double hour);
            double.TryParse(arr[1], out double minute);
            double.TryParse(arr[2], out double second);
            return hour * 3600 + minute * 60 + second;
        }

        string ConvertToTimeCode(double time)
        {
            var hour = (int)(time / 3600);
            var minute = (int)(time % 3600 / 60);
            var second = time % 60;
            return string.Format("{0:}:{1}:{2:#.###}", hour, minute, second);
        }

        async void ConvertAss()
        {
            mProcess = new Process();
            mProcess.StartInfo.FileName = ffmpegHelper.FfmpegPath;
            mProcess.StartInfo.Arguments = ffmpegHelper.Arguments;  //参数
            mProcess.StartInfo.UseShellExecute = false; //不使用系统外壳
            mProcess.StartInfo.RedirectStandardError = true;   //ffmpeg.exe错误输出流
            mProcess.StartInfo.CreateNoWindow = true;
            mProcess.Start();   //启动进程

            while (!mProcess.StandardError.EndOfStream)
            {
                //    SetText(String.Format("{0}{1}", mProcess.StandardError.ReadLine(), "\r\n"));
                var text = await Task.Run(() => mProcess.StandardError.ReadLine());
                textBox_Output.AppendText(string.Format("{0}{1}", text, "\r\n"));
            }

            await Task.Run(() => mProcess.WaitForExit());   //等待进程结束
            if (mProcess.ExitCode != 0)
            {
                MessageBox.Show(string.Format("转换出现问题！\r\nExitCode={0}", mProcess.ExitCode));
            }
            mProcess.Close();
            mProcess.Dispose(); //释放资源       
            mProcess = null;
            button_AssConvert.Enabled = true;
        }

        //delegate void SetTextCallback(string text);

        //private void SetText(string text)
        //{
        //    if(textBox_Output.InvokeRequired)
        //    {
        //        SetTextCallback d = new SetTextCallback(SetText);
        //        Invoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        textBox_Output.AppendText(text);
        //        textBox_Output.Refresh();
        //    }
        //}

        private void button_Stop_Click(object sender, EventArgs e)
        {
            if (mProcess != null)
            {
                mProcess.Kill();    //杀死进程
            }
            button_AssConvert.Enabled = true;
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mProcess != null)
            {
                mProcess.Kill();
            }
        }

        private void textBox_ResX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox_ResY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void comboBox_FrameRate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_FrameRate.SelectedIndex == frameRates.Count - 1)
            {
                Form form = new Ffmpeg_With_Shell.FrameRate();
                form.ShowDialog();
                frameRates[frameRates.Count - 1].Name = string.Format("{0}  帧/秒，自定义...", CustomFrameRate);
                frameRates[frameRates.Count - 1].Value = CustomFrameRate.ToString();
                comboBox_FrameRate.Items[frameRates.Count - 1] = frameRates[frameRates.Count - 1].Name;
            }
        }

        bool dontCheckResolution = false;
        private void comboBox_Resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Resolution.SelectedIndex >= 0)
            {
                dontCheckResolution = true;
                textBox_ResX.Text = resolutions[comboBox_Resolution.SelectedIndex].Width.ToString();
                textBox_ResY.Text = resolutions[comboBox_Resolution.SelectedIndex].Height.ToString();
                dontCheckResolution = false;
            }
        }

        void checkResolutionPreset()
        {
            if (dontCheckResolution) return;
            uint.TryParse(textBox_ResX.Text, out uint width);
            uint.TryParse(textBox_ResY.Text, out uint height);
            bool isFound = false;
            for (int i = 0; i < resolutions.Count; i++)
            {
                var resolution = resolutions[i];
                if (width == resolution.Width && height == resolution.Height)
                {
                    comboBox_Resolution.SelectedIndex = i;
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                comboBox_Resolution.SelectedIndex = -1;
                comboBox_Resolution.Text = "自定义";
            }
        }

        private void textBox_ResX_TextChanged(object sender, EventArgs e)
        {
            checkResolutionPreset();
        }

        private void textBox_ResY_TextChanged(object sender, EventArgs e)
        {
            checkResolutionPreset();
        }
    }
}
