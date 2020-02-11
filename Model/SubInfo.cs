using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ffmpeg_With_Shell.Model
{
    class SubInfo
    {
        private string inputPath;   //ass文件路径
        private string outputPath;  //mov输出路径
        private string fps;         //转换参数中的帧率
        private string time;        //转换参数中的时间

        public string InputPath { get => inputPath; set => inputPath = value; }
        public string OutputPath { get => outputPath; set => outputPath = value; }
        public string Fps { get => fps; set => fps = value; }
        public string Time { get => time; set => time = value; }
    }
}
