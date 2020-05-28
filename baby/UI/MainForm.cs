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
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            new Magazine().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BabyInfo(babyDB.AddBaby()).ShowDialog();
            babyDB.SaveBaby();
        }
    }
}
