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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.super.update_txt();
            this.Close();
        }

        static String Send_Email_SMS(String text, Boolean SMS, Boolean Email, String phonenumber, String EmailAddress, int smslimit, int smssent)
        {
            if (SMS)
            {
                SendSMS(text, phonenumber, smslimit, smssent);
                smssent++;
            }
            else if (Email)
            {
                SendEmail(text, EmailAddress);
            }
            if (SMS & Email)
            {
                SendSMS(text, phonenumber, smslimit, smssent);
                smssent++;
                SendEmail(text, EmailAddress);
            }


            return text;
        }



        static int SendSMS(String text, String phonenumber, int smslimit, int smssent)
        {
            if (smslimit >= smssent)
            {
                // send sms to phone number
                return 1;
            }
            else
            {
                return 0;
            }
        }


        static void SendEmail(String text, String EmailAddress)
        {
            // Send Email to Email Address
        }

    }
}
