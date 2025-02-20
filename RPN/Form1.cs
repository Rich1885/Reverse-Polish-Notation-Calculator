using System;
using System.Windows.Forms;

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
                
                ArrayStack<int> intStack = new ArrayStack<int>(5);
                intStack.Push(10);
                intStack.Push(20);
                intStack.Push(30);

                string message = "Testing ArrayStack<T>\n";
                message += $"Peek: {intStack.Peek()}\n"; 
                message += $"Pop: {intStack.Pop()}\n";  
                message += $"Pop: {intStack.Pop()}\n";  
                message += $"Is Empty: {intStack.IsEmpty()}\n"; 
                message += $"Pop: {intStack.Pop()}\n";  
                message += $"Is Empty: {intStack.IsEmpty()}\n"; 


                MessageBox.Show(message, "Test Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Stack Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
