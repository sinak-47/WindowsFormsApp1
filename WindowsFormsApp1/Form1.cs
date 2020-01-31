using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static String txt = "";
        public static List<String> texts = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        public void update_txt()
        {
            this.Cur_Event.Text = txt;
            if (texts.Count != 0)
            {
                this.next.Text = texts[0];
            }
            else
            {
                this.next.Text = "";
            }
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
            this.Cur_Event.Text = txt;
            if (texts.Count != 0)
            {
                this.next.Text = texts[0];
            }
            else
            {
                this.next.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (texts.Count != 0)
            {
                txt = texts.First();
                texts.RemoveAt(0);
                this.Cur_Event.Text = txt;
                if (texts.Count != 0)
                {
                    this.next.Text = texts[0];
                }
                else
                {
                    this.next.Text = "";
                }
            }
        }
    }
}
