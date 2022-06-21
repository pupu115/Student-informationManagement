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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            string kemu = this.comboBox1.Text;
            string chengji = this.textBox2.Text;
            DateTime shijian = DateTime.Now;
            string sql =string.Format( "insert into tb_cj(name,kemu,chengji,shijian)  values('{0}','{1}','{2}','{3}');",name,kemu,chengji,shijian);
             bool a = DBHelper.Eex(sql);
            

            if (a) {
                if (kemu == "" || chengji == "")
                {
                    MessageBox.Show("科目和成绩不能为空！");
                }
                else
                {
                    MessageBox.Show("添加成功！");
                    name = this.textBox1.Text = "";
                    kemu = this.comboBox1.Text = ""; 
                    chengji = this.textBox2.Text = "";
                }
                
            }
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string Sql = "select * from tb_cj";
            DataTable dt = DBHelper.Fin(Sql);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "姓名";
            dataGridView1.Columns[1].HeaderText = "科目名称";
            dataGridView1.Columns[2].HeaderText = "成绩";
            dataGridView1.Columns[3].HeaderText = "考试时间";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
