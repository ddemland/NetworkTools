
using System;
using System.Collections;
using System.Windows.Forms;

namespace BinaryToDecimal
{
    public partial class Main : Form
    {
        private int m_currentNumber;

        public Main()
        {
            InitializeComponent();
            ValueText.Focus();
        }

        public void OnTextBoxNoDing(Keys keyCode)
        {
            //if the user pressed enter, get the selected method and start the editor
            //if the user pressed escape, exit the app
            if (keyCode == Keys.Enter)
            {
                ValueText.Text = ValueText.Text.Trim();
                ProcessInputText();
            }
        }

        private void FileExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HelpAboutMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OptionsValuesMenuItem.Checked)
            {
                Position_1.Text = "1";
                Position_2.Text = "2";
                Position_4.Text = "4";
                Position_8.Text = "8";
                Position_16.Text = "16";
                Position_32.Text = "32";
                Position_64.Text = "64";
                Position_128.Text = "128";
            }
            else
            {
                Position_1.Text = "1";
                Position_2.Text = "2";
                Position_4.Text = "3";
                Position_8.Text = "4";
                Position_16.Text = "5";
                Position_32.Text = "6";
                Position_64.Text = "7";
                Position_128.Text = "8";
            }
        }

        private void NoRead_MouseClick(object sender, MouseEventArgs e)
        {
            ValueText.Focus();
        }

        private void NoRead_MouseCaptureChange(object sender, EventArgs e)
        {
            ValueText.Focus();
        }

        private void NewNumber_Click(object sender, EventArgs e)
        {
            var RandNum = new Random();
            m_currentNumber = RandNum.Next(255);

            var ba = BitConverter.GetBytes(m_currentNumber);
            var bits = new BitArray(ba);

            Bit_1.Text = GetBitString(bits[0]);
            Bit_2.Text = GetBitString(bits[1]);
            Bit_4.Text = GetBitString(bits[2]);
            Bit_8.Text = GetBitString(bits[3]);
            Bit_16.Text = GetBitString(bits[4]);
            Bit_32.Text = GetBitString(bits[5]);
            Bit_64.Text = GetBitString(bits[6]);
            Bit_128.Text = GetBitString(bits[7]);

            Status.Text = "";
            ValueText.Text = "";
            ValueText.Focus();
        }

        private static string GetBitString(bool trueBit)
        {
            return (trueBit ? "1" : "0");
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            ProcessInputText();
        }

        private void ProcessInputText()
        {
            if (ValueText.Text.Trim() == "")
            {
                if (!ValueText.ContainsFocus)
                {
                    ValueText.Focus();
                }
                return;
            }

            if (IsNumericString(ValueText.Text.Trim()))
            {
                var enteredValue = Convert.ToInt32(ValueText.Text.Trim());

                Status.Text = enteredValue == m_currentNumber ?
                    "Correct" : "Incorrect";
            }
            else
            {
                Status.Text = "Bad Input Value";
            }

            if (!ValueText.ContainsFocus)
            {
                ValueText.Focus();
            }
        }

        private static bool IsNumericString(string P_str)
        {
            foreach (char ch in P_str)
            {
                if ((ch < '0') || (ch > '9'))
                {
                    return (false);
                }
            }

            return (true);
        }
    }
}
