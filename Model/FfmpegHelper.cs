﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ffmpeg_With_Shell
{
    class FfmpegHelper
    {
        private string ffmpegPath;  //ffmpeg.exe路径
        private string ffplayPath;
        private string ffprobePath;

        private string arguments;   //参数
                

        public string FfmpegPath { get => ffmpegPath; set => ffmpegPath = value; }
        public string FfplayPath { get => ffplayPath; set => ffplayPath = value; }
        public string FfprobePath { get => ffprobePath; set => ffprobePath = value; }
        public string Arguments { get => arguments; set => arguments = value; }
    }
}
