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
        }


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

            public void SetSuccessor(Handler successor)
            {
                Successor = successor;
            }

            public abstract void HandleRequest(int amount);
        }

        public class FiveThousandHandler : Handler
        {
            private TextBox getBacknoteBox;
            public FiveThousandHandler(TextBox getBacknoteBox)
            {
                this.getBacknoteBox = getBacknoteBox;
            }
            public override void HandleRequest(int amount)
            {
                if (amount >= 5000)
                {
                    int count = amount / 5000;
                    int remainder = amount % 5000;
                    if (count == 1 || count == 101)
                    {
                        getBacknoteBox.Text += $"{count} купюра по 5000{Environment.NewLine}";
                    } else if((count > 1 && count <= 4) || (count >= 102 && count <= 104))
                    {
                        getBacknoteBox.Text += $"{count} купюры по 5000{Environment.NewLine}";
                    } else
                    {
                        getBacknoteBox.Text += $"{count} купюр по 5000{Environment.NewLine}";
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
            public OneThousandHandler(TextBox getBacknoteBox)
            {
                this.getBacknoteBox = getBacknoteBox;
            }

            public override void HandleRequest(int amount)
            {
                if (amount >= 1000)
                {
                    int count = amount / 1000;
                    int remainder = amount % 1000;
                    if (count == 1 || count == 101)
                    {
                        getBacknoteBox.Text += $"{count} купюра по 1000{Environment.NewLine}";
                    }
                    else if ((count > 1 && count <= 4) || (count >= 102 && count <= 104))
                    {
                        getBacknoteBox.Text += $"{count} купюры по 1000{Environment.NewLine}";
                    }
                    else
                    {
                        getBacknoteBox.Text += $"{count} купюр по 1000{Environment.NewLine}";
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

        public class FiveHundredHandler : Handler
        {
            private TextBox getBacknoteBox;
            public FiveHundredHandler(TextBox getBacknoteBox)
            {
                this.getBacknoteBox = getBacknoteBox;
            }

            public override void HandleRequest(int amount)
            {
                if (amount >= 500)
                {
                    int count = amount / 500;
                    int remainder = amount % 500;
                    if (count == 1 || count == 101)
                    {
                        getBacknoteBox.Text += $"{count} купюра по 500{Environment.NewLine}";
                    }
                    else if ((count > 1 && count <= 4) || (count >= 102 && count <= 104))
                    {
                        getBacknoteBox.Text += $"{count} купюры по 500{Environment.NewLine}";
                    }
                    else
                    {
                        getBacknoteBox.Text += $"{count} купюр по 500{Environment.NewLine}";
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
            public OneHundredHandler(TextBox getBacknoteBox)
            {
                this.getBacknoteBox = getBacknoteBox;
            }

            public override void HandleRequest(int amount)
            {
                if (amount >= 100)
                {
                    int count = amount / 100;
                    int remainder = amount % 100;

                    if (count == 1 || count == 101)
                    {
                        getBacknoteBox.Text += $"{count} купюра по 100{Environment.NewLine}";
                    }
                    else if ((count > 1 && count <= 4) || (count >= 102 && count <= 104))
                    {
                        getBacknoteBox.Text += $"{count} купюры по 100{Environment.NewLine}";
                    }
                    else
                    {
                        getBacknoteBox.Text += $"{count} купюр по 100{Environment.NewLine}";
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
                    int amount = int.Parse(inputNumberBox.Text);

                    //цепочка обработчиков
                    Handler fiveThousandHandler = new FiveThousandHandler(getBacknoteBox);
                    Handler oneThousandHandler = new OneThousandHandler(getBacknoteBox);
                    Handler fiveHundredHandler = new FiveHundredHandler(getBacknoteBox);
                    Handler oneHundredHandler = new OneHundredHandler(getBacknoteBox);

                    // Устанавливаем следующего обработчика для каждого обработчика
                    fiveThousandHandler.SetSuccessor(oneThousandHandler);
                    oneThousandHandler.SetSuccessor(fiveHundredHandler);
                    fiveHundredHandler.SetSuccessor(oneHundredHandler);

                    // Начинаем обработку запроса с самого крупного номинала
                    fiveThousandHandler.HandleRequest(amount);
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
    }
}
