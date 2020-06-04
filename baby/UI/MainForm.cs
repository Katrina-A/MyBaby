using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baby
{
    public partial class Form1 : Form
    {
        BabyDB babyDB;
        public Form1()
        {
            InitializeComponent();
            babyDB = new BabyDB();
            ShowBabyInfo();
        }

        void ShowBabyInfo()
        {
            textBox2.Text = babyDB.babyinfo.Name;
            textBox1.Text = babyDB.babyinfo.Gender;
            textBox3.Text = babyDB.babyinfo.Birthday;
            textBox4.Text = babyDB.babyinfo.Age;
            textBox5.Text = babyDB.babyinfo.Height;
            textBox6.Text = babyDB.babyinfo.Weight;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Magazine().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BabyInfo(babyDB.babyinfo).ShowDialog();
            babyDB.SaveBaby();
            ShowBabyInfo();
        }
    }
}
