using System.Collections;
using System.Net;

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {
        DelegateNumber delegateNumber;
        DelegateText delegateText;

        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = FirstName.Text.ToString();
            StudentInfoClass.LastName = LastName.Text.ToString();
            StudentInfoClass.MiddleName = MiddleName.Text.ToString();
            StudentInfoClass.Address = Add.Text.ToString();
            StudentInfoClass.Program = comboBox1.Text.ToString();
            StudentInfoClass.Age = long.Parse(Age.Text.ToString());
            StudentInfoClass.ContactNo = long.Parse(ContactNo.Text.ToString());
            StudentInfoClass.StudentNo = long.Parse(StudNo.Text.ToString());

            FrmConfirm frmConfirm = new FrmConfirm();
            DialogResult result = frmConfirm.ShowDialog();
            //frmConfirm.ShowDialog();

            if (result == DialogResult.OK)
            {
                FirstName.Clear();
                LastName.Clear();
                MiddleName.Clear();
                Add.Clear();
                Age.Clear();
                StudNo.Clear();
                ContactNo.Clear();
                comboBox1.SelectedIndex = -1;
            }

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void ContactNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}