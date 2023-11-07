using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aragoza_MyFirstApp
{
    public partial class DisplayInfo : MetroFramework.Forms.MetroForm
    {
        public DisplayInfo()
        {
            InitializeComponent();
        }

        private void DisplayInfo_Load(object sender, EventArgs e)
        {
            lbl_FName.Text = StudentModel.FullName;
            lbl_Gender.Text = StudentModel.Gender;
            lbl_Date.Text = StudentModel.DateOfBirth;
            lbl_contact.Text = StudentModel.ContactNumber;
            lbl_email.Text = StudentModel.Email;
            lbl_studnum.Text = StudentModel.StudentNumber;
            lbl_course.Text = StudentModel.Course;
            lbl_yeargrad.Text = StudentModel.YearGraduated;
            lbl_semestergrad.Text = StudentModel.SemesterGraduated;
        }
    }
}
