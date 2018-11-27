﻿using AdasoftSpravaProjektov.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdasoftSpravaProjektov
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
            ZoznamProjForm zdrojProjForm = new ZoznamProjForm();
            
          
            {
                Application.Run(zdrojProjForm);
            }

        }

    }
}