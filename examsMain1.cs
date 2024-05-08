using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School001
{
    public partial class examsMain1 : UserControl
    {
        public examsMain1()
        {
            InitializeComponent();
        }

        private void addExam21_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            examsOverview11.Show();
            examsOverview11.BringToFront();
            addExamGrades21.Hide();
            addExam21.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addExam21.Show();
            addExam21.BringToFront();
            examsOverview11.Hide();
            addExamGrades21.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addExamGrades21.Show();
            addExamGrades21.BringToFront();
            examsOverview11.Hide();
            addExam21.Hide();
        }

        private void examsOverview11_Load(object sender, EventArgs e)
        {

        }
    }
}
