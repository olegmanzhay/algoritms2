//Ввести возраст человека(от 1 до 150 лет) и вывести его вместе со словом «год», «года» или «лет».
// Манжай Олег
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework6
{
    public partial class Homework6 : Form
    {
        public Homework6()
        {
            InitializeComponent();
        }
 
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            HumanAge humanAge = new HumanAge();
            humanAge.Age = int.Parse(txtAge.Text);
            if (humanAge.Age > 0 && humanAge.Age <= 150)
                lblAgeString.Text = humanAge.AgeString(humanAge);
            else
                lblAgeString.Text = "Только до 150";
        }
    }
}
