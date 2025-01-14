namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            DisplayNumber(num);
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

        private void Operator_Click(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            DisplayOperator(op);
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

        private void Equal_Click(object sender, EventArgs e)
        {
            DoComputation();
        }

        public void DoComputation()
        {
            string[] operators = wordToOp.Values.ToArray();
            string[] numInFormula = DisplayResult.Text.Split(operators, StringSplitOptions.None);
            double result = double.Parse(numInFormula[0]);

            foreach (string op in operators)
            {
                while (DisplayResult.Text.Contains(op))
                {
                    for (int j = 1; j < numInFormula.Length; j++)
                    {
                        switch (op)
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
                    if (DisplayResult.Text == "¡Û")
                    {
                        DisplayResult.Text = "E";
                    }
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DisplayResult.Text = null;
        }
    }
}
