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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nian = this.comboBox1.Text;
            string sql = string.Format("select * from tb_bj  where nian = '{0}'", nian);
            DataTable cha =  DBHelper.Fin(sql);
            dataGridView1.DataSource = cha;
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "性别";
            dataGridView1.Columns[3].HeaderText = "年级";
            dataGridView1.Columns[4].HeaderText = "电话";
            dataGridView1.Columns[5].HeaderText = "地址";
            dataGridView1.Columns[6].HeaderText = "出生日期";
            dataGridView1.Columns[7].HeaderText = "邮箱";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
