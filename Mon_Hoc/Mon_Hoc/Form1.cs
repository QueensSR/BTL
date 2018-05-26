using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mon_Hoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn Lưu không?", "Lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
