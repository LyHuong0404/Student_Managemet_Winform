﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Form());

            /*Login_Form fLogin = new Login_Form();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new ProcessBar_login());
            }
            else
            {
                Application.Exit();
            }*/
        }
    }
}
