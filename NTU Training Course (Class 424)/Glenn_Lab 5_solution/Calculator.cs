namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            DisplayNumber(zero);
        }

        private void One_Click(object sender, EventArgs e)
        {
            DisplayNumber(one);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            DisplayNumber(two);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            DisplayNumber(three);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            DisplayNumber(four);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            DisplayNumber(five);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            DisplayNumber(six);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            DisplayNumber(seven);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            DisplayNumber(eight);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            DisplayNumber(nine);
        }

        private Dictionary<string, string> wordToNum = new Dictionary<string, string>
        {
            {"zero", "0"}, {"one", "1"}, {"two", "2"}, {"three", "3"}, {"four", "4"}, {"five", "5"}, {"six", "6"}, {"seven", "7"}, {"eight", "8"}, {"nine", "9"}
        };

        public void DisplayNumber(Button button)
        {
            DisplayResult.Text += wordToNum[button.Name];

            if (DisplayResult.Text.StartsWith('0'))
            {
                DisplayResult.Text = wordToNum[button.Name];
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            DisplayOperator(plus);

        }

        private void Minus_Click(object sender, EventArgs e)
        {
            DisplayOperator(minus);
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            DisplayOperator(multiply);
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            DisplayOperator(divide);
        }

        private Dictionary<string, string> wordToOp = new Dictionary<string, string>
        {
            {"plus", " + "}, {"minus", " - "}, {"multiply", " * "}, {"divide", " / "}
        };

        public void DisplayOperator(Button button)
        {
            if (DisplayResult.Text.EndsWith(' '))
            {
                DisplayResult.Text = DisplayResult.Text.Substring(0, DisplayResult.Text.LastIndexOf(' ') - 2) + wordToOp[button.Name];
            }
            else
            {
                DisplayResult.Text += wordToOp[button.Name];
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            DoComputation();
        }

        public void DoComputation()
        {
            string[] operators = wordToOp.Values.ToArray();
            string[] numInFormula = DisplayResult.Text.Split(operators, StringSplitOptions.None);
            double result = double.Parse(numInFormula[0]);

            for (int i = 0; i < operators.Length; i++)
            {
                while (DisplayResult.Text.Contains(operators[i]))
                {
                    for (int j = 1; j < numInFormula.Length; j++)
                    {
                        switch (operators[i])
                        {
                            case " + ":
                                result += double.Parse(numInFormula[j]);
                                break;
                            case " - ":
                                result -= double.Parse(numInFormula[j]);
                                break;
                            case " * ":
                                result *= double.Parse(numInFormula[j]);
                                break;
                            case " / ":
                                result /= double.Parse(numInFormula[j]);
                                break;
                        }
                    }

                    DisplayResult.Text = result.ToString();
                    if (DisplayResult.Text == "∞")
                    {
                        DisplayResult.Text = "E";
                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            DisplayResult.Text = null;
        }
    }
}
