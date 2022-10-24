using System;
using System.Drawing;
using System.Windows.Forms;
using UserStrory.Models;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        private Student student;
       

        public Form2()
        {
            InitializeComponent();
            this.Text = "Добавления студента";
            student = new Student
            {
                Datarod  = DateTime.Now.AddYears(-16),
                Gender = Gender.Male,
            };
            comboBox1.SelectedItem = student.Gender;
            dateTimePicker1.Value = student.Datarod;
        }
        public Form2(Student source)
           : this()
        {
            textBox1.Text = source.FullName;
            //comboBoxGender.SelectedItem = source.Gender;
            //  dateTimePickerDayB.Value = source.BirthDay;
            // numericUpDownAvg.Value = source.AvgRate;
            // checkBoxDebtor.Checked = source.Debtor;
            // checkBoxDeduct.Checked = source.Deduct;
        }
        public Student Student => student;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FillGender()
        {
          

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            student.FullName = textBox1.Text.Trim();
            Validate();
        }

        public new void Validate()
        {
            button1.Enabled = !string.IsNullOrWhiteSpace(student.FullName);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                student.Gender = (Gender)comboBox2.SelectedItem;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                student.FormOB = (FormOB)comboBox1.SelectedItem;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            student.Datarod = dateTimePicker1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            student.Mathematics=numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            student.Russian=numericUpDown2.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            student.informatics=numericUpDown4.Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
