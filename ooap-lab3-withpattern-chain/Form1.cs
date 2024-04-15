using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ooap_lab3_withpattern_chain.Form1;

namespace ooap_lab3_withpattern_chain
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = availableNotes[5000].ToString();
            textBox2.Text = availableNotes[1000].ToString();
            textBox3.Text = availableNotes[500].ToString();
            textBox4.Text = availableNotes[100].ToString();
            maxSumTextBox.Text = CountTheMaxSum().ToString();
        }
        
        int CountTheMinSum()
        {
            int MinSum = 0;
            if (availableNotes.ContainsKey(500) && availableNotes[500] > 0)
            {

            }
            return MinSum;
        }

        int CountTheMaxSum()
        {
            int sum = 0;
            foreach (var item in availableNotes)
            {
                sum += item.Key * item.Value;
            }
            return sum;
        }

        private Dictionary<int, int> availableNotes = new Dictionary<int, int>
        {
            {100, 5}, {500, 1}, {1000, 1}, {5000, 2}
        };

        private void inputNumberBox_TextChanged(object sender, EventArgs e)
        {
            if (inputNumberBox.Text.Length > 5)
            {
                inputNumberBox.Text = inputNumberBox.Text.Substring(0, 5);
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Visible = true;
            }
        }

        private void inputNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой или Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Останавливаем ввод символа
            }
        }

        public abstract class Handler
        {
            public Handler Successor;
            protected Dictionary<int, int> AvailableNotes;

            public void SetSuccessor(Handler successor)
            {
                Successor = successor;
            }

            public abstract void HandleRequest(int amount);
        }

        public class FiveThousandHandler : Handler
        {
            private TextBox getBacknoteBox;
            private TextBox textBox1;
            public FiveThousandHandler(TextBox getBacknoteBox, Dictionary<int, int> availableNotes, TextBox textBox1)
            {
                this.getBacknoteBox = getBacknoteBox;
                AvailableNotes = availableNotes;
                this.textBox1 = textBox1;
            }
            public override void HandleRequest(int amount)
            {
                if (amount >= 5000 && AvailableNotes.ContainsKey(5000) && AvailableNotes[5000] > 0)
                {
                    int count = amount / 5000;
                    int availableCount = Math.Min(count, AvailableNotes[5000]);
                    int remainder = amount - availableCount * 5000;
                    AvailableNotes[5000] = AvailableNotes[5000] - availableCount;
                    textBox1.Text = AvailableNotes[5000].ToString();
                    if (availableCount == 1 || availableCount == 101)
                    {
                        getBacknoteBox.Text += $"{availableCount} купюра по 5000{Environment.NewLine}";
                    } else if((availableCount > 1 && availableCount <= 4) || (availableCount >= 102 && availableCount <= 104))
                    {
                        getBacknoteBox.Text += $"{availableCount} купюры по 5000{Environment.NewLine}";
                    } else
                    {
                        getBacknoteBox.Text += $"{availableCount} купюр по 5000{Environment.NewLine}";
                    }
                    
                    if (remainder > 0 && Successor != null)
                    {
                        Successor.HandleRequest(remainder);
                    }
                } else if (Successor != null)
                {
                    Successor.HandleRequest(amount);
                }
                
            }
        }

        public class OneThousandHandler : Handler
        {
            private TextBox getBacknoteBox;
            private TextBox textBox2;
            public OneThousandHandler(TextBox getBacknoteBox, Dictionary<int, int> availableNotes, TextBox textBox2)
            {
                this.getBacknoteBox = getBacknoteBox;
                AvailableNotes = availableNotes;
                this.textBox2 = textBox2;
            }

            public override void HandleRequest(int amount)
            {
                if (amount >= 1000 && AvailableNotes.ContainsKey(1000) && AvailableNotes[1000] > 0)
                {
                    int count = amount / 1000;
                    int availableCount = Math.Min(count, AvailableNotes[1000]);
                    int remainder = amount - availableCount * 1000;
                    AvailableNotes[1000] = AvailableNotes[1000] - availableCount;
                    textBox2.Text = AvailableNotes[1000].ToString();
                    if (availableCount == 1 || availableCount == 101)
                    {
                        getBacknoteBox.Text += $"{availableCount} купюра по 1000{Environment.NewLine}";
                    }
                    else if ((availableCount > 1 && availableCount <= 4) || (availableCount >= 102 && availableCount <= 104))
                    {
                        getBacknoteBox.Text += $"{availableCount} купюры по 1000{Environment.NewLine}";
                    }
                    else
                    {
                        getBacknoteBox.Text += $"{availableCount} купюр по 1000{Environment.NewLine}";
                    }

                    if (remainder > 0 && Successor != null)
                    {
                        Successor.HandleRequest(remainder);
                    }
                }
                else if (Successor != null)
                {
                    Successor.HandleRequest(amount);
                }
            }
        }

        public class FiveHundredHandler : Handler
        {
            private TextBox getBacknoteBox;
            private TextBox textBox3;
            public FiveHundredHandler(TextBox getBacknoteBox, Dictionary<int, int> availableNotes, TextBox textBox3)
            {
                this.getBacknoteBox = getBacknoteBox;
                AvailableNotes = availableNotes;
                this.textBox3 = textBox3;
            }

            public override void HandleRequest(int amount)
            {
                if (amount >= 500 && AvailableNotes.ContainsKey(500) && AvailableNotes[500] > 0)
                {
                    int count = amount / 500;
                    int availableCount = Math.Min(count, AvailableNotes[500]);
                    int remainder = amount - availableCount * 500;
                    AvailableNotes[500] = AvailableNotes[500] - availableCount;
                    textBox3.Text = AvailableNotes[500].ToString();
                    if (availableCount == 1 || availableCount == 101)
                    {
                        getBacknoteBox.Text += $"{availableCount} купюра по 500{Environment.NewLine}";
                    }
                    else if ((availableCount > 1 && availableCount <= 4) || (availableCount >= 102 && availableCount <= 104))
                    {
                        getBacknoteBox.Text += $"{availableCount} купюры по 500{Environment.NewLine}";
                    }
                    else
                    {
                        getBacknoteBox.Text += $"{availableCount} купюр по 500{Environment.NewLine}";
                    }

                    if (remainder > 0 && Successor != null)
                    {
                        Successor.HandleRequest(remainder);
                    }
                }
                else if (Successor != null)
                {
                    Successor.HandleRequest(amount);
                }
            }
        }

        public class OneHundredHandler : Handler
        {
            private TextBox getBacknoteBox;
            private TextBox textBox4;
            public OneHundredHandler(TextBox getBacknoteBox, Dictionary<int, int> availableNotes, TextBox textBox4)
            {
                this.getBacknoteBox = getBacknoteBox;
                AvailableNotes = availableNotes;
                this.textBox4 = textBox4;
            }

            public override void HandleRequest(int amount)
            {
                if (amount >= 100 && AvailableNotes.ContainsKey(100) && AvailableNotes[100] > 0)
                {
                    int count = amount / 100;
                    int availableCount = Math.Min(count, AvailableNotes[100]);
                    int remainder = amount - availableCount * 100;
                    AvailableNotes[100] = AvailableNotes[100] - availableCount;
                    textBox4.Text = AvailableNotes[100].ToString();
                    if (availableCount == 1 || availableCount == 101)
                    {
                        getBacknoteBox.Text += $"{availableCount} купюра по 100{Environment.NewLine}";
                    }
                    else if ((availableCount > 1 && availableCount <= 4) || (availableCount >= 102 && availableCount <= 104))
                    {
                        getBacknoteBox.Text += $"{availableCount} купюры по 100{Environment.NewLine}";
                    }
                    else
                    {
                        getBacknoteBox.Text += $"{availableCount} купюр по 100{Environment.NewLine}";
                    }

                    if (remainder > 0 && Successor != null)
                    {
                        Successor.HandleRequest(remainder);
                    }
                }
                else if (Successor != null)
                {
                    Successor.HandleRequest(amount);
                }
            }
        }

        private void oneNumberButton_Click(object sender, EventArgs e)
        {
            inputNumberBox.Text += 1;
        }

        private void twoNumberButton_Click(object sender, EventArgs e)
        {
            inputNumberBox.Text += 2;
        }

        private void threeNumberButton_Click(object sender, EventArgs e)
        {
            inputNumberBox.Text += 3;
        }

        private void fourNumberButton_Click(object sender, EventArgs e)
        {
            inputNumberBox.Text += 4;
        }

        private void fiveNumberButton_Click(object sender, EventArgs e)
        {
            inputNumberBox.Text += 5;
        }

        private void SixNumberButton_Click(object sender, EventArgs e)
        {
            inputNumberBox.Text += 6;
        }

        private void SevenNumberButton_Click(object sender, EventArgs e)
        {
            inputNumberBox.Text += 7;
        }

        private void EightNumberButton_Click(object sender, EventArgs e)
        {
            inputNumberBox.Text += 8;
        }

        private void NineNumberButton_Click(object sender, EventArgs e)
        {
            inputNumberBox.Text += 9;
        }

        private void ZeroNumberButton_Click(object sender, EventArgs e)
        {
            inputNumberBox.Text += 0;
        }

        private void backNumberButton_Click(object sender, EventArgs e)
        {
            if (inputNumberBox.Text.Length > 0)
            {
                inputNumberBox.Text = inputNumberBox.Text.Substring(0, inputNumberBox.Text.Length - 1);
                if (inputNumberBox.Text.Length < 5)
                {
                    ErrorLabel.Visible = false;
                    SumErrorLabel.Visible = false;
                    ErrorZeroLabel.Visible = false;
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            char firstchar = inputNumberBox.Text[0];
            if (firstchar != '0')
            {
                ErrorZeroLabel.Visible = false;
                if ((int.Parse(inputNumberBox.Text) % 100) != 0)
                {
                    SumErrorLabel.Visible = true;
                }
                else
                {
                    SumErrorLabel.Visible = false;
                    getBacknoteBox.Clear();
                    int amount = int.Parse(inputNumberBox.Text);

                    //цепочка обработчиков
                    Handler fiveThousandHandler = new FiveThousandHandler(getBacknoteBox, availableNotes, textBox1);
                    Handler oneThousandHandler = new OneThousandHandler(getBacknoteBox, availableNotes, textBox2);
                    Handler fiveHundredHandler = new FiveHundredHandler(getBacknoteBox, availableNotes, textBox3);
                    Handler oneHundredHandler = new OneHundredHandler(getBacknoteBox, availableNotes, textBox4);

                    // Устанавливаем следующего обработчика для каждого обработчика
                    fiveThousandHandler.SetSuccessor(oneThousandHandler);
                    oneThousandHandler.SetSuccessor(fiveHundredHandler);
                    fiveHundredHandler.SetSuccessor(oneHundredHandler);

                    // Начинаем обработку запроса с самого крупного номинала
                    fiveThousandHandler.HandleRequest(amount);
                    maxSumTextBox.Text = CountTheMaxSum().ToString();

                }
            } else
            {
                ErrorZeroLabel.Visible = true;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            getBacknoteBox.Clear();
            inputNumberBox.Clear();
            ErrorLabel.Visible = false;
            SumErrorLabel.Visible = false;
            ErrorZeroLabel.Visible = false;
        }

        private void plusFiveThousand_Click(object sender, EventArgs e)
        {
            if (availableNotes.ContainsKey(5000))
            {
                availableNotes[5000]++;
                textBox1.Text = availableNotes[5000].ToString();
                maxSumTextBox.Text = CountTheMaxSum().ToString();
            }
        }

        private void minusFiveThousand_Click(object sender, EventArgs e)
        {
            if (availableNotes.ContainsKey(5000) && int.Parse(textBox1.Text) != 0)
            {
                availableNotes[5000]--;
                textBox1.Text = availableNotes[5000].ToString();
                maxSumTextBox.Text = CountTheMaxSum().ToString();
            }
        }

        private void plusOneThousand_Click(object sender, EventArgs e)
        {
            if (availableNotes.ContainsKey(1000))
            {
                availableNotes[1000]++;
                textBox2.Text = availableNotes[1000].ToString();
                maxSumTextBox.Text = CountTheMaxSum().ToString();
            }
        }

        private void minusOneThousand_Click(object sender, EventArgs e)
        {
            if (availableNotes.ContainsKey(1000) && int.Parse(textBox2.Text) != 0)
            {
                availableNotes[1000]--;
                textBox2.Text = availableNotes[1000].ToString();
                maxSumTextBox.Text = CountTheMaxSum().ToString();
            }
        }

        private void plusFiveHundred_Click(object sender, EventArgs e)
        {
            if (availableNotes.ContainsKey(500))
            {
                availableNotes[500]++;
                textBox3.Text = availableNotes[500].ToString();
                maxSumTextBox.Text = CountTheMaxSum().ToString();
            }
        }

        private void minusFiveHundred_Click(object sender, EventArgs e)
        {
            if (availableNotes.ContainsKey(500) && int.Parse(textBox3.Text) != 0)
            {
                availableNotes[500]--;
                textBox3.Text = availableNotes[500].ToString();
                maxSumTextBox.Text = CountTheMaxSum().ToString();
            }
        }

        private void plusOneHundred_Click(object sender, EventArgs e)
        {
            if (availableNotes.ContainsKey(100))
            {
                availableNotes[100]++;
                textBox4.Text = availableNotes[100].ToString();
                maxSumTextBox.Text = CountTheMaxSum().ToString();
            }
        }

        private void minusOneHundred_Click(object sender, EventArgs e)
        {
            if (availableNotes.ContainsKey(100) && int.Parse(textBox4.Text) != 0)
            {
                availableNotes[100]--;
                textBox4.Text = availableNotes[100].ToString();
                maxSumTextBox.Text = CountTheMaxSum().ToString();
            }
        }
    }
}
