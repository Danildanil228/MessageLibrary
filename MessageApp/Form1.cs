using System;
using System.Windows.Forms;
using MessageLibrary;

namespace MessageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageHelper.ShowMessages();
        }
    }
}
