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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nian = this.comboBox1.Text;
            string sex = this.comboBox2.Text;
            string sql = string.Format("select nameID,name,sex,nian,Addi from tb_bj where nian = '{0}' and sex = '{1}'",nian,sex);
            DataTable dt = DBHelper.Fin(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "性别";
            dataGridView1.Columns[3].HeaderText = "年级";
            dataGridView1.Columns[4].HeaderText = "电话";
        }
    }
}
