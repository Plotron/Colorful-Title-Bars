using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace InactiveWindowsBarColorSetter
{
    public partial class Form1 : Form
    {
        private string red, green, blue, red2,green2,blue2;
        public Form1()
        {
            InitializeComponent();
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            this.textBoxRed.Text = "" + colorDialog1.Color.R;
            this.textBoxGreen.Text = "" + colorDialog1.Color.G;
            this.textBoxBlue.Text = "" + colorDialog1.Color.B;
            trackBarRed.Value = colorDialog1.Color.R;
            trackBarGreen.Value = colorDialog1.Color.G;
            trackBarBlue.Value = colorDialog1.Color.B;
            Color color = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            submitBtn.BackColor = color;
            //////////////////////////////////////
            red = ((this.trackBarRed.Value < 16) ? "0" : "") + string.Format("{0:x}", trackBarRed.Value);
            //////////////////////////////////////
            green = ((this.trackBarGreen.Value < 16) ? "0" : "") + string.Format("{0:x}", trackBarGreen.Value);
            //////////////////////////////////////
            blue = ((this.trackBarBlue.Value < 16) ? "0" : "") + string.Format("{0:x}", trackBarBlue.Value);
            //////////////////////////////////////
            textBoxHash.Text = "#" + red + green + blue;

            if (color.GetBrightness() < 0.55)
            {
                submitBtn.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                submitBtn.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                WindowCustomizationUtility.SetInactiveAccentColor("" + blue + green + red);
            }
            catch (ArgumentNullException)
            {
                textBoxHash.Text = "Error! Argument is null!";
            }
            catch (ArgumentException)
            {
                textBoxHash.Text = "Error! Incorrect value!";
            }
            catch (UnauthorizedAccessException)
            {
                textBoxHash.Text = "Error! RegistryKey inaccessible!";
            }
            catch (FormatException)
            {
                textBoxHash.Text = "Error! Sliders not set!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowCustomizationUtility.SetInactiveAccentColor("ffffff");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.textBoxRed.Text = "" + this.trackBarRed.Value;
            Color color = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            submitBtn.BackColor = color;
            //////////////////////////////////////TODO: REFACTOR
            if (this.trackBarRed.Value < 16)
            {
                red = "" + '0' + string.Format("{0:x}", trackBarRed.Value);
            }
            else
            {
                red = "" + string.Format("{0:x}", trackBarRed.Value);
            }

            ///////////////////////////////////////////
            if (this.trackBarGreen.Value < 16)
            {
                green = "" + '0' + string.Format("{0:x}", trackBarGreen.Value);
            }
            else
            {
                green = "" + string.Format("{0:x}", trackBarGreen.Value);
            }
            ///////////////////////////////
            if (this.trackBarBlue.Value < 16)
            {
                blue = "" + '0' + string.Format("{0:x}", trackBarBlue.Value);
            }
            else
            {
                blue = "" + string.Format("{0:x}", trackBarBlue.Value);
            }
            /////////////////////////////////////
            textBoxHash.Text = "#" + red + green  + blue;
            /////////////////////////////////////
            if (color.GetBrightness() < 0.55)
            {
                submitBtn.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                submitBtn.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            this.textBoxGreen.Text = "" + this.trackBarGreen.Value;
            Color color = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            submitBtn.BackColor = color;
            //////////////////////////////////////
            if (this.trackBarRed.Value < 16)
            {
                red = "" + '0' + string.Format("{0:x}", trackBarRed.Value);
            }
            else
            {
                red = "" + string.Format("{0:x}", trackBarRed.Value);
            }

            ///////////////////////////////////////////
            if (this.trackBarGreen.Value < 16)
            {
                green = "" + '0' + string.Format("{0:x}", trackBarGreen.Value);
            }
            else
            {
                green = "" + string.Format("{0:x}", trackBarGreen.Value);
            }
            ///////////////////////////////
            if (this.trackBarBlue.Value < 16)
            {
                blue = "" + '0' + string.Format("{0:x}", trackBarBlue.Value);
            }
            else
            {
                blue = "" + string.Format("{0:x}", trackBarBlue.Value);
            }
            /////////////////////////////////////
            textBoxHash.Text = "#" + red + green + blue;
            /////////////////////////////////////
            if (color.GetBrightness() < 0.55)
            {
                submitBtn.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                submitBtn.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            this.textBoxBlue.Text = "" + this.trackBarBlue.Value;
            Color color = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            submitBtn.BackColor = color;
            //////////////////////////////////////
            if (this.trackBarRed.Value < 16)
            {
                red = "" + '0' + string.Format("{0:x}", trackBarRed.Value);
            }
            else
            {
                red = "" + string.Format("{0:x}", trackBarRed.Value);
            }

            ///////////////////////////////////////////
            if (this.trackBarGreen.Value < 16)
            {
                green = "" + '0' + string.Format("{0:x}", trackBarGreen.Value);
            }
            else
            {
                green = "" + string.Format("{0:x}", trackBarGreen.Value);
            }
            ///////////////////////////////
            if (this.trackBarBlue.Value < 16)
            {
                blue = "" + '0' + string.Format("{0:x}", trackBarBlue.Value);
            }
            else
            {
                blue = "" + string.Format("{0:x}", trackBarBlue.Value);
            }
            /////////////////////////////////////
            textBoxHash.Text = "#" + red + green + blue;
            /////////////////////////////////////
            if (color.GetBrightness() < 0.55)
            {
                submitBtn.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                submitBtn.ForeColor = System.Drawing.Color.Black;
            }
        }

       
    }
}
