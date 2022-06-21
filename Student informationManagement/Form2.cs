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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nameID = this.textBox1.Text;
           string sql =string.Format( "select b.name,kemu,chengji from tb_bj a join tb_cj  b on a.name = b.name where a.nameID = '{0}'",nameID);
            DataTable dt = DBHelper.Fin(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "姓名";
            dataGridView1.Columns[1].HeaderText = "科目";
            dataGridView1.Columns[2].HeaderText = "成绩";

        }
    }
}
