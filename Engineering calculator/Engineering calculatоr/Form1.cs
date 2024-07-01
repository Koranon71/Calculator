using System;
using System.Windows.Forms;

namespace Engineering_calculatоr
{
    public partial class Calculator : Form
    {
        // Переменные для хранения текущего операнда и операции
        private double currentNumber = 0;
        private string currentOperation = "";
        private bool isNewNumber = true;

        public Calculator()
        {
            InitializeComponent();
        }

        // Метод для обработки нажатия на цифровую кнопку
        private void NumberButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (isNewNumber)
            {
                textBox_Result.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                if (textBox_Result.Text == "0")
                    textBox_Result.Text = button.Text;
                else
                    textBox_Result.Text += button.Text;
            }
        }

        // Метод для обработки нажатия на кнопку операции (+, -, *, /)
        private void OperationButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentOperation = button.Text;
            currentNumber = double.Parse(textBox_Result.Text);
            isNewNumber = true;
        }

        // Метод для обработки нажатия на кнопку равно
        private void EqualsButtonClick(object sender, EventArgs e)
        {
            double newNumber = double.Parse(textBox_Result.Text);
            switch (currentOperation)
            {
                case "+":
                    textBox_Result.Text = (currentNumber + newNumber).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (currentNumber - newNumber).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (currentNumber * newNumber).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (currentNumber / newNumber).ToString();
                    break;
                default:
                    break;
            }
            isNewNumber = true;
        }

        // Метод для очистки текущего ввода
        private void ClearButtonClick(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            currentNumber = 0;
            currentOperation = "";
            isNewNumber = true;
        }
    }
}