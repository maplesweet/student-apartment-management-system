using System;
using System.Data;
using System.Windows.Forms;


namespace SAMS
{
    public partial class Log_in_ : Form
    {
        public Log_in_()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text!="")  //输入信息不为空
            {
                login();    //登录
            }
            else
            {
                MessageBox.Show("输入有空值，请重新输入");
            }
        }
        public Boolean login()  //登录操作
        {
            DatabaseConnect connect = new DatabaseConnect();
            IDataReader reader;
            string sql;

            if (radioButton1.Checked == true)
            {
                sql = "select * from name where id='" + textBox1.Text + "'and psw='" + textBox2.Text + "'";
                Data.Status = false;
            }
            else
            {
                sql = "select * from name where id='" + textBox1.Text + "'and psw='" + textBox2.Text + "'";
                Data.Status = true;
            }
            //确认账号密码
            reader = connect.read(sql);
            if (reader.Read())
            {
                if(Data.Status == false)
                {
                    Student_ student = new Student_();
                    this.Hide();
                    student.ShowDialog();
                    this.Show();
                }
                else
                {
                    Admin_ admin = new Admin_();
                    this.Hide();
                    admin.ShowDialog();
                    this.Show();
                }
                
                return true;
            }
            else
            {
                MessageBox.Show("账号或密码错误！登陆失败！");
                return false;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
