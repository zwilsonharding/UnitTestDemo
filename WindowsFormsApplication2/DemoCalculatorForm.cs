using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTestDemoApp
{
    public partial class DemoCalculatorForm : Form
    {
        #region Constructor

        public DemoCalculatorForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Button Click Events

        private void addButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = CalculatorLogic.add(numericUpDown1.Value, numericUpDown2.Value).ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = CalculatorLogic.subtract(numericUpDown1.Value, numericUpDown2.Value).ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = CalculatorLogic.multiply(numericUpDown1.Value, numericUpDown2.Value).ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = CalculatorLogic.divide(numericUpDown1.Value, numericUpDown2.Value).ToString();
        }

        private void moduloButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = CalculatorLogic.modulo(numericUpDown2.Value, numericUpDown1.Value).ToString();
        }

        #endregion
    }
}
