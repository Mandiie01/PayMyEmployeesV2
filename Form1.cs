using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayMyEmployeesV2
{
    public partial class Form1 : Form
    {
        double rate;
        int hours;
        double result;
        double pension;
        double medicalaid;
        double uif;
        double calc;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            txtRPH.Clear();
            txtWHours.Clear();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            rate = double.Parse(txtRPH.Text);
            hours = int.Parse(txtWHours.Text);

            lstResult.Items.Add("Rate Per Hour: R" + rate);
            lstResult.Items.Add("Work Hour/s: R" + hours);
            result = rate * hours; //takes the amount of hours worked and multiplies it by the rate
            lstResult.Items.Add("Gross Salary: R" + result);
            lstResult.Items.Add("  ");
            lstResult.Items.Add("Deductions ");
            pension = result * 0.05;
            lstResult.Items.Add("Pension: R" + pension);
            medicalaid = result * 0.06;
            lstResult.Items.Add("Medical Aid: R" + medicalaid);
            uif = result * 0.04;
            lstResult.Items.Add("Unemployment Insurance Fund: R" + uif);
            calc = result-(uif + medicalaid + pension);
            lstResult.Items.Add("Total salary after deduction: " + calc);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
