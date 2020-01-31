using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            update_txt();
        }

        public void update_txt()
        {
            this.Cur_Event.Text = Program.curEvent;
            if (Program.events.Count != 0)
            {
                this.next.Text = Program.events[0];
            }
            else
            {
                this.next.Text = "";
            }

            TextWriter tw = new StreamWriter("eventsList.txt");
            tw.WriteLine(Program.curEvent);
            foreach (String s in Program.events)
                tw.WriteLine(s);

            tw.Close();
        }

        private void Order_Event_Click(object sender, EventArgs e)
        {

        }

        private void Setup_Bluetooth_Click(object sender, EventArgs e)
        {

        }

        private void Direct_Stream_Click(object sender, EventArgs e)
        {

        }

        private void Create_Event_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
        }

        private void Email_SMS_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Cur_Event.Text = Program.curEvent;
            if (Program.events.Count != 0)
            {
                this.next.Text = Program.events[0];
            }
            else
            {
                this.next.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.events.Count != 0)
            {
                Program.curEvent = Program.events.First();
                Program.events.RemoveAt(0);
                this.Cur_Event.Text = Program.curEvent;
                if (Program.events.Count != 0)
                {
                    this.next.Text = Program.events[0];
                }
                else
                {
                    this.next.Text = "";
                }
            }
            TextWriter tw = new StreamWriter("eventsList.txt");
            tw.WriteLine(Program.curEvent);
            foreach (String s in Program.events)
                tw.WriteLine(s);

            tw.Close();
        }
    }
}
