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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;


            if (username == "Dr.Darius" && password == "medic")
            {
                MessageBox.Show(" Thanks for logining in Dr.Darius");
                this.Hide();
                Form1 ds = new Form1();
                ds.Show();
            }
            else
            {
                if (username == "Dr.Cenac" && password == "medic")

                {
                    MessageBox.Show(" Thanks for logining in Dr.Cenac");
                    this.Hide();
                    Form1 ds = new Form1 ();
                    ds.Show();
                }




                else
                    MessageBox.Show(" Wrong UserName // Wrong Password");

            }

        }
    }
}
