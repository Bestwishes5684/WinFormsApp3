using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using UserStrory.Models;



namespace WinFormsApp3
{
    public partial class Form1 : Form

    {
        int age = 0;
        private readonly Student student;
        private readonly List<Student> Students;
        private readonly BindingSource bindingSource;
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            Students = new List<Student>();
            bindingSource = new BindingSource();
            bindingSource.DataSource = Students;
            dataGridView1.DataSource = bindingSource;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stdInfoForm = new Form2();
            if (stdInfoForm.ShowDialog(this) == DialogResult.OK)
            {
                stdInfoForm.Student.Id = Guid.NewGuid();
                Students.Add(stdInfoForm.Student);
                bindingSource.ResetBindings(false);
            }
        }
    }
}