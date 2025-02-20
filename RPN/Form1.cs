using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RPN
{
    public partial class Form1 : Form
    {

        private IStack<double> stack;
        private PolishNotationCalculator calculator;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Eval_Click(object sender, EventArgs e)
        {
            // Read and Parse Expression here... 
            try
            {
                string input = Txt_Input.Text.Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Please enter a valid RPN expression.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure input has at least one space (to separate numbers/operators)
                if (!input.Contains(" "))
                {
                    MessageBox.Show("Invalid input format! Make sure to put spaces between numbers and operators.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create the calculator with ArrayStack
                PolishNotationCalculator calculator = new PolishNotationCalculator(new ArrayStack<double>());
                double result = calculator.Evaluate(input);

                // Show result
                MessageBox.Show($"Result: {result}", "RPN Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
