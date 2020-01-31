using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static Form1 super;
        public static String curEvent = "";
        public static List<String> events = new List<String>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                StreamReader sr = new StreamReader("eventsList.txt");

                while (true)
                {
                    String s = sr.ReadLine();
                    if (s==null)
                    {
                        break;
                    }

                    events.Add(s);
                }

                sr.Close();
            }
            catch (Exception)
            {

                throw;
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            super = new Form1();
            Application.Run(super);
        }
    }
}
