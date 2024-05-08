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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*

        REMEMBER TO UPDATE THE HIDE OR SHOW FRO PREVIOUS PAGES LEST THEY COVER EACH OTHER 



        NOTE THESE ARE USED FOR SWITCHING BETWEEN PAGES


        private void button3_Click(object sender, EventArgs e)
        {
            dashboard11.Show();
            dashboard11.BringToFront();
            account11.Hide();
            studentAdmitForm11.Hide();
            studentDetails11.Hide();
        }




*/
        private void button3_Click(object sender, EventArgs e)
        {
            dashboard11.Show();
            dashboard11.BringToFront();
            account11.Hide();
            studentAdmitForm11.Hide();
            studentDetails11.Hide();
            message11.Hide();
            subject11.Hide();
            attendance11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }

        private void account11_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            account11.Show();
            account11.BringToFront();
            dashboard11.Hide();
            studentAdmitForm11.Hide();
            studentDetails11.Hide();
            message11.Hide();
            subject11.Hide();
            attendance11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentDetails11.Show();
            studentDetails11.BringToFront();
            dashboard11.Hide();
            account11.Hide();
            studentAdmitForm11.Hide();
            message11.Hide();
            subject11.Hide();
            attendance11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            studentAdmitForm11.Show();
            studentAdmitForm11.BringToFront();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            message11.Hide();
            subject11.Hide();
            attendance11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            message11.Show();
            message11.BringToFront();
            studentAdmitForm11.Hide();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            subject11.Hide();
            attendance11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            subject11.Show();
            subject11.BringToFront();
            message11.Hide();
            studentAdmitForm11.Hide();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            attendance11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            attendance11.Show();
            attendance11.BringToFront();
            message11.Hide();
            studentAdmitForm11.Hide();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            subject11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            notice11.Show();
            notice11.BringToFront();
            message11.Hide();
            studentAdmitForm11.Hide();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            subject11.Hide();
            attendance11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            teachers11.Show();
            teachers11.BringToFront();
            message11.Hide();
            studentAdmitForm11.Hide();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            subject11.Hide();
            attendance11.Hide();
            notice11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            hostel11.Show();
            hostel11.BringToFront();
            message11.Hide();
            studentAdmitForm11.Hide();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            subject11.Hide();
            attendance11.Hide();
            notice11.Hide();
            teachers11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            transport11.Show();
            transport11.BringToFront();
            message11.Hide();
            studentAdmitForm11.Hide();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            subject11.Hide();
            attendance11.Hide();
            notice11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            examsMain11.Show();
            examsMain11.BringToFront();
            message11.Hide();
            studentAdmitForm11.Hide();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            subject11.Hide();
            attendance11.Hide();
            notice11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            parentsDashboard11.Show();
            parentsDashboard11.BringToFront();
            message11.Hide();
            studentAdmitForm11.Hide();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            subject11.Hide();
            attendance11.Hide();
            notice11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            libraryMain11.Show();
            libraryMain11.BringToFront();
            message11.Hide();
            studentAdmitForm11.Hide();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            subject11.Hide();
            attendance11.Hide();
            notice11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            classMain11.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            classMain11.Show();
            classMain11.BringToFront();
            message11.Hide();
            studentAdmitForm11.Hide();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            subject11.Hide();
            attendance11.Hide();
            notice11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dashboard11.Show();
            dashboard11.BringToFront();
            account11.Hide();
            studentAdmitForm11.Hide();
            studentDetails11.Hide();
            message11.Hide();
            subject11.Hide();
            attendance11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            message11.Show();
            message11.BringToFront();
            studentAdmitForm11.Hide();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            subject11.Hide();
            attendance11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            notice11.Show();
            notice11.BringToFront();
            message11.Hide();
            studentAdmitForm11.Hide();
            dashboard11.Hide();
            account11.Hide();
            studentDetails11.Hide();
            subject11.Hide();
            attendance11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            dashboard11.Show();
            dashboard11.BringToFront();
            account11.Hide();
            studentAdmitForm11.Hide();
            studentDetails11.Hide();
            message11.Hide();
            subject11.Hide();
            attendance11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            dashboard11.Show();
            dashboard11.BringToFront();
            account11.Hide();
            studentAdmitForm11.Hide();
            studentDetails11.Hide();
            message11.Hide();
            subject11.Hide();
            attendance11.Hide();
            teachers11.Hide();
            hostel11.Hide();
            transport11.Hide();
            examsMain11.Hide();
            parentsDashboard11.Hide();
            libraryMain11.Hide();
            classMain11.Hide();
        }
    }
}
