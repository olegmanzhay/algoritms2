/*
* Написать функцию, генерирующую случайное число от 1 до 100: 
a. С использованием стандартной функции rand().
b. Без использования стандартной функции rand().
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


namespace RandomAplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            RandomNumbers Nmb1 = new RandomNumbers();
            Number1.Text = Nmb1.RandomNumber1(Nmb1).ToString();
            Number2.Text = Nmb1.RandomNumber2(Nmb1).ToString();



        }
    }
}
