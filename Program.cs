﻿using OptimizationImages;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ImageMagick.Net
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RadForm1());
        }
    }
}