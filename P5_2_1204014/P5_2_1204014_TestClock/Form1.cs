using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_2_1204014_TestClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void digitalCock1_RaiseTimer1_Tick(object sender, EventArgs e)
        {
            UniversalTimeLabel.Text = DateTime.Now.ToUniversalTime().ToString();
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            digitalCock1.Timer1_Enabled = !(digitalCock1.Timer1_Enabled);
        }
    }
}
