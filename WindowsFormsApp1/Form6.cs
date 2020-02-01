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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.super.update_txt();
            this.Close();
        }

        //void membership(string Phone_number, string Student_id, string Email)
        //{
        //    int get_Phone_number()
        //    {
        //        is_valid_PhoneNumber(Phone_number);
        //    }
        //    void set_Phone_number();

        //    int get_Student_id()
        //    {
        //        void is_valid_studentId(Student_id);
        //    }
        //    void set_Student_id();

        //    int get_Email()
        //    {
        //        is_valid_Email(Email);
        //    }
        //    void set_Email();
        //}
        //void is_valid_PhoneNumber(string Phone_number)
        //{
        //    int a = 0;
        //    while (Phone_number[a])
        //    {
        //        a++;
        //    }
        //    if (a = 11 && Phone_number[0] = 0 && Phone_number[1] = 9)
        //    {
        //        return Phone_number;
        //    }
        //}

        //void is_valid_studentId(string Student_id)
        //{
        //    int j = 0;
        //    while (Student_id[j])
        //    {
        //        j++;
        //    }
        //    if (j = 9)
        //        return Student_id;
        //}

        //void is_valid_email(string Email)
        //{
        //    int sizeOf;
        //    char* ptr = nullptr;
        //    char* ptr2 = nullptr;

        //    sizeOf = strlen(Email);

        //    for (int i = 0; i < sizeOf; i++)
        //    {
        //        ptr = strstr(Email, "@");
        //        if (ptr != nullptr)
        //        {
        //            break;
        //        }
        //    }

        //    for (int i = 0; i < sizeOf; i++)
        //    {
        //        ptr2 = strstr(Email, ".");
        //        if (ptr2 != nullptr && &ptr2 > &ptr)
        //        {
        //            break;
        //        }
        //    }

        //    if (ptr != nullptr)
        //    {
        //        if (ptr2 != 0 && &ptr2 < &ptr)
        //        {
        //            return Email;
        //        }
        //    }
        //}
    }
}


