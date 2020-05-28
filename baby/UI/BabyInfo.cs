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
    public partial class BabyInfo : Form
    {
        Baby baby;
        BabyDB db;
        public BabyInfo(Baby baby)
        {
            InitializeComponent();
            this.baby = baby;
            db = new BabyDB();

            textBox1.Text = baby.Name;
            textBox2.Text = baby.Gender;
            textBox3.Text = baby.Birthday;
            textBox4.Text = baby.Age;
            textBox5.Text = baby.Weight;
            textBox6.Text = baby.Height;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baby.Name = textBox1.Text;
            baby.Gender = textBox2.Text;
            baby.Birthday = textBox3.Text;
            baby.Age = textBox4.Text;
            baby.Weight = textBox5.Text;
            baby.Height = textBox6.Text;
        }
    }
}
