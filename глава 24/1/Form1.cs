using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    Form2 newChild = new Form2();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " ";
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;
                case "Title":
                    this.LayoutMdi
                    (System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is cascade";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is horizontal";
        }
    }
}
