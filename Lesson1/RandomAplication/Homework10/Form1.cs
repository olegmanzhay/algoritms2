using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework10
{
    public partial class Homework10 : Form
    {
        public Homework10()
        {
            InitializeComponent();
        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            try
            {
                Number nmb = new Number();
                nmb.MyNumber = int.Parse(txtNumber.Text);
                //MessageBox.Show = nmb.TrueOrFalse(nmb).ToString();
                lblTrueOrFalse.Text = nmb.TrueOrFalse(nmb).ToString();
            }
            catch
            {
                txtNumber.Text = "Введите число";
            }

        }
    }
}
