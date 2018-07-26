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
    public partial class Bershka : Form
    {
        static public Worker[] bershkaArray = new Worker[5];
        static public string GradeName;
        static public Bonus bns;
        public Bershka()
        {
            InitializeComponent();
            Create();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Create()
        {
            Shop shopname = new Shop();
            bns = Bonus.cash;
            shopname.bonustype = bns;

            Grade grade = new Grade();
            grade.Name = "G03";
            grade.Price = 340000;
            grade.Bonus = Bonus.cash;
            grade1.Text = grade.Name + "-" + grade.Price;
            GradeName = grade.Name;

            Worker wrk16 = new Worker();
            wrk16.Name = "Akshin";
            wrk16.Surname = " Qasimov";
            wrk16.PosName = " Satish temsilchisi";
            wrk16.Wage = 400;
            wrk16.Mail = "akshinqasim@gmail.com";
            wrk16.Adress = "Baki sheheri";
            wrk16.WorkAdress = Shops.Bershka;

            Worker wrk17 = new Worker();
            wrk17.Name = "Sahib";
            wrk17.Surname = " Sahibli";
            wrk17.PosName = " Satish temsilchisinin komekchisi";
            wrk17.Wage = 300;
            wrk17.Mail = "sahibsahibli@gmail.com";
            wrk17.Adress = "Baki sheheri";
            wrk17.WorkAdress = Shops.Bershka;

            Worker wrk18 = new Worker();
            wrk18.Name = "Kamran";
            wrk18.Surname = " Kazimov";
            wrk18.PosName = " Bash satish temsilchisi ";
            wrk18.Wage = 700;
            wrk18.Mail = "kamrankazim@gmail.com";
            wrk18.Adress = "Baki sheheri";
            wrk18.WorkAdress = Shops.Bershka;

            Worker wrk19 = new Worker();
            wrk19.Name = "Aygun";
            wrk19.Surname = " Bedelova";
            wrk19.PosName = " Magaza meneceri";
            wrk19.Wage = 500;
            wrk19.Mail = "aygunbedel@gmail.com";
            wrk19.Adress = "Baki sheheri";
            wrk19.WorkAdress = Shops.Bershka;

            Worker wrk20 = new Worker();
            wrk20.Name = "Musa";
            wrk20.Surname = " Balayev";
            wrk20.PosName = " Magaza menecerinin komekchisi";
            wrk20.Wage = 420;
            wrk20.Mail = "musabala@gmail.com";
            wrk20.Adress = "Baki sheheri";
            wrk20.WorkAdress = Shops.Bershka;
            Worker[] workers = new Worker[5] { wrk16, wrk17, wrk18, wrk19, wrk20 };
            Label[] labels = new Label[5] { label1, label2, label3, label4, label5 };
            TextBox[] txbxs = new TextBox[5] { textBox1, textBox2, textBox3, textBox4, textBox5 };
            for (int i = 0; i < workers.Length; i++)
            {
                labels[i].Text = workers[i].Name + workers[i].Surname + " (" + workers[i].PosName + " )";
                workers[i].Salesquantity = txbxs[i].Text;
                bershkaArray[i] = workers[i];
            }
        }
        private void svbtn_Click(object sender, EventArgs e)
        {
            TextBox[] txbxs = new TextBox[5] { textBox1, textBox2, textBox3, textBox4, textBox5 };
            for (int i = 0; i < txbxs.Length; i++)
            {
                bershkaArray[i].Salesquantity = txbxs[i].Text;
            }
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
