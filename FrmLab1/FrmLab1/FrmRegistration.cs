using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLab1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormFilaName filename = new FormFilaName();
            filename.ShowDialog();

            string studentNo = studentNoTxtBox.Text;
            string fullName = lastNameTxtBox.Text + ", " + firstNameTxtBox.Text + ", " + miTxtBox.Text;
            string program = cbProgram.Text;
            string gender = cbGender.Text;
            string age = ageTxtBox.Text;
            string birthday = birthdatePicker.Text;
            string contactNo = contactTxtBox.Text;

            string[] registeredInfo = { studentNo, fullName, program, gender, age, birthday, contactNo };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter streamwriter = new StreamWriter(Path.Combine(docPath, FormFilaName.SetFileName)))
            {
                foreach (string list in registeredInfo)
                {
                    streamwriter.WriteLine(list);
                }
            }

            Close();

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
           
        }
    }
}
