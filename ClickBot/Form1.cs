using System;
using System.Windows.Forms;

namespace ClickBot
{
    public partial class Form1 : Form
    {
        private KeyHandler _keyHandler;
        private Keys _magicKey;

        public Form1()
        {
            InitializeComponent();
            _magicKey = Keys.PageUp;
            _keyHandler = new KeyHandler(_magicKey, this);
            _keyHandler.Register();
            RunKeyLabel.Text = _magicKey.ToString();
        }


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 786)
            {
                if (!decimal.TryParse(textBox1.Text, out var number))
                {
                    MessageBox.Show($"can not parse {textBox1.Text}");
                    timer1.Enabled = false;
                }


                timer1.Interval = Convert.ToInt32(number * 1000);
                timer1.Enabled = !timer1.Enabled;
                groupBox1.Enabled = !timer1.Enabled;
            }

            base.WndProc(ref m);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RightCheckBox.Checked)
            {
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.RightDown);
                System.Threading.Thread.Sleep(50);
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.RightUp);
            }
            else
            {
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                System.Threading.Thread.Sleep(50);
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
            }
        }


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (LeftCheckBox.Checked)
            {
                RightCheckBox.Checked = false;
            }
            else
            {
                LeftCheckBox.Checked = false;
            }
        }

        private void RightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox1_CheckedChanged(sender, e);
        }

        private bool _captureKey = false;

        private void SetRunKey_Click(object sender, EventArgs e)
        {
            RunKeyLabel.Text = "Press a button to set it";
            _captureKey = true;
        }

        private void CaptureKey(Keys key)
        {
            if (!_captureKey)
            {
                return;
            }

            _magicKey = key;
            RunKeyLabel.Text = _magicKey.ToString();
            _captureKey = false;

            _keyHandler = new KeyHandler(_magicKey, this);
            _keyHandler.Register();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            CaptureKey(e.KeyCode);
        }

        private void SetRunKey_KeyDown(object sender, KeyEventArgs e)
        {  CaptureKey(e.KeyCode);
        }
    }
}