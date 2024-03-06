using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Lastname = textBox1.Text;
            string Firstname = textBox2.Text;
            string Middlename = textBox3.Text;

            string day = comboBox1.GetItemText(comboBox1.SelectedItem);
            string month = comboBox3.GetItemText(comboBox3.SelectedItem);
            string year = comboBox2.GetItemText(comboBox2.SelectedItem);
            

            string Gender = radioButton1.Checked == true ? "Male" : "Female";

            MessageBox.Show("Student: " + Firstname + " " + Middlename + " " + Lastname + "\nGender: " + Gender + "\nDate Of Birth: " + day + "/" + month + "/" + year );

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }

            for (int i = 1; i <= 12; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }

            for (int i = 1900; i <= 2024; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

