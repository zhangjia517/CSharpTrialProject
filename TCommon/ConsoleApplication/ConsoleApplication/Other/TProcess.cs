﻿using System.Diagnostics;

namespace TCommon.Other
{
    internal class TProcess
    {
        public static void KillProcess()
        {
            Process[] myProcess;
            myProcess = Process.GetProcessesByName("notepad++");
            foreach (Process instance in myProcess)
            {
                instance.Kill();
            }
        }
    }
}