using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentForm;

namespace StudentFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Figure out major
            string major = "TBD";
            if (rbtnProgramming.Checked)
            {
                major = rbtnProgramming.Text;
            }
            else if (rbtnWebDesign.Checked)
            {
                major = rbtnWebDesign.Text;
            }
            else if (rbtnIT.Checked)
            {
                major = rbtnIT.Text;
            }

            //Instantiate a student
            Student st = new Student(txtStudentID.Text,
                                     txtFirstName.Text,
                                     txtLastName.Text,
                                     major);
            st.StudentNumber = txtStudentID.Text;

            //Count number of check boxes checked
            int count = 0;
            if (cboxCIS101.Checked)
            {
                count++;
            }
            if (cboxCIS102.Checked)
            {
                count++;
            }
            if (cboxCIS103.Checked)
            {
                count++;
            }
            if (cboxCIS104.Checked)
            {
                count++;
            }

            string[] courses = new string[count];
            int[] scores = new int[count];

            int index = 0;
            if (cboxCIS101.Checked)
            {
                courses[index] = cboxCIS101.Text;
                scores[index++] = Convert.ToInt32(txtScore1.Text);
            }
            if (cboxCIS102.Checked)
            {
                courses[index] = cboxCIS102.Text;
                scores[index++] = Convert.ToInt32(txtScore2.Text);
            }
            if (cboxCIS103.Checked)
            {
                courses[index] = cboxCIS103.Text;
                scores[index++] = Convert.ToInt32(txtScore3.Text);
            }
            if (cboxCIS104.Checked)
            {
                courses[index] = cboxCIS104.Text;
                scores[index++] = Convert.ToInt32(txtScore4.Text);
            }

            //Set new arrays into student object
            st.Scores = scores;
            st.Courses = courses;

            //display output

            string summary =
                "Student's Major is " + st.Major +
                "\nStudent's First Name is " + st.FirstName +
                "\nStudent's Last Name is" + st.LastName +
                "\nStudent's Average is " + st.Average +
                "\nCourses: ";
            foreach (string course in courses)
            {
                summary += "\n" + st.Courses;
            }
            txtResult.Text = summary;
        }
    }
}
