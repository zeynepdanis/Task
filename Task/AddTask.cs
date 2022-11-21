using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class AddTask : Form
    {

        ShowTask fgrid;
        public AddTask(ShowTask fgrid)
        {
            InitializeComponent();
            this.fgrid = fgrid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
           string progress=comboBox1.GetItemText(comboBox1.SelectedIndex);
            if (progress == "0")
            {
                progress = "Progress";
            }
            else if(progress == "1")
            {
                progress = "Done";
            }

            fgrid.dgwShowTask.Rows.Add(richTextBox1.Text,progress,now.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
