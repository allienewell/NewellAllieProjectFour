using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewellAllieFinalProject
{
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coursesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coursesDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.coursesDataSet.Courses);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Closes courses form
            this.Close();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {

            try
            {
                if (IsValidData())
                {
                    // Saves the values from the five user inputs to the SetCourses Class (First Custom Class)
                    SetCourses.setNumberOfCourses(txtNoCourses.Text);
                    SetCourses.setName(txtStudentName.Text);
                    SetCourses.setDate(startDateCalendar.SelectionStart.ToShortDateString());
                    SetCourses.setCourseNo(cboCourseNo.Text);
                    if (rdoHybrid.Checked)
                        SetCourses.setCourseType(rdoHybrid.Text);
                    else
                        SetCourses.setCourseType(rdoOnline.Text);
                }
            }

            // Checks for valid data, if data is not present or not valid, an error message box will appear
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/n/n" +
                    ex.GetType().ToString() + "/n" +
                    ex.StackTrace, "Exception");
            }

            bool IsValidData()
            {
                return
                    IsPresent(txtNoCourses, "Number of Courses") &&
                    IsInt32(txtNoCourses, "Number of Courses") &&
                    IsWithinRange(txtNoCourses, "Number of Courses", 1, 5) &&

                    IsPresent(txtStudentName, "Student Name");
            }

            // Verifies the user entered data in the first two text boxes
            bool IsPresent(TextBox textBox, string name)
            {
                if (textBox.Text == "")
                {
                    MessageBox.Show(name + " is a required field.", "Entry Error");
                    textBox.Focus();
                    return false;
                }
                return true;
            }

            // Verifies the Number of Courses user input is a valid integer
            bool IsInt32(TextBox textBox, string name)
            {
                int number = 0;
                if (Int32.TryParse(textBox.Text, out number))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(name + " must be an integer.", "Entry Error");
                    textBox.Focus();
                    return false;
                }
            }

            //Verifies the Number of Courses user input is between 1 and 5
            bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
            {
                decimal number = Convert.ToDecimal(textBox.Text);
                if (number < min || number > max)
                {
                    MessageBox.Show(name + " must be between " + min + " and " + max
                        + ". Student must have administrative permission to take more than five classes.",
                        "Entry Error");
                    textBox.Focus();
                    return false;
                }
                return true;
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // Retrieves data that was sent to GetCourses class (Second Custom Class)
            int noCourses2 = Convert.ToInt32(GetCourses.getNumberOfCourses2());
            string studentName2 = GetCourses.getName2();
            string startDate2 = GetCourses.getDate2();
            string courseNo2 = GetCourses.getCourseNo2();
            string courseType2 = GetCourses.getCourseType2();

            // Writes data from GetCourses class to readonly text boxes on right
            txtNoCourses2.Text = Convert.ToString(noCourses2);
            txtStudentName2.Text = studentName2;
            txtStartDate.Text = startDate2;
            txtCourseNo.Text = courseNo2;
            txtCourseType.Text = courseType2;
        }
    }
}
