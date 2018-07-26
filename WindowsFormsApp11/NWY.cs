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
    public partial class NWY : Form
    {
        static public Worker[] nwyarr = new Worker[5];
        static public string GradeName;
        static public Bonus bns;
        public NWY()
        {
            InitializeComponent();
            Create();
        }
        public void Create()
        {
            Shop shopname = new Shop();
            bns = Bonus.cash;
            shopname.bonustype = bns;

            Grade grade = new Grade();
            grade.Name = "G04";
            grade.Price = 200000;
            grade.Bonus = Bonus.cash;
            grade1.Text = grade.Name + "-" + grade.Price;
            GradeName = grade.Name;

            Worker wrk11 = new Worker();
            wrk11.Name = "Zamiq";
            wrk11.Surname = " Dadasov";
            wrk11.PosName = " Satish temsilchisi";
            wrk11.Wage = 400;
            wrk11.Mail = "zamiqdadash@gmail.com";
            wrk11.Adress = "Baki sheheri";
            wrk11.WorkAdress = Shops.NWY;

            Worker wrk12 = new Worker();
            wrk12.Name = "Pervin";
            wrk12.Surname = " Ehmedov";
            wrk12.PosName = " Satish temsilchisinin komekchisi";
            wrk12.Wage = 300;
            wrk12.Mail = "pervinehmed@gmail.com";
            wrk12.Adress = "Baki sheheri";
            wrk12.WorkAdress = Shops.NWY;

            Worker wrk13 = new Worker();
            wrk13.Name = "Zahid";
            wrk13.Surname = " Cabbarli";
            wrk13.PosName = " Bash satish temsilchisi ";
            wrk13.Wage = 700;
            wrk13.Mail = "zadihcabbar@gmail.com";
            wrk13.Adress = "Baki sheheri";
            wrk13.WorkAdress = Shops.NWY;

            Worker wrk14 = new Worker();
            wrk14.Name = "Meryem";
            wrk14.Surname = " Gozelova";
            wrk14.PosName = " Magaza meneceri";
            wrk14.Wage = 500;
            wrk14.Mail = "meryemgozel@gmail.com";
            wrk14.Adress = "Baki sheheri";
            wrk14.WorkAdress = Shops.NWY;

            Worker wrk15 = new Worker();
            wrk15.Name = "Mehemmed";
            wrk15.Surname = " Ezizli";
            wrk15.PosName = " Magaza menecerinin komekchisi";
            wrk15.Wage = 420;
            wrk15.Mail = "mehemmedeziz@gmail.com";
            wrk15.Adress = "Baki sheheri";
            wrk15.WorkAdress = Shops.NWY;
            Worker[] workers = new Worker[5] { wrk11, wrk12, wrk13, wrk14, wrk15 };
            Label[] labels = new Label[5] { label1, label2, label3, label4, label5 };
            TextBox[] txbxs = new TextBox[5] { textBox1, textBox2, textBox3, textBox4, textBox5 };
            for (int i = 0; i < workers.Length; i++)
            {
                labels[i].Text = workers[i].Name + workers[i].Surname + " (" + workers[i].PosName + " )";
                workers[i].Salesquantity = txbxs[i].Text;
                nwyarr[i] = workers[i];
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void svbtn_Click(object sender, EventArgs e)
        {
            TextBox[] txbxs = new TextBox[5] { textBox1, textBox2, textBox3, textBox4, textBox5 };
            for (int i = 0; i < txbxs.Length; i++)
            {
                nwyarr[i].Salesquantity = txbxs[i].Text;
            }
        }
    }
}
