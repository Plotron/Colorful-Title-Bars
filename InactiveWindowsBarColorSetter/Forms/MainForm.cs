using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ColorMine.ColorSpaces;
using ColorfulTitleBars;
using ColorfulTitleBars.Logic;

namespace RegistryUtils
{
    public partial class MainForm : Form
    {
        private int _red = 255;
        private int Red
        {
            get { return _red; }

            set
            {
                _red = value > 255 ? 255 : value;
                UpdateRgb();
            }
        }

        private int _green = 255;
        private int Green
        {
            get { return _green; }

            set
            {
                _green = value > 255 ? 255 : value;
                UpdateRgb();
            }
        }

        private int _blue = 255;
        private int Blue
        {
            get { return _blue; }

            set
            {
                _blue = value > 255 ? 255 : value;
                UpdateRgb();
            }
        }

        private RegFileProcessor _windowColor;

        public MainForm()
        {
            InitializeComponent();
            _windowColor = new RegFileProcessor();
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            windowsColorDialog.Color = Color.FromArgb(Red, Green, Blue);
            windowsColorDialog.ShowDialog();

            Red = windowsColorDialog.Color.R;
            Green = windowsColorDialog.Color.G;
            Blue = windowsColorDialog.Color.B;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                WindowCustomizationUtility.SetInactiveAccentColor((byte) _red, (byte) _green, (byte) _blue);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    Strings.RegistryInaccessibleErrorMessage,
                    Strings.RegistryUpdateErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restoreDefaultBtn_Click(object sender, EventArgs e)
        {
            try
            {
                WindowCustomizationUtility.DeleteInactiveAccentColor();
            }
            catch (ArgumentException) { }
        }

        private void UpdateRgb()
        {
            UpdateTextFields();
            UpdateHashField();
            UpdateButtonColor();
            UpdateTrackBars();
        }

        private void UpdateTextFields()
        {
            this.textBoxRed.Text = "" + Red;
            this.textBoxGreen.Text = "" + Green;
            this.textBoxBlue.Text = "" + Blue;
        }

        private void UpdateHashField()
        {
            textBoxHash.Text = @"#" + HexUtility.RgbToHexValue((byte) Red, (byte) Green, (byte) Blue);
        }

        private void UpdateButtonColor()
        {
            Color color = Color.FromArgb(Red, Green, Blue);
            submitBtn.BackColor = color;
            submitBtn.ForeColor = color.GetBrightness() < 0.55 ? Color.White : Color.Black;
        }

        private void UpdateTrackBars()
        {
            this.trackBarRed.Value = Red;
            this.trackBarGreen.Value = Green;
            this.trackBarBlue.Value = Blue;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only integer numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            Red = trackBarRed.Value;
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            Green = trackBarGreen.Value;
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            Blue = trackBarBlue.Value;
        }

        private void textChanged(object sender, Action<int> modifyColorValue)
        {
            var textBox = sender as TextBox;
            try
            {
                var newValue = int.Parse(textBox.Text);
                modifyColorValue(newValue);
            }
            catch (FormatException) { }
            
            textBox.Select(textBox.Text.Length, 0); //prevent cursor reset
        }

        private void textBoxGreen_TextChanged(object sender, EventArgs e)
        {
            textChanged(sender, v => { Green = v; });
        }

        private void textBoxBlue_TextChanged(object sender, EventArgs e)
        {
            textChanged(sender, v => { Blue = v; });
        }

        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {
            textChanged(sender, v => { Red = v; });
        }

        private void textBoxColor_Leave(object sender, Action<int> modifyColorValue)
        {
            var textBox = sender as TextBox;
            if (textBox.Text.Length == 0)
            {
                textBox.Text = "0";
            }

            modifyColorValue(int.Parse(textBox.Text));
        }

        private void textBoxRed_Leave(object sender, EventArgs e)
        {
            textBoxColor_Leave(sender, v => { Red = v; });
        }

        private void textBoxGreen_Leave(object sender, EventArgs e)
        {
            textBoxColor_Leave(sender, v => { Green = v; });
        }

        private void textBoxBlue_Leave(object sender, EventArgs e)
        {
            textBoxColor_Leave(sender, v => { Blue = v; });
        }

        private void textBoxHash_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text.Length >= 6)   //try parsing only when the hash could realistically be complete
            {
                try
                {
                    string text = textBox.Text[0] == '#' ? textBox.Text.Substring(1) : textBox.Text;
                    byte r = Convert.ToByte($"{text[0]}{text[1]}", 16);
                    byte g = Convert.ToByte($"{text[2]}{text[3]}", 16);
                    byte b = Convert.ToByte($"{text[4]}{text[5]}", 16);

                    Red = r;
                    Green = g;
                    Blue = b;

                    textBox.Select(textBox.Text.Length, 0); //prevent cursor reset
                }
                catch (FormatException) { }
                catch (IndexOutOfRangeException) { }
            }
        }

        private void textBoxHash_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only hex numbers
            if (!(Regex.IsMatch(e.KeyChar.ToString(), "(?i)[a-f0-9]") || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void autoBtn_Click(object sender, EventArgs e)
        {
            var accentColor = WindowCustomizationUtility.GetActiveAccentColor();

            var rgb = new Rgb(accentColor.R, accentColor.G, accentColor.B);
            var hsl = rgb.To<Hsl>();

            hsl.L *= 1.65;
            rgb = hsl.To<Rgb>();

            Red = (int) rgb.R;
            Green = (int) rgb.G;
            Blue = (int) rgb.B;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!WindowCustomizationUtility.IsTitlebarColorPrevalenceEnabled())
            {
                DialogResult result = MessageBox.Show(
                    Strings.ColorDisabledWarningMessage,
                    Strings.ColorDisabledWarningTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    WindowCustomizationUtility.SetTitlebarColorPrevalence(true);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Windows Registry files (*.reg)|*.reg|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _windowColor.SaveInactiveAccentColorToRegFile(Color.FromArgb(Red, Green, Blue), saveFileDialog.FileName);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Windows Registry files (*.reg)|*.reg";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Color? inactiveAccentColor = _windowColor.LoadInactiveAccentColorFromRegFile(openFileDialog.FileName);
                if (inactiveAccentColor.HasValue)
                {    
                    Red = inactiveAccentColor.Value.R;
                    Green = inactiveAccentColor.Value.G;
                    Blue = inactiveAccentColor.Value.B;
                } else
                {
                    MessageBox.Show(
                        Strings.RegFileParsingFailedMessage,
                        Strings.RegFileParsingFailedTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void exportAccentColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Windows Registry files (*.reg)|*.reg|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Color inactiveAccentColor = WindowCustomizationUtility.GetInactiveAccentColor();
                Color activeAccentColor = WindowCustomizationUtility.GetActiveAccentColor();
                _windowColor.SaveAccentColorsToRegFile(inactiveAccentColor, activeAccentColor, saveFileDialog.FileName);
            }
        }

        private void currentActiveAccentColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color systemActiveAccentColor = WindowCustomizationUtility.GetActiveAccentColor();

            Red = systemActiveAccentColor.R;
            Green = systemActiveAccentColor.G;
            Blue = systemActiveAccentColor.B;
        }

        private void currentInactiveAccentColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color systemInactiveAccentColor = WindowCustomizationUtility.GetInactiveAccentColor();

            Red = systemInactiveAccentColor.R;
            Green = systemInactiveAccentColor.G;
            Blue = systemInactiveAccentColor.B;
        }
    }
}
