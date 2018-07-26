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
    public partial class Mango : Form
    {
        static public Worker[] commonArr = new Worker[5];
        static public string GradeName;
        static public Worker[] admnarr = new Worker[5];
        static public Bonus bns;
        public Mango()
        {
            InitializeComponent();
            Create();
            admnarr = AdminControl.adminarray;

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void svbtn_Click(object sender, EventArgs e)
        {
            TextBox[] txbxs = new TextBox[5] { textBox1, textBox2, textBox3, textBox4, textBox5 };
            for (int i = 0; i < txbxs.Length; i++)
            {
                commonArr[i].Salesquantity = txbxs[i].Text;
            }
            
        }
        public void Create()
        {
            Shop shopname = new Shop();
            bns = Bonus.cash;
            shopname.bonustype = bns;

            Grade grade = new Grade();
            grade.Name = "G01";
            grade.Price = 100000;
            grade.Bonus = Bonus.cash;
            grade1.Text = grade.Name + "-" + grade.Price;
            GradeName = grade.Name;

            Worker wrk1 = new Worker();
            wrk1.Name = "Samir";
            wrk1.Surname = " Talibov";
            wrk1.PosName = " Satish temsilchisi";
            wrk1.Wage = 400;
            wrk1.Mail = "samirtalib@gmail.com";
            wrk1.Adress = "Baki sheheri";
            wrk1.WorkAdress = Shops.Mango;

            Worker wrk2 = new Worker();
            wrk2.Name = "Elgiz";
            wrk2.Surname = " Eyvazli";
            wrk2.PosName = " Satish temsilchisinin komekchisi";
            wrk2.Wage = 300;
            wrk2.Mail = "elgizeyvaz@gmail.com";
            wrk2.Adress = "Baki sheheri";
            wrk2.WorkAdress = Shops.Mango;

            Worker wrk3 = new Worker();
            wrk3.Name = "Xelil";
            wrk3.Surname = " Memmedov";
            wrk3.PosName = " Bash satish temsilchisi ";
            wrk3.Wage = 700;
            wrk3.Mail = "xelilmemmed@gmail.com";
            wrk3.Adress = "Baki sheheri";
            wrk3.WorkAdress = Shops.Mango;

            Worker wrk4 = new Worker();
            wrk4.Name = "Sakit";
            wrk4.Surname = " Ezimov";
            wrk4.PosName = " Magaza meneceri";
            wrk4.Wage = 500;
            wrk4.Mail = "sakitezim@gmail.com";
            wrk4.Adress = "Baki sheheri";
            wrk4.WorkAdress = Shops.Mango;

            Worker wrk5 = new Worker();
            wrk5.Name = "Nicat";
            wrk5.Surname = " Sadixov";
            wrk5.PosName = " Magaza menecerinin komekchisi";
            wrk5.Wage = 420;
            wrk5.Mail = "nicatsadix@gmail.com";
            wrk5.Adress = "Baki sheheri";
            wrk5.WorkAdress = Shops.Mango;

            Worker[] workers = new Worker[5] { wrk1, wrk2, wrk3, wrk4, wrk5 };
            Label[] labels = new Label[5] { label1, label2, label3, label4, label5 };
            TextBox[] txbxs = new TextBox[5] { textBox1, textBox2, textBox3, textBox4, textBox5 };
            for (int i = 0; i < workers.Length; i++)
            {
                labels[i].Text = workers[i].Name + workers[i].Surname + " (" + workers[i].PosName + " )";
                workers[i].Salesquantity = txbxs[i].Text;
                commonArr[i] = workers[i];
            }
        }
    }
}
