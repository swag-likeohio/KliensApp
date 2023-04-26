using System.Windows.Forms;
using System;
using System.Collections.Specialized;

namespace ApiSample
{
    internal static class Program
    {
        [STAThread]

            static void Main()
            {

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            }
        }
    }
