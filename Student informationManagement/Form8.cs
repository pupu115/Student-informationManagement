using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_informationManagement
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //声明变量
            string name = this.textBox1.Text;
            string pwd = this.textBox2.Text;
            string lei = this.comboBox1.Text;
            //判断用户输入是否为空 不为空则执行操作语句
            if (name == "" || pwd == "" || lei == "")
            {
                MessageBox.Show("用户名、密码、登录类型必须输入");
            }
            else {
                string sql = string.Format("insert into xuesheng(name,pwd,leixing) values('{0}','{1}','{2}')",name,pwd,lei);
                bool a = DBHelper.Eex(sql);
                //判断 a的返回值是否为true 是则添加成功 否则添加失败
                if (a)
                {
                    MessageBox.Show("添加成功");
                    Close();
                }
                
                else {
                    MessageBox.Show("添加失败");
                }
            }
        }
    }
}
