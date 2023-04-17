using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShaimurzinSQLApp
{
    public partial class GlavnayaForma : Form
    {
        public GlavnayaForma()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm Form = new AdminForm();
            Form.Show();
        }
    }
}
