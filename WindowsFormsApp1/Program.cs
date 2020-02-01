using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

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
            (new Thread(SocketListener.StartServer)).Start();

            try
            {
                StreamReader sr = new StreamReader("eventsList.txt");
                String s = sr.ReadLine();
                if (s != null)
                {
                    curEvent = s; ;
                }

                while (true)
                {
                    s = sr.ReadLine();
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

            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            super = new Form1();
            Application.Run(super);
            System.Environment.Exit(0);
        }
    }

    public class SocketListener
    {

        const int PORT_NO = 5000;
        const string SERVER_IP = "127.0.0.1";

        public static void StartServer()
        {
            while (true)
            {
                
                IPAddress localAdd = IPAddress.Parse(SERVER_IP);
                TcpListener listener = new TcpListener(localAdd, PORT_NO);

                listener.Start();

                TcpClient client = listener.AcceptTcpClient();

                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];


                nwStream.Write(System.Text.Encoding.ASCII.GetBytes(Program.curEvent), 0, System.Text.Encoding.ASCII.GetBytes(Program.curEvent).Length);
                client.Close();
                listener.Stop();
                
            }
        }
    }

}
