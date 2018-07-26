using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "mango" && textBox2.Text=="123" ) {
                Mango mngc = new Mango();
                mngc.ShowDialog();
            }
            else if(textBox1.Text == "admin" && textBox2.Text == "123")
            {
                AdminControl admin = new AdminControl();
                admin.ShowDialog();
            }
            else if (textBox1.Text == "nwy" && textBox2.Text == "123")
            {
                NWY admin = new NWY();
                admin.ShowDialog();
            }
            else if (textBox1.Text == "bershka" && textBox2.Text == "123")
            {
                Bershka admin = new Bershka();
                admin.ShowDialog();
            }
            else if (textBox1.Text == "pullbear" && textBox2.Text == "123")
            {
                PullBear admin = new PullBear();
                admin.ShowDialog();
            }
            else
            {
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
