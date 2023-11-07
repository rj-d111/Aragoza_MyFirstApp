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
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                //Satisfied Condition
                MessageBox.Show("Successfully registered!");

                StudentModel.FullName = txt_FName.Text;
                StudentModel.Gender = cmb_Gender.Text;
                StudentModel.DateOfBirth = DateOfBirth.Text;
                StudentModel.ContactNumber = txt_contact.Text;
                StudentModel.Email = txt_email.Text;
                StudentModel.Password = txt_pass.Text;
                StudentModel.StudentNumber = txt_studnum.Text;
                StudentModel.Course = cmb_course.Text;
                StudentModel.YearGraduated = cmb_year.Text;
                StudentModel.SemesterGraduated = cmb_semester.Text;

                DisplayInfo displayInfo = new DisplayInfo();
                displayInfo.Show();
                this.Hide();


            }
            else
            {
                //Not Satisfied condition
                MessageBox.Show("Invalid! Please fill out all the required fields and check your confirmed password and try again.");
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txt_FName.Text)) return false;
            if(string.IsNullOrEmpty(cmb_Gender.Text)) return false;
            if(string.IsNullOrEmpty(txt_contact.Text)) return false;
            if(string.IsNullOrEmpty(txt_email.Text)) return false;
            if(string.IsNullOrEmpty(txt_pass.Text)) return false;
            if (txt_pass.Text != txt_pass2.Text) return false;
            if(string.IsNullOrEmpty(txt_studnum.Text)) return false;
            if(string.IsNullOrEmpty(cmb_course.Text)) return false;
            if(string.IsNullOrEmpty(cmb_year.Text)) return false;
            if(string.IsNullOrEmpty(cmb_semester.Text)) return false;

            return true;
        }
    }
}
