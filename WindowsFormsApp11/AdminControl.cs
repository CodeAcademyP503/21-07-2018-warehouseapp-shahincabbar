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
    public partial class AdminControl : Form
    {
        static public Worker[] mangoarrays = new Worker[5];
        static public string GradeName;
        static public Worker[] adminarray = new Worker[5];
        static public Worker[] bershkaArr = new Worker[5];
        static public Bonus bns;
        static public Worker[] nwyarray = new Worker[5];
        static public Worker[] mangoarr = new Worker[5];
        static public Worker[] pullbeararray = new Worker[5];
        static public Grade[] grds = new Grade[4];
        static public Worker[] wrkrs = new Worker[20];
        static public List<DataGridViewCheckBoxColumn> chkbx = new List<DataGridViewCheckBoxColumn> { };
        public AdminControl()
        {
            InitializeComponent();
            Create();
            mangoarrays = Mango.commonArr;
            bershkaArr = Bershka.bershkaArray;
            nwyarray = NWY.nwyarr;
            pullbeararray = PullBear.pullbeararr;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void Create()
        {
            Shop shopname = new Shop();
            bns = Bonus.cash;
            shopname.bonustype = bns;

            Grade grade = new Grade
            {
                Name = "G01",
                Price = 100000,
                Bonus = Bonus.cash
            };
            GradeName = grade.Name;

            Grade grade2 = new Grade
            {
                Name = "G02",
                Price = 340000,
                Bonus = Bonus.percent
            };
            GradeName = grade2.Name;

            Grade grade3 = new Grade
            {
                Name = "G03",
                Price = 340000,
                Bonus = Bonus.cash
            };
            GradeName = grade3.Name;

            Grade grade4 = new Grade
            {
                Name = "G04",
                Price = 200000,
                Bonus = Bonus.cash
            };
            GradeName = grade4.Name;
            Grade[] grades = new Grade[4] { grade, grade2, grade3, grade4 };
            for (int i = 0; i < grades.Length; i++)
            {
                grds[i] = grades[i];
            }
            Worker wrk1 = new Worker
            {
                Name = "Samir",
                Surname = " Talibov",
                PosName = " Satish temsilchisi",
                Wage = 400,
                Mail = "samirtalib@gmail.com",
                Adress = "Baki sheheri",
                Salesquantity = "0",
                WorkAdress = Shops.Mango
            };

            Worker wrk2 = new Worker
            {
                Name = "Elgiz",
                Surname = " Eyvazli",
                PosName = " Satish temsilchisinin komekchisi",
                Wage = 300,
                Mail = "elgizeyvaz@gmail.com",
                Adress = "Baki sheheri",
                Salesquantity = "0",
                WorkAdress = Shops.Mango
            };

            Worker wrk3 = new Worker
            {
                Name = "Xelil",
                Surname = " Memmedov",
                PosName = " Bash satish temsilchisi ",
                Wage = 700,
                Mail = "xelilmemmed@gmail.com",
                Adress = "Baki sheheri",
                Salesquantity = "0",
                WorkAdress = Shops.Mango
            };

            Worker wrk4 = new Worker
            {
                Name = "Sakit",
                Surname = " Ezimov",
                PosName = " Magaza meneceri",
                Wage = 500,
                Mail = "sakitezim@gmail.com",
                Adress = "Baki sheheri",
                Salesquantity = "0",
                WorkAdress = Shops.Mango
            };

            Worker wrk5 = new Worker
            {
                Name = "Nicat",
                Surname = " Sadixov",
                PosName = " Magaza menecerinin komekchisi",
                Wage = 420,
                Mail = "nicatsadix@gmail.com",
                Adress = "Baki sheheri",
                Salesquantity="0",
                WorkAdress = Shops.Mango


            };
            Worker[] mangoarray = new Worker[5] { wrk1, wrk2, wrk3, wrk4, wrk5 };
            for (int i = 0; i < 5; i++)
            {
                adminarray[i] = mangoarray[i];
            }
            Worker wrk6 = new Worker
            {
                Name = "Sakit",
                Surname = " Xelilov",
                PosName = " Satish temsilchisi",
                Wage = 400,
                Mail = "sakitxelil@gmail.com",
                Adress = "Baki sheheri",
                Salesquantity = "0",
                WorkAdress = Shops.PullBear
            };

            Worker wrk7 = new Worker
            {
                Name = "Nicat",
                Surname = " Eliyev",
                PosName = " Satish temsilchisinin komekchisi",
                Wage = 300,
                Mail = "nicateliyev@gmail.com",
                Adress = "Baki sheheri",
                Salesquantity = "0",
                WorkAdress = Shops.PullBear
            };

            Worker wrk8 = new Worker
            {
                Name = "Shahin",
                Surname = " Cabbarov",
                PosName = " Bash satish temsilchisi ",
                Wage = 700,
                Mail = "shahincabbar@gmail.com",
                Adress = "Baki sheheri",
                Salesquantity = "0",
                WorkAdress = Shops.PullBear
            };

            Worker wrk9 = new Worker
            {
                Name = "Xaver",
                Surname = " Memmedova",
                PosName = " Magaza meneceri",
                Wage = 500,
                Mail = "xavermemmedova@gmail.com",
                Adress = "Baki sheheri",
                Salesquantity = "0",
                WorkAdress = Shops.PullBear
            };

            Worker wrk10 = new Worker();
            wrk10.Name = "Gunay";
            wrk10.Surname = " Babazade";
            wrk10.PosName = " Magaza menecerinin komekchisi";
            wrk10.Wage = 420;
            wrk10.Mail = "gunaybaba@gmail.com";
            wrk10.Adress = "Baki sheheri";
            wrk10.Salesquantity = "0";
            wrk10.WorkAdress = Shops.PullBear;

            Worker wrk11 = new Worker();
            wrk11.Name = "Zamiq";
            wrk11.Surname = " Dadasov";
            wrk11.PosName = " Satish temsilchisi";
            wrk11.Wage = 400;
            wrk11.Mail = "zamiqdadash@gmail.com";
            wrk11.Adress = "Baki sheheri";
            wrk11.Salesquantity = "0";
            wrk11.WorkAdress = Shops.NWY;

            Worker wrk12 = new Worker();
            wrk12.Name = "Pervin";
            wrk12.Surname = " Ehmedov";
            wrk12.PosName = " Satish temsilchisinin komekchisi";
            wrk12.Wage = 300;
            wrk12.Mail = "pervinehmed@gmail.com";
            wrk12.Adress = "Baki sheheri";
            wrk12.Salesquantity = "0";
            wrk12.WorkAdress = Shops.NWY;

            Worker wrk13 = new Worker();
            wrk13.Name = "Zahid";
            wrk13.Surname = " Cabbarli";
            wrk13.PosName = " Bash satish temsilchisi ";
            wrk13.Wage = 700;
            wrk13.Mail = "zadihcabbar@gmail.com";
            wrk13.Adress = "Baki sheheri";
            wrk13.Salesquantity = "0";
            wrk13.WorkAdress = Shops.NWY;

            Worker wrk14 = new Worker();
            wrk14.Name = "Meryem";
            wrk14.Surname = " Gozelova";
            wrk14.PosName = " Magaza meneceri";
            wrk14.Wage = 500;
            wrk14.Mail = "meryemgozel@gmail.com";
            wrk14.Adress = "Baki sheheri";
            wrk14.Salesquantity = "0";
            wrk14.WorkAdress = Shops.NWY;

            Worker wrk15 = new Worker();
            wrk15.Name = "Mehemmed";
            wrk15.Surname = " Ezizli";
            wrk15.PosName = " Magaza menecerinin komekchisi";
            wrk15.Wage = 420;
            wrk15.Mail = "mehemmedeziz@gmail.com";
            wrk15.Adress = "Baki sheheri";
            wrk15.Salesquantity = "0";
            wrk15.WorkAdress = Shops.NWY;

            Worker wrk16 = new Worker();
            wrk16.Name = "Akshin";
            wrk16.Surname = " Qasimov";
            wrk16.PosName = " Satish temsilchisi";
            wrk16.Wage = 400;
            wrk16.Mail = "akshinqasim@gmail.com";
            wrk16.Adress = "Baki sheheri";
            wrk16.Salesquantity = "0";
            wrk16.WorkAdress = Shops.Bershka;

            Worker wrk17 = new Worker();
            wrk17.Name = "Sahib";
            wrk17.Surname = " Sahibli";
            wrk17.PosName = " Satish temsilchisinin komekchisi";
            wrk17.Wage = 300;
            wrk17.Mail = "sahibsahibli@gmail.com";
            wrk17.Adress = "Baki sheheri";
            wrk17.Salesquantity = "0";
            wrk17.WorkAdress = Shops.Bershka;

            Worker wrk18 = new Worker();
            wrk18.Name = "Kamran";
            wrk18.Surname = " Kazimov";
            wrk18.PosName = " Bash satish temsilchisi ";
            wrk18.Wage = 700;
            wrk18.Mail = "kamrankazim@gmail.com";
            wrk18.Adress = "Baki sheheri";
            wrk18.Salesquantity = "0";
            wrk18.WorkAdress = Shops.Bershka;

            Worker wrk19 = new Worker();
            wrk19.Name = "Aygun";
            wrk19.Surname = " Bedelova";
            wrk19.PosName = " Magaza meneceri";
            wrk19.Wage = 500;
            wrk19.Mail = "aygunbedel@gmail.com";
            wrk19.Adress = "Baki sheheri";
            wrk19.Salesquantity = "0";
            wrk19.WorkAdress = Shops.Bershka;

            Worker wrk20 = new Worker();
            wrk20.Name = "Musa";
            wrk20.Surname = " Balayev";
            wrk20.PosName = " Magaza menecerinin komekchisi";
            wrk20.Wage = 420;
            wrk20.Mail = "musabala@gmail.com";
            wrk20.Adress = "Baki sheheri";
            wrk20.Salesquantity = "0";
            wrk20.WorkAdress = Shops.Bershka;
            Worker[] workers = new Worker[20] { wrk1, wrk2, wrk3, wrk4, wrk5, wrk6, wrk7, wrk8, wrk9, wrk10, wrk11, wrk12, wrk13, wrk14, wrk15, wrk16, wrk17, wrk18, wrk19, wrk20 };
            int k = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                k++;
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = workers[i].Name;
                dgv.Rows[i].Cells[1].Value = workers[i].Surname;
                dgv.Rows[i].Cells[2].Value = workers[i].PosName;
                dgv.Rows[i].Cells[3].Value = workers[i].Wage;
                dgv.Rows[i].Cells[4].Value = workers[i].WorkAdress;
                if (workers[i].WorkAdress == Shops.Mango)
                {
                    dgv.Rows[i].Cells[5].Value = grades[0].Name;
                }
                else if (workers[i].WorkAdress == Shops.PullBear)
                {
                    dgv.Rows[i].Cells[5].Value = grades[1].Name;
                }
                else if (workers[i].WorkAdress == Shops.Bershka)
                {
                    dgv.Rows[i].Cells[5].Value = grades[3].Name;
                }
                else if (workers[i].WorkAdress == Shops.NWY)
                {
                    dgv.Rows[i].Cells[5].Value = grades[2].Name;
                }
                dgv.Rows[i].Cells[7].Value = 0;
                wrkrs[i] = workers[i];
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (Convert.ToString(dgv.Rows[i].Cells[8].Value) == "True")
                {
                    if (i<mangoarrays.Length && mangoarrays[i]!=null)
                    {
                        if (Convert.ToString(dgv.Rows[i].Cells[5].Value) == "G01")
                        {
                            int Count = 0;
                            foreach (var item in mangoarrays)
                            {
                                Count += Convert.ToInt32(item.Salesquantity);
                            }
                            if (Count >= grds[0].Price)
                            {
                                dgv.Rows[i].Cells[7].Value = wrkrs[i].Wage + 20;
                            }
                            else
                            {
                                MessageBox.Show("Satilan mallarin miqdari verilen plankadan ashagid!!!");
                            }
                        }
                        
                    }
                    else if (i<mangoarrays.Length && mangoarrays[i]==null && dgv.Rows[i].Cells[4].ToString() == "Mango")
                    {
                        MessageBox.Show("Bu magazada satish edilmeyib.Manager forma daxil olun!!!");
                    }
                     if (bershkaArr[count] != null)
                    {
                        if (Convert.ToString(dgv.Rows[i].Cells[5].Value) == "G04")
                        {
                            int Count = 0;
                            foreach (var item in bershkaArr)
                            {
                                Count += Convert.ToInt32(item.Salesquantity);
                            }
                            if (Count >= grds[2].Price)
                            {
                                dgv.Rows[i].Cells[7].Value = wrkrs[i].Wage + 100;
                            }
                            else
                            {
                                MessageBox.Show("Satilan mallarin miqdari verilen plankadan ashagid!!!");
                            }
                        }
                    }
                    else if (bershkaArr[count] == null && dgv.Rows[i].Cells[4].ToString()=="Bershka")
                    {
                        MessageBox.Show("Bu magazada satish edilmeyib.Manager forma daxil olun!!!");
                    }
                     if (nwyarray[count] != null)
                    {
                        if (Convert.ToString(dgv.Rows[i].Cells[5].Value) == "G03")
                        {
                            int Count = 0;
                            foreach (var item in nwyarray)
                            {
                                Count += Convert.ToInt32(item.Salesquantity);
                            }
                            if (Count >= grds[1].Price)
                            {
                                dgv.Rows[i].Cells[7].Value = wrkrs[i].Wage + grds[1].Price * 0.01 / 5;
                            }
                            else
                            {
                                MessageBox.Show("Satilan mallarin miqdari verilen plankadan ashagid!!!");
                            }
                        }
                    }
                    else if (nwyarray[count] == null && dgv.Rows[i].Cells[4].ToString() == "NWY")
                    {
                        MessageBox.Show("Bu magazada satish edilmeyib.Manager forma daxil olun!!!");
                    }
                     if (pullbeararray[count] != null)
                    {
                        if (Convert.ToString(dgv.Rows[i].Cells[5].Value) == "G02")
                        {
                            int Count = 0;
                            foreach (var item in pullbeararray)
                            {
                                int a = Convert.ToInt32(item.Salesquantity);
                                Count +=a;
                            }
                            if (Count >= grds[3].Price)
                            {
                                dgv.Rows[i].Cells[7].Value = wrkrs[i].Wage + 40;
                            }
                            else
                            {
                                MessageBox.Show("Satilan mallarin miqdari verilen plankadan ashagid!!!");
                            }
                        }
                    }
                    else if (pullbeararray[count] == null && dgv.Rows[i].Cells[4].ToString() == "PullBear")
                    {
                        MessageBox.Show("Bu magazada satish edilmeyib.Manager forma daxil olun!!!");
                    }
                }
                if (count==4)
                {
                    count=0;
                }
                else
                {
                    count++;
                }
            }

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                chkbx.Add(checkboxes);
        }
    }
}
