/*
 * Автоморфные числа. Натуральное число называется автоморфным, если оно равно последним цифрам своего квадрата.
 * Например, 25 \ :sup: '2' = 625. Напишите программу, которая получает на вход натуральное число N и выводит на экран 
 * все автоморфные числа, не превосходящие N.
 Манжай Олег
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Numbers nmb = new Numbers();
            nmb.Number = int.Parse(txtNumber.Text);
            txtResult.Text = nmb.resultNumbers(nmb);
        }
    }
}
