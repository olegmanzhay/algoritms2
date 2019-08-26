using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void txtOldMassive_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            int countElement = int.Parse(txtCountElement.Text);
            int firstElement = int.Parse(txtStart.Text);
            int lastElement = int.Parse(txtFinish.Text);
            int countOperation;

            Sort A = new Sort(countElement,firstElement,lastElement);
            txtOldMassive.Text = A.PrintMassive(A);
            txtNewMassive.Text = A.SortBubble(A, out countOperation);
            txtCountOperation.Text = countOperation.ToString();

        }

        private void btnSuperBubble_Click(object sender, EventArgs e)
        {
            int countElement = int.Parse(txtCountElement.Text);
            int firstElement = int.Parse(txtStart.Text);
            int lastElement = int.Parse(txtFinish.Text);
            int countOperation;

            Sort A = new Sort(countElement, firstElement, lastElement);
            txtOldMassive.Text = A.PrintMassive(A);
            txtNewMassive.Text = A.SuperSortBubble(A, out countOperation);
            txtCountOperation.Text = countOperation.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countElement = int.Parse(txtCountElement.Text);
            int firstElement = int.Parse(txtStart.Text);
            int lastElement = int.Parse(txtFinish.Text);
            int countOperation;

            Sort A = new Sort(countElement, firstElement, lastElement);
            txtOldMassive.Text = A.PrintMassive(A);
            txtNewMassive.Text = A.ShakerSort(A, out countOperation);
            txtCountOperation.Text = countOperation.ToString();
        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            int countElement = int.Parse(txtCountElement.Text);
            int firstElement = int.Parse(txtStart.Text);
            int lastElement = int.Parse(txtFinish.Text);
            int countOperation;

            Sort A = new Sort(countElement, firstElement, lastElement);
            txtOldMassive.Text = A.PrintMassive(A);
            txtNewMassive.Text = A.ShakerSort(A, out countOperation);
            A.Element = int.Parse(txtElement.Text);
            txtBinarySearch.Text = A.BinarySearch(A).ToString();

        }
    }
}
