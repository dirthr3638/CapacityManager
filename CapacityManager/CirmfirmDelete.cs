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
    public partial class CirmfirmDelete : Form
    {
        public CirmfirmDelete(int count)
        {
            InitializeComponent();
            DetailLable.Text = string.Format("선택하신 {0}개의 파일이 완전히 삭제됩니다.", count);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
