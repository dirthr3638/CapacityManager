using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapacityManager
{
    public partial class InputWindows : Form
    {
        public string Ext;

        public InputWindows()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
         }

        private void button1_Click(object sender, EventArgs e)
        {
            Ext = ExtTextBox.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
