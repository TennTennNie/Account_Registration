using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgam, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();

            DelProgam = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            labelStudNo.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            labelProg.Text = DelProgam(StudentInfoClass.Program).ToString();
            labelLastName.Text = DelLastName(StudentInfoClass.LastName).ToString();
            labelFirstName.Text = DelFirstName(StudentInfoClass.FirstName).ToString();
            labelMiddle.Text = DelMiddleName(StudentInfoClass.MiddleName).ToString();
            labelAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            labelContact.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            labelAdd.Text = DelAddress(StudentInfoClass.Address).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
