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
        BabyDB db;

        public Form1()
        {
            InitializeComponent();
            db = new BabyDB();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            new BabyInfo(db.AddBaby()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Magazine().ShowDialog();
        }
    }
}
