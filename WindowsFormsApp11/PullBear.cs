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
    public partial class PullBear : Form
    {
        static public Worker[] pullbeararr = new Worker[5];
        static public string GradeName;
        static public Bonus bns;
        public PullBear()
        {
            InitializeComponent();
            Create();
        }

        private void svbtn_Click(object sender, EventArgs e)
        {
            TextBox[] txbxs = new TextBox[5] { textBox1, textBox2, textBox3, textBox4, textBox5 };
            for (   int i = 0; i < txbxs.Length; i++)
            {
                pullbeararr[i].Salesquantity = txbxs[i].Text;
            }
        }
        public void Create()
        {

            Shop shopname = new Shop();
            bns = Bonus.cash;
            shopname.bonustype = bns;

            Grade grade = new Grade();
            grade.Name = "G02";
            grade.Price = 340000;
            grade.Bonus = Bonus.percent;
            grade1.Text = grade.Name + "-" + grade.Price;
            GradeName = grade.Name;

            Worker wrk1 = new Worker();
            wrk1.Name = "Sakit";
            wrk1.Surname = " Xelilov";
            wrk1.PosName = " Satish temsilchisi";
            wrk1.Wage = 400;
            wrk1.Mail = "sakitxelil@gmail.com";
            wrk1.Adress = "Baki sheheri";
            wrk1.WorkAdress = Shops.PullBear;

            Worker wrk2 = new Worker();
            wrk2.Name = "Nicat";
            wrk2.Surname = " Eliyev";
            wrk2.PosName = " Satish temsilchisinin komekchisi";
            wrk2.Wage = 300;
            wrk2.Mail = "nicateliyev@gmail.com";
            wrk2.Adress = "Baki sheheri";
            wrk2.WorkAdress = Shops.PullBear;

            Worker wrk3 = new Worker();
            wrk3.Name = "Shahin";
            wrk3.Surname = " Cabbarov";
            wrk3.PosName = " Bash satish temsilchisi ";
            wrk3.Wage = 700;
            wrk3.Mail = "shahincabbar@gmail.com";
            wrk3.Adress = "Baki sheheri";
            wrk3.WorkAdress = Shops.PullBear;

            Worker wrk4 = new Worker();
            wrk4.Name = "Xaver";
            wrk4.Surname = " Memmedova";
            wrk4.PosName = " Magaza meneceri";
            wrk4.Wage = 500;
            wrk4.Mail = "xavermemmedova@gmail.com";
            wrk4.Adress = "Baki sheheri";
            wrk4.WorkAdress = Shops.PullBear;

            Worker wrk5 = new Worker();
            wrk5.Name = "Gunay";
            wrk5.Surname = " Babazade";
            wrk5.PosName = " Magaza menecerinin komekchisi";
            wrk5.Wage = 420;
            wrk5.Mail = "gunaybaba@gmail.com";
            wrk5.Adress = "Baki sheheri";
            wrk5.WorkAdress = Shops.PullBear;

            Worker[] workers = new Worker[5] { wrk1, wrk2, wrk3, wrk4, wrk5 };
            Label[] labels = new Label[5] { label1, label2, label3, label4, label5 };
            TextBox[] txbxs = new TextBox[5] { textBox1, textBox2, textBox3, textBox4, textBox5 };
            for (int i = 0; i < workers.Length; i++)
            {
                labels[i].Text = workers[i].Name + workers[i].Surname + " (" + workers[i].PosName + " )";
                workers[i].Salesquantity = txbxs[i].Text;
                pullbeararr[i] = workers[i];
            }
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
