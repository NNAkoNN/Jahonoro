﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        Employee request = new Employee();
        object object1;
        int ready = 0;
        int reqS = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reqS++;
            ready = reqS - 1;
            if (radioButton1.Checked)
            {
                object1 = request.NewRequest(Convert.ToInt32(textBox1.Text), "Chicken");
                label3.Text = request.Inspect(object1);

            }
            else
            {
                object1 = request.NewRequest(Convert.ToInt32(textBox1.Text), "Egg");
                label3.Text = request.Inspect(object1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reqS++;
            try
            {
                object1 = request.CopyRequest();
                label3.Text = request.Inspect(object1);
            }
            catch (Exception ex2)
            {
                label5.Text += ex2.Message + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ready++;
            try
            {
                if (ready > reqS)
                {
                    throw new Exception("Emplyee Can't Cook The Already Prepared request!");
                }
                else
                {
                    label5.Text += request.PrepareFood(object1) + "\n";
                }
            }
            catch (Exception newExc)
            {
                label5.Text += newExc.Message + "\n";
            }
        }
    }
}
