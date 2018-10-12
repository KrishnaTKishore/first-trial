
using System;
using System.Windows.Forms;

namespace first_trial
{
    public partial class EdTech : Form
    {
        public EdTech()
        {
            InitializeComponent();
        }

        /*private void Login_Click(object sender, EventArgs e)
        {
            if(Admin.Checked == true)
            {
                if(Username.Text=="kriz"&&Password.Text=="1234")
                {
                    MessageBox.Show("You are successfully logged in as an admin");
                }
                else
                {
                    MessageBox.Show("Sorry there seems to be a problem with your login credentials ");
                }
                Username.Clear();
                Password.Clear();
                Admin.Checked = false;
            }
            else if (Faculty.Checked == true)
            {
                if (Username.Text=="Shankar" && Password.Text=="123")
                {
                    MessageBox.Show("You are successfully logged in as a faculty");
                }
                else
                {
                    MessageBox.Show("Sorry there seems to be a problem with your login credentials ");
                }
                Username.Clear();
                Password.Clear();
                Faculty.Checked = false;
            }
            else if (Student.Checked == true)
            {
                if (Username.Text=="neha" && Password.Text=="123%")
                {
                    MessageBox.Show("You are successfully logged in as a student");
                }
                else
                {
                    MessageBox.Show("Sorry there seems to be a problem with your login credentials ");
                }
                Username.Clear();
                Password.Clear();
                Student.Checked = false;
            }
            else
            {
                MessageBox.Show("Select a valid type");
            }
        }*/

        private void add_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            x = Convert.ToInt32(num1.Text);

            y = Convert.ToInt32(num2.Text);
            int z = x + y;
            result.Text = Convert.ToString(z);

        }
    }
}

     
    
