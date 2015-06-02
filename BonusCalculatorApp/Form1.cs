using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void caluculateButton_Click(object sender, EventArgs e)
        {
            double salary = Convert.ToDouble(salaryTextBox.Text),bonus;

            if(salary == 10000)
            {
                bonus = (salary * 5) / 100;
            }
            else
            {
                if (salary >= 8000 && salary <= 10000)
                {
                    bonus = (salary * 6) / 100;
                }
                else
                {
                    bonus = (salary * 7) / 100;
                }
            }

            bonusTextBox.Text = bonus.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            salaryTextBox.Clear();
            bonusTextBox.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
