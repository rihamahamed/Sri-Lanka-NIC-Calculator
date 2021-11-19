using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIC_Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {

            int year, month = 1, day, age;
            string gender = "MALE", nic,voter;
            nic = txt_nic.Text;

            if (nic.Length == 12)
            {
                year = int.Parse(nic.Substring(0, 4));
                day = int.Parse(nic.Substring(4, 3));
            }
            else if (nic.Length == 10)
            {
                year = int.Parse("19" + nic.Substring(0, 2));
                day = int.Parse(nic.Substring(2, 3));
            }
            else
            {
                string messege = "Plece Check Your NIC Number " + nic;
                string title = "Invalid NIC Number";
                MessageBoxButtons button = MessageBoxButtons.RetryCancel;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result = MessageBox.Show(messege, title, button, icon);
                if (result == DialogResult.Retry)
                {
                    txt_nic.Clear();
                    txt_nic.Focus();
                }
                else
                {
                    this.Close();
                }
                return;
            }

            if (day > 500)
            {
                gender = "FEMALE";
                day -= 500;
            }

            int[] Mday = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i < 12; i++)
            {
                if (day > Mday[i])
                {
                    month += 1;
                    day -= Mday[i];
                }
            }

            string smon = month.ToString();
            if (month == 1)
            {
                smon = "JANUARY";
            }
            else if (month == 2)
            {
                smon = "FEBRUARY";
            }
            else if (month == 3)
            {
                smon = "MARCH";
            }
            else if (month == 4)
            {
                smon = "APRIL";
            }
            else if (month == 5)
            {
                smon = "MAY";
            }
            else if (month == 6)
            {
                smon = "JUNE";
            }
            else if (month == 7)
            {
                smon = "JULLY";
            }
            else if (month == 8)
            {
                smon = "AUGEST";
            }
            else if (month == 9)
            {
                smon = "SEPTEMBER";
            }
            else if (month == 10)
            {
                smon = "OCTOBER";
            }
            else if (month == 11)
            {
                smon = "NOVEMBER";
            }
            else if (month == 12)
            {
                smon = "DECEMBER";
            }

            //{"JANUARY", "FEB", "MARCH", "APRIL", "MAY", "JUNE", "JULLY", "AUGEST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER" };

            age = DateTime.Today.Year - year;


            if (age > 18)
            {
                voter = "YOUR ELIGIBLE to VOTE";
            }
            else
            {
                int voteT = 18 - age;
                string voteT1 = voteT.ToString();
                voter = "YOUR NOT ELIGIBLE to VOTE WAIT FOR "+ voteT1;
            }
            string age1 = age.ToString();
            textBox1.Text=(smon + " " + day + ", " + year);
            textBox2.Text = (gender);
            textBox3.Text = (age1);
            textBox4.Text = (voter);



        }
        private void button2_Click(object sender, EventArgs e)
        {
            txt_nic.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            txt_nic.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
 }
