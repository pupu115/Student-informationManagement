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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nid = this.textBox1.Text;
            string name = this.textBox4.Text;
            string sex = radioButton1.Checked ? "女" : "男";
            string nian = this.comboBox1.Text;
            string dian = this.textBox5.Text;
            string dizhi = this.textBox6.Text;
            DateTime chu =  DateTime.Now;
            string Email = this.textBox7.Text;
            string sql = string.Format("insert into tb_bj(nameID,name,sex,nian,Addi,dizhi,chu,Email)  values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",nid, name, sex, nian, dian, dizhi, chu, Email);
            bool a = DBHelper.Eex(sql);
            if (a)
            {
                if (nid == "" || name == "" || sex == "" || nian == "" || dian == "" || dizhi == "" || Email == "")
                {
                    MessageBox.Show("添加失败请重试！");
                }
                else {
                    MessageBox.Show("添加成功");
                    Close();
                }
                
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nid = this.textBox1.Text="";
            string name = this.textBox4.Text="";
            string sex = radioButton1.Checked ? "True" : "False";
            string nian = this.comboBox1.Text;
            string dian = this.textBox5.Text = "";
            string dizhi = this.textBox6.Text = "";
            DateTime chu = DateTime.Now;
            string Email = this.textBox7.Text ="";
        }
    }
}
