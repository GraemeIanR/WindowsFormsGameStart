using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsGameStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.beep);
            sp.Play();
            labelStarting.ForeColor = Color.White;
            
            Refresh();
            
            Thread.Sleep(1000);
            sp.Play();
            labelStarting.Text = "Starting in: 2";
            Refresh();
            Thread.Sleep(1000);
            sp.Play();
            labelStarting.Text = "Starting in 1:";
            Refresh();
            Thread.Sleep(1000);
            sp = new SoundPlayer(Properties.Resources.robot_Blip);
            sp.Play();
            
            labelStarting.Text = "       GO!";
            this.BackColor = Color.Green;
            buttonStart.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
