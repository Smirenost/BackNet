﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCommands
{
    internal class LLS : ICommand
    {
        public string name { get; set; } = "lls";

        public string description { get; set; } = "Display the files and folders name of the local current working directory";

        public string syntaxHelper { get; set; } = "ls";

        public bool isLocal { get; set; } = true;

        public List<string> validArguments { get; set; } = null;


        public bool PreProcess(List<string> args)
        {
            throw new NotImplementedException();
        }

        public void Process(List<string> args)
        {
            var cwd = Directory.GetCurrentDirectory();
            foreach(var dir in Directory.GetDirectories(cwd))
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"{dirInfo.LastWriteTime:MM/dd/yy  H:mm:ss}   <DIR>   {dirInfo.Name}");
            }
            foreach (var file in Directory.GetFiles(cwd))
            {
                var fileInfo = new DirectoryInfo(file);
                Console.WriteLine($"{fileInfo.LastWriteTime:MM/dd/yy  H:mm:ss}           {fileInfo.Name}");
            }
        }
    }
}