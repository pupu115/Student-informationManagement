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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 窗口WToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void 水平平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           Form9 form9 = new Form9();
            form9.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.ShowDialog();
            
        }
    }
}
