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
    public partial class teachers1 : UserControl
    {
        public teachers1()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            allTeachers11.Show();
            allTeachers11.BringToFront();
            teacherDetails11.Hide();
            addTeacher11.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacherDetails11.Show();
            teacherDetails11.BringToFront();
            allTeachers11.Hide();
            addTeacher11.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addTeacher11.Show();
            addTeacher11.BringToFront();
            teacherDetails11.Hide();
            allTeachers11.Hide();
            
        }

        private void allTeachers11_Load(object sender, EventArgs e)
        {

        }

        private void teachers1_Load(object sender, EventArgs e)
        {

        }
    }
}
