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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (this.emergency.Checked)
            {
                Program.curEvent = text.Text;
            }
            else
            {
                if (Program.curEvent == "")
                {
                    Program.curEvent = text.Text;
                }
                else
                {
                    Program.events.Add(text.Text);
                }
            }

            Program.super.update_txt();
            this.Close();
        }
    }
}
