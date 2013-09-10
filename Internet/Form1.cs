using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Internet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        //{
        //    try
        //    {
        //        toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
        //        toolStripProgressBar1.Maximum = Convert.ToInt32(e.CurrentProgress);
        //    }
        //    catch (Exception)
        //    {
        //        //MessageBox.Show(ex.Message);
        //    }
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.facebook.com/");
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Shift)
                {
                    SendKeys.Send("+{TAB}");

                }
                else
                {
                    SendKeys.Send("+{TAB}");
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com/");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.youtube.com/");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.skype.com/");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://twitter.com/");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://instagram.com/");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.github.com/");
        }

        

       
        
        
    }
}
