using System;
using System.Windows.Forms;

namespace SAMS
{
    public partial class Sign_in_ : Form
    {
        public Sign_in_()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&&textBox2.Text!="")
            {
                login();
                   
            }
            else
            {
                MessageBox.Show("输入有空值，请重新输入");
            }
        }
        public Boolean login()
        {
            Dao dao = new Dao();
            string sql = "select * from name where id='" + textBox1.Text + "'and psw='" + textBox2.Text + "'";
            return true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
