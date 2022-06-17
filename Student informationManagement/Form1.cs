using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_informationManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            string pwd = this.textBox2.Text;
            string lei = this.comboBox1.Text;
            string sql;
            sql = string.Format("select * from xuesheng where name ='{0}' and pwd ='{1}' and leixing = '{2}'", name, pwd,lei);
            DataTable dt = DBHelper.Fin(sql);
            
                 if (dt.Rows.Count > 0)
                {
                if (lei == "管理用户")
                {

                    MessageBox.Show("登陆成功");
                    Hide();
                    Form4 fom4 = new Form4();
                    fom4.Show();
                }
                else {
                    MessageBox.Show("登陆成功");
                    Hide();
                    Form3 fom3 = new Form3();   
                    fom3.Show();    
                }
                    
                }
                else
                {
                    MessageBox.Show("登录失败，信息有误");
                }
            
                

           
            
            
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 form8 = new Form8();
            form8 .ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            
        }
    }
}
