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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.super.update_txt();
            this.Close();
        }

        String Show(String text, String clientID, String date, int hour, int minute, String day)
        {
            if (checkvalidday(date) != 1)
            {
                // error wrong date format
            }
            if (hour <= 24 && minute < 60 && minute > 0)
            {
                // correct time
            }
            else
            {
                // incorrect time
            }

            return text;
        }


        private int checkvalidday(String date)
        {
            // date : xx/xx/xxxx  ---> 9 characters
            int day;
            day = 10 * (date[0]) + date[1];

            int month;
            month = 10 * (date[3]) + date[4];

            int year;
            year = 1000 * (date[6]) + 100 * date[7] + 10 * date[8] + date[9];


            if (month > 7)
            {
                if (1398 < year && year < 1400)
                    if (day <= 31)
                    {
                        return 1;
                    }
            }
            else if (month <= 11)
            {
                if (1398 < year && year < 1400)
                    if (day <= 30)
                    {
                        return 1;
                    }
            }
            else if (month == 12)
            {
                if (1398 < year && year < 1400)
                    if (day <= 29)
                    {
                        return 1;
                    }
            }
            else
            {
                return 0;
            }

            return 0;
        }
    }
}
