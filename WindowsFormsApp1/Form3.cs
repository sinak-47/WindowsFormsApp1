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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.super.update_txt();
            this.Close();
        }

//        int convert_date(char date[])
//        {
//            int y;
//            int m;
//            int d;
//            int i;
//            int j, a;
//            int k, b;
//            char year[4];
//            char month[2];
//            char day[2];

//            for (i = 0; i < 4; i++)
//            {
//                year[i] = date[i];
//            }

//            for (j = 5, a = 0; j < 7, a < 2; j++,a++)
//	{
//                month[a] = date[j];
//            }

//            for (k = 8, b = 0; k < 10, b < 2; k++,b++)
//	{
//                day[b] = date[k];
//            }

//            y = atoi(year);
//            m = atoi(month);
//            d = atoi(day);
//            return y,m,d;

//        }

//        bool is_leap_year(int y)  //sale kabise
//        {
//            int r = y % 33;
//            return r == 1 || r == 5 || r == 9 || r == 13 || r == 17 || r == 22 || r == 26 || r == 30;
//        }

//        int days_of_month(int y, int m, int d)   //tedade rooz haye mah ro check mikone
//        {

//            if (m < 7)
//                return 31;
//            else if (m < 12)
//                return 30;
//            else if (m == 12)
//                return is_leap_year(y) ? 30 : 29;
//            else
//                abort();
//        }

//        bool check_date(int y, int m, int d)
//        {
//            if (y < 0 || m < 1 || m > 12 || d < 1 || d > days_of_month(y, m, d))
//                abort();
//            else
//                return true;
//        }

//        int order_notification(string text, char date[])   //sefaresh e'lan
//        {
//            int y, m, d;
//            int convert_date(char date[]);
//            int days_of_month(int y, int m, int d);
//            int check_date(int y, int m, int d);

//            if (check_date)
//            {
//                return y;
//                return m;
//                return d;
//            }
//            else
//                abort;

//        }
    }
}
