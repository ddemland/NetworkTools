
using System;
using System.Collections;
using System.Windows.Forms;

namespace DecimalToBinary
{
    public partial class Main : Form
    {
        private bool m_showHints;
        private int m_currentNumber;
        private readonly BitArray m_guess;
        private bool m_valueSet;

        public Main()
        {
            InitializeComponent();
            m_guess = new BitArray(8);
        }

        private void ValuesMenuItem_Click(object sender, EventArgs e)
        {
            if (OptionsValuesMenuItem.Checked)
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

        private void FileExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HelpAboutMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
        }

        private void OptionsHintMenuItem_Click(object sender, EventArgs e)
        {
            if (OptionsHintMenuItem.Checked)
            {
                m_showHints = true;
                HintLabel.Text = "Hint";
                ShowHint();
            }
            else
            {
                HintLabel.Text = "";
                Hint.Text = "";
                m_showHints = false;
            }
        }

        private void ShowHint()
        {
            if (m_showHints)
            {
                Hint.Text = ConvertBitArrayToInt(m_guess).ToString();
            }
        }

        private static int ConvertBitArrayToInt(BitArray array)
        {
            var binChars = new char[8];
            int strIdx = 7;
            for (int cnt = 0; cnt < 8; cnt++)
            {
                binChars[strIdx--] = array[cnt] ? '1' : '0';
            }

            var binStr = new string(binChars);
            return (Convert.ToInt32(binStr, 2));
        }

        private void NewNumberButton_Click(object sender, EventArgs e)
        {
            DoRest();
            GetNewGuessValue();
        }

        private void DoRest()
        {
            Bit_1.Text = "0";
            Bit_2.Text = "0";
            Bit_4.Text = "0";
            Bit_8.Text = "0";
            Bit_16.Text = "0";
            Bit_32.Text = "0";
            Bit_64.Text = "0";
            Bit_128.Text = "0";

            for (int cnt = 0; cnt < 8; cnt++)
            {
                m_guess[cnt] = false;
            }

            ShowHint();
            Message.Text = "";
            Bit_128.Focus();
        }

        private void GetNewGuessValue()
        {
            var RandNum = new Random();
            m_currentNumber = RandNum.Next(255);

            Value.Text = m_currentNumber.ToString();
            Message.Text = "";
            m_valueSet = true;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            var guessValue = ConvertBitArrayToInt(m_guess);

            Message.Text = guessValue == m_currentNumber ?
                "Correct" : "Incorrect";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DoRest();
        }

        private void Bit_128_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessBitInput(e.KeyChar, Bit_128, 7);
        }

        private void Bit_64_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessBitInput(e.KeyChar, Bit_64, 6);
        }

        private void Bit_32_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessBitInput(e.KeyChar, Bit_32, 5);
        }

        private void Bit_16_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessBitInput(e.KeyChar, Bit_16, 4);
        }

        private void Bit_8_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessBitInput(e.KeyChar, Bit_8, 3);
        }

        private void Bit_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessBitInput(e.KeyChar, Bit_4, 2);
        }

        private void Bit_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessBitInput(e.KeyChar, Bit_2, 1);
        }

        private void Bit_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessBitInput(e.KeyChar, Bit_1, 0);
        }

        private void ProcessBitInput(char key, Control tbox, int bitIdx)
        {
            if (!m_valueSet)
            {
                m_valueSet = true;
                GetNewGuessValue();
            }

            if ((key != '0') && (key != '1'))
            {
                Message.Text = "Input is not a 1 or 0";
                tbox.Text = "";
            }
            else
            {
                Message.Text = "";
                tbox.Text = "";

                m_guess[bitIdx] = key == '1' ? true : false;

                ShowHint();
            }
        }

        private void NoRead_MouseCLick(object sender, MouseEventArgs e)
        {
            Bit_128.Focus();
        }

        private void NoRead_MouseCaptureChange(object sender, EventArgs e)
        {
            Bit_128.Focus();
        }
    }
}
