using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medic_gh
{
    public partial class startup : Form
    {
        int progress = 0;
        public startup()
        {
            InitializeComponent();
        }

        private void startup_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 50;


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                this.Hide();
                login f = new login();
                f.Show();

            }
            progressBar1.Value = progress;

        }
    }
}
